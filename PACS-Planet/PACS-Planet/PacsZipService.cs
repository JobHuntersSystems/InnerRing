using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace PACS_Planet
{
	public class PacsZipService
	{
		public class ChallengeConfig
		{
			public int FileCount { get; set; }
			public int LettersPerFile { get; set; }
		}

		public class PacsZipResult
		{
			public string ConfigPath { get; set; }
			public string WorkFolder { get; set; }
			public string FilesFolder { get; set; }
			public string ZipPath { get; set; }
			public int GeneratedFiles { get; set; }
			public long ZipSizeBytes { get; set; }
		}

		public PacsZipResult GeneratePacsZip(string baseFolder)
		{
			string workFolder = Path.Combine(baseFolder, "PACS_Work");
			string filesFolder = Path.Combine(workFolder, "GeneratedFiles");
			string zipPath = Path.Combine(workFolder, "PACS.zip");
			string configPath = Path.Combine(baseFolder, "PACS_Config.xml");

			EnsureChallengeConfigExists(configPath);

			ChallengeConfig config = ReadChallengeConfig(configPath);

			GenerateChallengeFiles(filesFolder, config.FileCount, config.LettersPerFile);

			CreatePacsZip(filesFolder, zipPath);

			FileInfo zipInfo = new FileInfo(zipPath);

			return new PacsZipResult
			{
				ConfigPath = configPath,
				WorkFolder = workFolder,
				FilesFolder = filesFolder,
				ZipPath = zipPath,
				GeneratedFiles = config.FileCount,
				ZipSizeBytes = zipInfo.Length
			};
		}

		private void EnsureChallengeConfigExists(string configPath)
		{
			if (File.Exists(configPath))
			{
				return;
			}

			XDocument document = new XDocument(
				new XElement("PACSConfig",
					new XElement("FileCount", 3),
					new XElement("LettersPerFile", 50)
				)
			);

			document.Save(configPath);
		}

		private ChallengeConfig ReadChallengeConfig(string configPath)
		{
			XDocument document = XDocument.Load(configPath);

			if (document.Root == null)
			{
				throw new Exception("PACS_Config.xml has no root element.");
			}

			XElement fileCountElement = document.Root.Element("FileCount");
			XElement lettersPerFileElement = document.Root.Element("LettersPerFile");

			if (fileCountElement == null)
			{
				throw new Exception("PACS_Config.xml is missing FileCount.");
			}

			if (lettersPerFileElement == null)
			{
				throw new Exception("PACS_Config.xml is missing LettersPerFile.");
			}

			int fileCount = int.Parse(fileCountElement.Value);
			int lettersPerFile = int.Parse(lettersPerFileElement.Value);

			if (fileCount <= 0)
			{
				throw new Exception("FileCount must be greater than 0.");
			}

			if (lettersPerFile <= 0)
			{
				throw new Exception("LettersPerFile must be greater than 0.");
			}

			return new ChallengeConfig
			{
				FileCount = fileCount,
				LettersPerFile = lettersPerFile
			};
		}

		private void GenerateChallengeFiles(string folderPath, int fileCount, int lettersPerFile)
		{
			if (Directory.Exists(folderPath))
			{
				Directory.Delete(folderPath, true);
			}

			Directory.CreateDirectory(folderPath);

			for (int i = 1; i <= fileCount; i++)
			{
				string fileName = "PACS_FILE_" + i.ToString("000") + ".txt";
				string filePath = Path.Combine(folderPath, fileName);

				string content = GenerateRandomLetters(lettersPerFile);

				File.WriteAllText(filePath, content, Encoding.UTF8);
			}
		}

		private string GenerateRandomLetters(int length)
		{
			const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			StringBuilder result = new StringBuilder();
			byte[] randomBytes = new byte[length];

			using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
			{
				rng.GetBytes(randomBytes);
			}

			for (int i = 0; i < randomBytes.Length; i++)
			{
				int index = randomBytes[i] % letters.Length;
				result.Append(letters[index]);
			}

			return result.ToString();
		}

		private void CreatePacsZip(string sourceFolder, string zipPath)
		{
			string zipFolder = Path.GetDirectoryName(zipPath);

			if (!Directory.Exists(zipFolder))
			{
				Directory.CreateDirectory(zipFolder);
			}

			if (File.Exists(zipPath))
			{
				File.Delete(zipPath);
			}

			ZipFile.CreateFromDirectory(sourceFolder, zipPath);
		}
	}
}