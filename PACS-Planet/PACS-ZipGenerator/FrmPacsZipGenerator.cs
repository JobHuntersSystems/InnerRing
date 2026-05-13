using PACS_Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACS_ZipGenerator
{
	public partial class FrmPacsZipGenerator : Form
	{

		private PacsZipService zipService;
		private PacsZipService.PacsZipResult lastZipResult;

		public FrmPacsZipGenerator()
		{
			InitializeComponent();

			InitializeZipGenerator();
		}

		private void InitializeZipGenerator()
		{
			zipService = new PacsZipService();

			zipService.ZipGenerated += ZipService_ZipGenerated;

			lstGenerator.AddLog(LogLevel.Info, "PACS ZIP generator loaded.");
			lstGenerator.AddLog(LogLevel.Info, "Waiting for operator command.");
		}

		private void btnGenerator_Click(object sender, EventArgs e)
		{
			try
			{
				btnGenerator.Enabled = false;

				lstGenerator.AddLog(LogLevel.Info, "Generating PACS files...");
				lstGenerator.AddLog(LogLevel.Info, "Creating PACS.zip...");

				lastZipResult = zipService.GeneratePacsZip(Application.StartupPath);

				lstGenerator.AddLog(LogLevel.Success, "ZIP generation process completed.");
			}
			catch (Exception ex)
			{
				lstGenerator.AddLog(LogLevel.Error, "ZIP generation failed.");

				MessageBox.Show(
					ex.Message,
					"PACS ZIP error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			finally
			{
				btnGenerator.Enabled = true;
			}
		}

		private void ZipService_ZipGenerated(object sender, EventArgs e)
		{
			PacsZipService.ZipGeneratedEventArgs args =
				(PacsZipService.ZipGeneratedEventArgs)e;

			lastZipResult = args.Result;

			lstGenerator.AddLog(LogLevel.Success, "PACS.zip created successfully.");
			lstGenerator.AddLog(LogLevel.Info, "Generated files: " + args.Result.GeneratedFiles);
			lstGenerator.AddLog(LogLevel.Info, "Letters per file: " + args.Result.LettersPerFile);
			lstGenerator.AddLog(LogLevel.Info, "ZIP size: " + args.Result.ZipSizeBytes + " bytes");
			lstGenerator.AddLog(LogLevel.Info, "ZIP path: " + args.Result.ZipPath);
		}
	}
}
