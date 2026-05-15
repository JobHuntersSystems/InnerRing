using System;
using System.Collections.Generic;
using System.IO;

namespace PACS_Services
{
	public class PacsChecksumService
	{
		public event EventHandler ChecksumCalculated;

		public class ChecksumCalculatedEventArgs : EventArgs
		{
			public int GlobalChecksum { get; set; }
		}

		// =========================================================
		// EVENTO: CHECKSUM CALCULADO
		// =========================================================
		// Este evento avisa al formulario o a cualquier clase suscrita
		// cuando el checksum global ya ha sido calculado.

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

		// =========================================================
		// CALCULAR CHECKSUM GLOBAL
		// =========================================================
		// Este método recibe:
		// - La carpeta donde están los archivos generados.
		// - El diccionario de codificación letra -> número.
		//
		// Luego calcula la suma total de todos los archivos.

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
			// Buscamos todos los archivos .txt dentro de la carpeta.
			string[] files = Directory.GetFiles(folderPath, "*.txt");

			if (files.Length == 0)
			{
				throw new Exception("No .txt files found in folder: " + folderPath);
			}

			int globalTotal = 0;

			foreach (string filePath in files)
			{
				int fileTotal = CalculateFileChecksum(filePath, codification);
				globalTotal += fileTotal;
			}

			RaiseChecksumCalculated(globalTotal);

			return globalTotal;
		}

		// =========================================================
		// CALCULAR CHECKSUM DE UN ARCHIVO
		// =========================================================
		// Este método lee un archivo, transforma cada letra usando el diccionario
		// y suma los dígitos de cada código numérico.
		//
		// Regla importante:
		// Si un dígito es 0, cuenta como 10.
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