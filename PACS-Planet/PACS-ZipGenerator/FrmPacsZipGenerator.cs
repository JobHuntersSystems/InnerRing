using PACS_Common;
using PACS_Services;
using System;
using System.Windows.Forms;

namespace PACS_ZipGenerator
{
	public partial class FrmPacsZipGenerator : Form
	{
		private PacsZipService zipService;
		private PacsZipService.PacsZipResult lastZipResult;
		private PacsZipService.PacsZipSendResult lastSendResult;

		// =========================================================
		// EVENTO PÚBLICO PARA EL MAIN
		// =========================================================

		public event EventHandler ZipSentToMain;

		public class ZipSentToMainEventArgs : EventArgs
		{
			public PacsZipService.PacsZipSendResult Result { get; set; }
		}

		protected virtual void OnZipSentToMain(ZipSentToMainEventArgs e)
		{
			if (ZipSentToMain != null)
			{
				ZipSentToMain(this, e);
			}
		}

		private void RaiseZipSentToMain(PacsZipService.PacsZipSendResult result)
		{
			OnZipSentToMain(new ZipSentToMainEventArgs
			{
				Result = result
			});
		}

		public FrmPacsZipGenerator()
		{
			InitializeComponent();

			InitializeZipGenerator();
		}

		private void InitializeZipGenerator()
		{
			zipService = new PacsZipService();

			// Suscripción a los eventos internos del servicio.
			zipService.ZipGenerated += ZipService_ZipGenerated;
			zipService.ZipSent += ZipService_ZipSent;

			// No se puede enviar el ZIP hasta que primero se haya generado.
			btnSend.Enabled = false;

			lstGenerator.AddLog(LogLevel.Info, "PACS ZIP generator loaded.");
			lstGenerator.AddLog(LogLevel.Info, "Waiting for operator command.");
		}

		private void btnGenerator_Click(object sender, EventArgs e)
		{
			try
			{
				btnGenerator.Enabled = false;
				btnSend.Enabled = false;

				lstGenerator.AddLog(LogLevel.Info, "Generating PACS files...");
				lstGenerator.AddLog(LogLevel.Info, "Creating PACS.zip...");

				// Application.StartupPath es la carpeta donde se está ejecutando la aplicación.
				// Ahí debe estar PACS_Config.xml.
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

		private void btnSend_Click(object sender, EventArgs e)
		{
			try
			{
				if (lastZipResult == null)
				{
					MessageBox.Show(
						"You must generate PACS.zip before sending it.",
						"Send ZIP unavailable",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
					);

					return;
				}

				btnSend.Enabled = false;

				lstGenerator.AddLog(LogLevel.Info, "Preparing PACS.zip for sending...");
				lstGenerator.AddLog(LogLevel.Info, "TCP/IP is not connected yet. Send will be simulated.");

				/*
				 * TEMPORARY PLACEHOLDER.
				 *
				 * Más adelante este destinationIp deberá ser la IP real de la nave.
				 * Por ahora se usa un texto para indicar que TCP/IP aún no está conectado.
				 */

				string destinationIp = "TCP_NOT_CONNECTED";

				lastSendResult = zipService.SendPacsZip(
					lastZipResult.ZipPath,
					destinationIp
				);
			}
			catch (Exception ex)
			{
				lstGenerator.AddLog(LogLevel.Error, "ZIP send failed.");

				MessageBox.Show(
					ex.Message,
					"PACS ZIP send error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
			finally
			{
				if (lastZipResult != null)
				{
					btnSend.Enabled = true;
				}
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

			// Una vez creado el ZIP, ya se permite enviarlo.
			btnSend.Enabled = true;
		}

		private void ZipService_ZipSent(object sender, EventArgs e)
		{
			PacsZipService.ZipSentEventArgs args =
				(PacsZipService.ZipSentEventArgs)e;

			lastSendResult = args.Result;

			if (args.Result.Sent)
			{
				lstGenerator.AddLog(LogLevel.Success, "PACS.zip send completed.");
				lstGenerator.AddLog(LogLevel.Info, "Send mode: SIMULATED");
				lstGenerator.AddLog(LogLevel.Info, "Destination: " + args.Result.DestinationIp);
				lstGenerator.AddLog(LogLevel.Info, "ZIP size: " + args.Result.ZipSizeBytes + " bytes");
				lstGenerator.AddLog(LogLevel.Info, args.Result.Message);
			}
			else
			{
				lstGenerator.AddLog(LogLevel.Error, "PACS.zip was not sent.");
				lstGenerator.AddLog(LogLevel.Error, args.Result.Message);
			}

			RaiseZipSentToMain(args.Result);
		}

		public PacsZipService.PacsZipResult GetLastZipResult()
		{
			return lastZipResult;
		}

		public PacsZipService.PacsZipSendResult GetLastSendResult()
		{
			return lastSendResult;
		}
	}
}