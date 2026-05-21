using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace PACS_Services
{
	public class PacsZipService
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

		public class PacsZipExtractResult
		{
			public string ZipPath { get; set; }
			public string ExtractFolder { get; set; }
			public int ExtractedFiles { get; set; }
		}

		public class PacsZipSendResult
		{
			public string ZipPath { get; set; }
			public long ZipSizeBytes { get; set; }
			public string DestinationIp { get; set; }
			public bool Sent { get; set; }
			public string Message { get; set; }
		}

		// =========================================================
		// EVENTO: ZIP GENERADO
		// =========================================================
		// Este evento avisa a cualquier formulario/clase suscrita
		// cuando PACS.zip ya ha sido creado correctamente.

		public event EventHandler ZipGenerated;

		public class ZipGeneratedEventArgs : EventArgs
		{
			public PacsZipResult Result { get; set; }
		}

		protected virtual void OnZipGenerated(ZipGeneratedEventArgs e)
		{
			if (ZipGenerated != null)
			{
				ZipGenerated(this, e);
			}
		}

		private void RaiseZipGenerated(PacsZipResult result)
		{
			OnZipGenerated(new ZipGeneratedEventArgs
			{
				Result = result
			});
		}

		// =========================================================
		// EVENTO: ZIP EXTRAÍDO
		// =========================================================
		// Este evento avisa cuando el ZIP ha sido extraído/descomprimido.

		public event EventHandler ZipExtracted;

		public class ZipExtractedEventArgs : EventArgs
		{
			public PacsZipExtractResult Result { get; set; }
		}

		protected virtual void OnZipExtracted(ZipExtractedEventArgs e)
		{
			if (ZipExtracted != null)
			{
				ZipExtracted(this, e);
			}
		}

		private void RaiseZipExtracted(PacsZipExtractResult result)
		{
			OnZipExtracted(new ZipExtractedEventArgs
			{
				Result = result
			});
		}

		// =========================================================
		// EVENTO: ZIP ENVIADO
		// =========================================================
		// Este evento avisa cuando el ZIP ha sido "enviado".
		// Por ahora el envío es simulado porque TCP/IP todavía no está conectado.

		public event EventHandler ZipSent;

		public class ZipSentEventArgs : EventArgs
		{
			public PacsZipSendResult Result { get; set; }
		}

		protected virtual void OnZipSent(ZipSentEventArgs e)
		{
			if (ZipSent != null)
			{
				ZipSent(this, e);
			}
		}

		private void RaiseZipSent(PacsZipSendResult result)
		{
			OnZipSent(new ZipSentEventArgs
			{
				Result = result
			});
		}

		// =========================================================
		// GENERAR ARCHIVOS Y ZIP
		// =========================================================
		// Método principal de esta clase.
		// Recibe una carpeta base, busca PACS_Config.xml, genera los archivos
		// de letras aleatorias y luego los comprime en PACS.zip.

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

			PacsZipResult result = new PacsZipResult
			{
				ConfigPath = configPath,
				WorkFolder = workFolder,
				FilesFolder = filesFolder,
				ZipPath = zipPath,
				GeneratedFiles = config.FileCount,
				LettersPerFile = config.LettersPerFile,
				ZipSizeBytes = zipInfo.Length
			};

			RaiseZipGenerated(result);

			return result;
		}

		// =========================================================
		// ENVIAR ZIP
		// =========================================================
		// Por ahora este método NO envía por TCP/IP realmente.
		// Solo valida que el ZIP existe y simula el envío.
		// Más adelante aquí se conectará el módulo TCP/file transfer.

		public PacsZipSendResult SendPacsZip(string zipPath, string destinationIp)
		{
			if (string.IsNullOrWhiteSpace(zipPath))
			{
				throw new Exception("ZIP path cannot be empty.");
			}

			if (!File.Exists(zipPath))
			{
				throw new Exception("ZIP file does not exist: " + zipPath);
			}

			if (string.IsNullOrWhiteSpace(destinationIp))
			{
				destinationIp = "TCP_NOT_CONNECTED";
			}

			FileInfo zipInfo = new FileInfo(zipPath);

			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later:
			 * - Connect this method to the TCP/file transfer module.
			 * - Send the real PACS.zip to the spaceship.
			 */

			PacsZipSendResult result = new PacsZipSendResult
			{
				ZipPath = zipPath,
				ZipSizeBytes = zipInfo.Length,
				DestinationIp = destinationIp,
				Sent = true,
				Message = "PACS.zip send simulated successfully. TCP/IP is not connected yet."
			};

			RaiseZipSent(result);

			return result;
		}

		public PacsZipSendResult SendPacsZipFromBaseFolder(string baseFolder, string destinationIp)
		{
			if (string.IsNullOrWhiteSpace(baseFolder))
			{
				throw new Exception("Base folder cannot be empty.");
			}

			if (!Directory.Exists(baseFolder))
			{
				throw new Exception("Base folder does not exist: " + baseFolder);
			}

			XMLConfig config = LoadXMLConfig(baseFolder);

			string workFolder = BuildPath(baseFolder, config.WorkFolder);
			string zipPath = BuildPath(workFolder, config.ZipFileName);

			return SendPacsZip(zipPath, destinationIp);
		}

		// =========================================================
		// EXTRAER ZIP
		// =========================================================
		// Este método extrae el contenido de un ZIP a una carpeta.

		public PacsZipExtractResult ExtractPacsZip(string path)
		{
			string zipPath = Path.GetFileNameWithoutExtension(path);
			string extractFolder = Path.GetDirectoryName(path);

			if (string.IsNullOrWhiteSpace(path))
			{
				throw new Exception("ZIP path cannot be empty.");
			}

			if (!File.Exists(path))
			{
				throw new Exception("ZIP file does not exist: " + zipPath);
			}

			if (string.IsNullOrWhiteSpace(extractFolder))
			{
				throw new Exception("Extract folder cannot be empty.");
			}

			zipPath = Path.GetFullPath(path);
			extractFolder = Path.GetFullPath(extractFolder);


			ZipFile.ExtractToDirectory(zipPath, extractFolder);

			int extractedFiles = Directory.GetFiles(
				extractFolder,
				"*.*",
				SearchOption.AllDirectories
			).Length;

			PacsZipExtractResult result = new PacsZipExtractResult
			{
				ZipPath = zipPath,
				ExtractFolder = extractFolder,
				ExtractedFiles = extractedFiles
			};

			// Si la carpeta de extracción ya existe, se borra entera
			// para que no queden restos de extracciones anteriores.
			return result;
		}

		public void ClearFolderContent(string folderPath)
		{
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
				return;
			}

			string[] files = Directory.GetFiles(folderPath);

			foreach (string file in files)
			{
				File.Delete(file);
			}

			string[] directories = Directory.GetDirectories(folderPath);

			foreach (string directory in directories)
			{
				Directory.Delete(directory, true);
			}
		}

		// =========================================================
		// CARGAR CONFIGURACIÓN XML
		// =========================================================
		// Método público para leer PACS_Config.xml desde una carpeta base.

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

		// Lee y valida el contenido de PACS_Config.xml.
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

		// Lee un valor de texto obligatorio desde el XML.
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

		// Lee un número entero obligatorio desde el XML.
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

		// =========================================================
		// GENERACIÓN DE ARCHIVOS
		// =========================================================
		// Genera los archivos .txt que luego se meterán dentro del ZIP.

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

		// Genera una cadena de letras aleatorias usando RNGCryptoServiceProvider.
		// Se usa para que el contenido de los archivos no sea siempre igual.
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

		// Crea el archivo ZIP a partir de la carpeta de archivos generados.
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