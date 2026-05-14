using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace PACS_Services
{
	public class PacsChecksumService
	{
		public event EventHandler ChecksumCalculated;

		public class ChecksumCalculatedEventArgs : EventArgs
		{
			public int GlobalChecksum { get; set; }
		}

		protected virtual void OnChecksumCalculated(ChecksumCalculatedEventArgs e)
		{
			if (ChecksumCalculated != null)
			{
				ChecksumCalculated(this, e);
			}
		}

		private void RaiseChecksumCalculated(int globalChecksum)
		{
			OnChecksumCalculated(new ChecksumCalculatedEventArgs
			{
				GlobalChecksum = globalChecksum
			});
		}

		public int CalculateGlobalChecksum(string folderPath, Dictionary<char, string> codification)
		{
			if (string.IsNullOrWhiteSpace(folderPath))
			{
				throw new Exception("Folder path cannot be empty.");
			}

			if (!Directory.Exists(folderPath))
			{
				throw new Exception("Folder path does not exist: " + folderPath);
			}

			if (codification == null || codification.Count == 0)
			{
				throw new Exception("Codification dictionary cannot be empty.");
			}

			string[] files = Directory.GetFiles(folderPath, "*.txt");

			if (files.Length == 0)
			{
				throw new Exception("No .txt files found in folder: " + folderPath);
			}

			object lockObject = new object();
			int globalTotal = 0;

			Parallel.ForEach(files, filePath =>
			{
				int fileTotal = CalculateFileChecksum(filePath, codification);

				lock (lockObject)
				{
					globalTotal += fileTotal;
				}
			});

			RaiseChecksumCalculated(globalTotal);

			return globalTotal;
		}

		public int CalculateFileChecksum(string filePath, Dictionary<char, string> codification)
		{
			if (string.IsNullOrWhiteSpace(filePath))
			{
				throw new Exception("File path cannot be empty.");
			}

			if (!File.Exists(filePath))
			{
				throw new Exception("File does not exist: " + filePath);
			}

			string content = File.ReadAllText(filePath).ToUpper();

			int fileTotal = 0;

			foreach (char letter in content)
			{
				if (char.IsWhiteSpace(letter))
				{
					continue;
				}

				if (!codification.ContainsKey(letter))
				{
					throw new Exception("Letter '" + letter + "' does not exist in the codification dictionary.");
				}

				string numberCode = codification[letter];

				if (numberCode.Length != 3)
				{
					throw new Exception("Invalid code for letter '" + letter + "'. Expected 3 digits.");
				}

				foreach (char digitChar in numberCode)
				{
					if (!char.IsDigit(digitChar))
					{
						throw new Exception("Invalid digit in code '" + numberCode + "'.");
					}

					int digit = int.Parse(digitChar.ToString());

					if (digit == 0)
					{
						fileTotal += 10;
					}
					else
					{
						fileTotal += digit;
					}
				}
			}

			return fileTotal;
		}
	}
}