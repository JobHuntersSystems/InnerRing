using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace PACS_Planet
{
	public class PACS_ZipService
	{
		public class XMLConfig
		{
			public string WorkFolder { get; set; }
			public string GeneratedFilesFolder { get; set; }
			public string ZipFileName { get; set; }
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
			public int LettersPerFile { get; set; }
			public long ZipSizeBytes { get; set; }
		}

		public PacsZipResult GeneratePacsZip(string baseFolder)
		{
			if (string.IsNullOrWhiteSpace(baseFolder))
			{
				throw new Exception("Base folder cannot be empty.");
			}

			if (!Directory.Exists(baseFolder))
			{
				throw new Exception("Base folder does not exist: " + baseFolder);
			}

			string configPath = Path.Combine(baseFolder, "PACS_Config.xml");

			XMLConfig config = ReadXMLConfig(configPath);

			string workFolder = BuildPath(baseFolder, config.WorkFolder);
			string filesFolder = BuildPath(workFolder, config.GeneratedFilesFolder);
			string zipPath = BuildPath(workFolder, config.ZipFileName);

			GenerateFiles(filesFolder, config.FileCount, config.LettersPerFile);

			CreatePacsZip(filesFolder, zipPath);

			FileInfo zipInfo = new FileInfo(zipPath);

			return new PacsZipResult
			{
				ConfigPath = configPath,
				WorkFolder = workFolder,
				FilesFolder = filesFolder,
				ZipPath = zipPath,
				GeneratedFiles = config.FileCount,
				LettersPerFile = config.LettersPerFile,
				ZipSizeBytes = zipInfo.Length
			};
		}

		public XMLConfig LoadXMLConfig(string baseFolder)
		{
			if (string.IsNullOrWhiteSpace(baseFolder))
			{
				throw new Exception("Base folder cannot be empty.");
			}

			if (!Directory.Exists(baseFolder))
			{
				throw new Exception("Base folder does not exist: " + baseFolder);
			}

			string configPath = Path.Combine(baseFolder, "PACS_Config.xml");

			return ReadXMLConfig(configPath);
		}

		private XMLConfig ReadXMLConfig(string configPath)
		{
			if (!File.Exists(configPath))
			{
				throw new Exception("PACS_Config.xml was not found at: " + configPath);
			}

			XDocument document = XDocument.Load(configPath);

			if (document.Root == null)
			{
				throw new Exception("PACS_Config.xml has no root element.");
			}

			string workFolder = ReadRequiredString(document, "WorkFolder");
			string generatedFilesFolder = ReadRequiredString(document, "GeneratedFilesFolder");
			string zipFileName = ReadRequiredString(document, "ZipFileName");

			int fileCount = ReadRequiredInt(document, "FileCount");
			int lettersPerFile = ReadRequiredInt(document, "LettersPerFile");

			if (fileCount <= 0)
			{
				throw new Exception("FileCount must be greater than 0.");
			}

			if (lettersPerFile <= 0)
			{
				throw new Exception("LettersPerFile must be greater than 0.");
			}

			if (!zipFileName.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
			{
				throw new Exception("ZipFileName must end with .zip.");
			}

			return new XMLConfig
			{
				WorkFolder = workFolder,
				GeneratedFilesFolder = generatedFilesFolder,
				ZipFileName = zipFileName,
				FileCount = fileCount,
				LettersPerFile = lettersPerFile
			};
		}

		private string ReadRequiredString(XDocument document, string elementName)
		{
			XElement element = document.Root.Element(elementName);

			if (element == null)
			{
				throw new Exception("PACS_Config.xml is missing " + elementName + ".");
			}

			string value = element.Value.Trim();

			if (string.IsNullOrWhiteSpace(value))
			{
				throw new Exception(elementName + " cannot be empty.");
			}

			return value;
		}

		private int ReadRequiredInt(XDocument document, string elementName)
		{
			string value = ReadRequiredString(document, elementName);

			int number;

			if (!int.TryParse(value, out number))
			{
				throw new Exception(elementName + " must be a valid number.");
			}

			return number;
		}

		private string BuildPath(string basePath, string childPath)
		{
			if (Path.IsPathRooted(childPath))
			{
				return childPath;
			}

			return Path.Combine(basePath, childPath);
		}

		private void GenerateFiles(string folderPath, int fileCount, int lettersPerFile)
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
			if (!Directory.Exists(sourceFolder))
			{
				throw new Exception("Source folder does not exist: " + sourceFolder);
			}

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