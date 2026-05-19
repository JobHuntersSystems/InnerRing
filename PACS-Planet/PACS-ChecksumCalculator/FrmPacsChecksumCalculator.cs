using PACS_Common;
using PACS_Services;
using Inner_DB_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PACS_ChecksumCalculator
{
	public partial class FrmPacsChecksumCalculator : Form
	{
		private PacsChecksumService checksumService;
		private int lastChecksum;

		public event EventHandler ChecksumCalculatedToMain;

		public class ChecksumCalculatedToMainEventArgs : EventArgs
		{
			public int GlobalChecksum { get; set; }
		}

		protected virtual void OnChecksumCalculatedToMain(ChecksumCalculatedToMainEventArgs e)
		{
			if (ChecksumCalculatedToMain != null)
			{
				ChecksumCalculatedToMain(this, e);
			}
		}

		private void RaiseChecksumCalculatedToMain(int globalChecksum)
		{
			OnChecksumCalculatedToMain(new ChecksumCalculatedToMainEventArgs
			{
				GlobalChecksum = globalChecksum
			});
		}

		public FrmPacsChecksumCalculator()
		{
			InitializeComponent();

			InitializeChecksumCalculator();
		}

		private void InitializeChecksumCalculator()
		{
			checksumService = new PacsChecksumService();

			// Nos suscribimos al evento interno del servicio.
			// Cuando el servicio termine el cálculo, se ejecutará
			// ChecksumService_ChecksumCalculated.
			checksumService.ChecksumCalculated += ChecksumService_ChecksumCalculated;

			lstCalculator.AddLog(LogLevel.Info, "PACS checksum calculator loaded.");
			lstCalculator.AddLog(LogLevel.Info, "Waiting for operator command.");
		}

		private void btnChecksum_Click(object sender, EventArgs e)
		{
			try
			{
				btnChecksum.Enabled = false;

				lstCalculator.AddLog(LogLevel.Info, "Starting checksum calculation...");
				lstCalculator.AddLog(LogLevel.Info, "Loading codification dictionary from database...");

				// Cargamos el diccionario letra -> número desde la base de datos.
				Dictionary<char, string> codification = GetCodificationDictionaryFromDatabase();

				lstCalculator.AddLog(LogLevel.Success, "Codification dictionary loaded.");
				lstCalculator.AddLog(LogLevel.Info, "Letters loaded: " + codification.Count);

				// Carpeta donde el generador ZIP dejó los archivos .txt.
				string generatedFilesFolder = Path.Combine(
					Application.StartupPath,
					"PACS_Files",
					"GeneratedFiles"
				);

				lstCalculator.AddLog(LogLevel.Info, "Generated files folder:");
				lstCalculator.AddLog(LogLevel.Info, generatedFilesFolder);

				// Calcula el checksum total usando los archivos y el diccionario.
				lastChecksum = checksumService.CalculateGlobalChecksum(
					generatedFilesFolder,
					codification
				);

				lstCalculator.AddLog(LogLevel.Success, "Checksum calculation process completed.");
			}
			catch (Exception ex)
			{
				lstCalculator.AddLog(LogLevel.Error, "Checksum calculation failed.");

				MessageBox.Show(
					ex.Message,
					"PACS checksum error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			finally
			{
				btnChecksum.Enabled = true;
			}
		}

		private void ChecksumService_ChecksumCalculated(object sender, EventArgs e)
		{
			PacsChecksumService.ChecksumCalculatedEventArgs args =
				(PacsChecksumService.ChecksumCalculatedEventArgs)e;

			lastChecksum = args.GlobalChecksum;

			lstCalculator.AddLog(LogLevel.Success, "Planet checksum calculated.");
			lstCalculator.AddLog(LogLevel.Info, "Global checksum: " + args.GlobalChecksum);
			RaiseChecksumCalculatedToMain(args.GlobalChecksum);
		}

		private Dictionary<char, string> GetCodificationDictionaryFromDatabase()
		{
			Dictionary<char, string> codification = new Dictionary<char, string>();

			DB_CRUD db = new DB_CRUD();

			int idPlanet = Planet.idPlanet;

			if (idPlanet <= 0)
			{
				throw new Exception("No valid planet selected. Planet.idPlanet is empty or invalid.");
			}

			// Word = letra
			// Numbers = código numérico de 3 dígitos.
			string query =
				"SELECT d.Word, d.Numbers " +
				"FROM InnerEncryptionData d " +
				"INNER JOIN InnerEncryption e " +
				"ON d.idInnerEncryption = e.idInnerEncryption " +
				"WHERE e.idPlanet = " + idPlanet;

			DataTable dt = db.PortarDataTable(query);

			if (dt.Rows.Count == 0)
			{
				throw new Exception("No codification data found for planet ID " + idPlanet + ".");
			}

			foreach (DataRow row in dt.Rows)
			{
				string wordValue = row["Word"].ToString();
				string numberValue = row["Numbers"].ToString();

				if (string.IsNullOrWhiteSpace(wordValue))
				{
					throw new Exception("A codification row has an empty Word value.");
				}

				if (string.IsNullOrWhiteSpace(numberValue))
				{
					throw new Exception("A codification row has an empty Numbers value.");
				}

				char letter = char.ToUpper(wordValue[0]);

				if (numberValue.Length != 3)
				{
					throw new Exception(
						"Invalid number code for letter '" + letter + "'. Expected exactly 3 digits."
					);
				}

				foreach (char digit in numberValue)
				{
					if (!char.IsDigit(digit))
					{
						throw new Exception(
							"Invalid number code for letter '" + letter + "'. Only digits are allowed."
						);
					}
				}

				if (codification.ContainsKey(letter))
				{
					throw new Exception("Duplicated codification letter found: " + letter);
				}

				codification.Add(letter, numberValue);
			}

			// El diccionario correcto debe contener las 26 letras del alfabeto.
			if (codification.Count != 26)
			{
				throw new Exception(
					"Codification dictionary must contain 26 letters. Current count: " + codification.Count
				);
			}

			return codification;
		}

		// Permite que otro formulario/clase consulte el último checksum calculado.
		public int GetLastChecksum()
		{
			return lastChecksum;
		}
	}
}