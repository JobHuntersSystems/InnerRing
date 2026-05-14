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

		public FrmPacsChecksumCalculator()
		{
			InitializeComponent();

			InitializeChecksumCalculator();
		}

		private void InitializeChecksumCalculator()
		{
			checksumService = new PacsChecksumService();

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

				Dictionary<char, string> codification = GetCodificationDictionaryFromDatabase();

				lstCalculator.AddLog(LogLevel.Success, "Codification dictionary loaded.");
				lstCalculator.AddLog(LogLevel.Info, "Letters loaded: " + codification.Count);

				string generatedFilesFolder = Path.Combine(
					Application.StartupPath,
					"PACS_Files",
					"GeneratedFiles"
				);

				lstCalculator.AddLog(LogLevel.Info, "Generated files folder:");
				lstCalculator.AddLog(LogLevel.Info, generatedFilesFolder);

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

			if (codification.Count != 26)
			{
				throw new Exception(
					"Codification dictionary must contain 26 letters. Current count: " + codification.Count
				);
			}

			return codification;
		}

		public int GetLastChecksum()
		{
			return lastChecksum;
		}
	}
}