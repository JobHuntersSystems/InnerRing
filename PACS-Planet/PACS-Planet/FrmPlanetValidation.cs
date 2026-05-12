using System;
using System.Windows.Forms;

namespace PACS_Planet
{
	public partial class FrmPlanetValidation : Form
	{
		// =========================================================
		// CURRENT PROTOCOL DATA
		// =========================================================

		private string currentShipId = "";
		private string currentDeliveryId = "";
		private string currentShipIp = "";

		private string encryptedValidationCode = "";
		private string decryptedValidationCode = "";

		private int planetChecksum = 0;
		private int shipChecksum = 0;

		// =========================================================
		// PROTOCOL FLAGS
		// =========================================================

		private bool erReceived = false;
		private bool entryValidated = false;
		private bool vr1Sent = false;

		private bool vkReceived = false;
		private bool keyValidated = false;
		private bool vr2Sent = false;

		private bool zipGenerated = false;
		private bool zipSent = false;
		private bool planetChecksumCalculated = false;

		private bool shipChecksumReceived = false;
		private bool finalResolved = false;

		public FrmPlanetValidation()
		{
			InitializeComponent();

			InitializeValidationForm();
		}

		private void InitializeValidationForm()
		{
			HideAllPanels();

			btnValidateEntry.Enabled = false;
			btnValidateKey.Enabled = false;
			btnCalculate.Enabled = false;
			btnAcces.Enabled = false;

			AddLog("Planet validation protocol loaded.");
			AddLog("Simulation mode active. TCP/IP will be connected later.");
			AddLog("Waiting for ER message from spaceship.");
		}

		private void HideAllPanels()
		{
			pnlStartProcess.Visible = false;
			pnlValidateKey.Visible = false;
			pnlCalculations.Visible = false;
			pnlResolveAccess.Visible = false;
		}

		private void ShowPanel(Panel panelToShow)
		{
			HideAllPanels();

			panelToShow.Visible = true;
			panelToShow.BringToFront();
		}

		private void AddLog(string message, string type = "INFO")
		{
			string timestamp = DateTime.Now.ToString("HH:mm:ss");
			string line = $"[{timestamp}] [{type.PadRight(5)}] {message}";

			LstProtocolLogs.Items.Add(line);

			if (LstProtocolLogs.Items.Count > 0)
			{
				LstProtocolLogs.TopIndex = LstProtocolLogs.Items.Count - 1;
			}
		}

		// =========================================================
		// NAVIGATION BUTTONS
		// These only open panels.
		// They do not execute protocol actions directly.
		// =========================================================

		private void btnValidateEntry_Click(object sender, EventArgs e)
		{
			if (!erReceived)
			{
				MessageBox.Show(
					"You cannot open this panel yet because no ER message has been received.",
					"Validate Entry unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			ShowPanel(pnlStartProcess);
			AddLog("Validate Entry panel opened.");
		}

		private void btnValidateKey_Click(object sender, EventArgs e)
		{
			if (!vkReceived)
			{
				MessageBox.Show(
					"You cannot open this panel yet because no VK message has been received.",
					"Validate Key unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			ShowPanel(pnlValidateKey);
			AddLog("Validate Key panel opened.");
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			if (!keyValidated)
			{
				MessageBox.Show(
					"You cannot prepare the challenge because the validation key has not been accepted yet.",
					"Prepare Challenge unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			ShowPanel(pnlCalculations);
			AddLog("Prepare Challenge panel opened.");
		}

		private void btnAcces_Click(object sender, EventArgs e)
		{
			if (!shipChecksumReceived)
			{
				MessageBox.Show(
					"You cannot resolve access because the spaceship checksum has not been received yet.",
					"Resolve Access unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			ShowPanel(pnlResolveAccess);
			AddLog("Resolve Access panel opened.");
		}

		// =========================================================
		// MESSAGE RECEIVER
		//
		// For now this is called by simulation buttons.
		// Later, the TCP service should call this method when
		// real data arrives from the spaceship.
		// =========================================================

		public void OnMessageReceived(string message, string remoteIp)
		{
			if (string.IsNullOrWhiteSpace(message))
			{
				AddLog("Empty message received.", "ERROR");
				return;
			}

			AddLog("Message received from " + remoteIp + ": " + message, "RECV");

			if (message.StartsWith("ER"))
			{
				HandleER(message, remoteIp);
			}
			else if (message.StartsWith("VK"))
			{
				HandleVK(message);
			}
			else if (int.TryParse(message, out _))
			{
				HandleShipChecksum(message);
			}
			else
			{
				AddLog("Unknown message format.", "ERROR");

				MessageBox.Show(
					"Unknown message format received:\n\n" + message,
					"Protocol error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		// =========================================================
		// ER HANDLING
		//
		// Format:
		// ERSSSSSSSSSSSSCCCCCCCCCCCC
		// ER = 2 chars
		// Ship ID = 12 chars
		// Delivery ID = 12 chars
		// =========================================================

		private void HandleER(string message, string remoteIp)
		{
			if (erReceived)
			{
				AddLog("A new ER was received, but the current process already has an ER.", "ERROR");

				MessageBox.Show(
					"An ER message has already been received for the current process.",
					"ER already received",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			AddLog("Processing ER message...");

			if (message.Length != 26)
			{
				AddLog("Invalid ER message length. Expected 26 characters.", "ERROR");

				MessageBox.Show(
					"Invalid ER message length.\nExpected 26 characters.",
					"ER error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}

			currentShipId = message.Substring(2, 12);
			currentDeliveryId = message.Substring(14, 12);
			currentShipIp = remoteIp;

			erReceived = true;

			lblEntryShipID.Text = "Ship ID: " + currentShipId;
			lblEntryDeliveryID.Text = "Delivery ID: " + currentDeliveryId;
			lblEntryShipIP.Text = "Ship IP: " + currentShipIp;
			lblEntryResult.Text = "Entry Result: Pending operator validation";

			AddLog("ER message accepted.", "OK");
			AddLog("Ship ID detected: " + currentShipId);
			AddLog("Delivery ID detected: " + currentDeliveryId);
			AddLog("Ship IP detected: " + currentShipIp);

			btnValidateEntry.Enabled = true;

			AddLog("Validate Entry phase is now available.", "OK");
		}

		// =========================================================
		// VK HANDLING
		//
		// Format:
		// VK + encrypted validation code
		// =========================================================

		private void HandleVK(string message)
		{
			if (!vr1Sent)
			{
				AddLog("VK received before VR1 was sent. Ignored.", "ERROR");

				MessageBox.Show(
					"VK was received before VR1 was sent.\nThe protocol order is incorrect.",
					"VK error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (vkReceived)
			{
				AddLog("A VK message has already been received for this process.", "ERROR");

				MessageBox.Show(
					"A VK message has already been received.",
					"VK already received",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (message.Length <= 2)
			{
				AddLog("VK message does not contain encrypted data.", "ERROR");

				MessageBox.Show(
					"VK message does not contain encrypted validation data.",
					"VK error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}

			encryptedValidationCode = message.Substring(2);
			vkReceived = true;

			lblKeyStatus.Text = "VK Status: Received";
			lblEncryptedCode.Text = "Encrypted Code: " + encryptedValidationCode;
			lblDecryptedCode.Text = "Decrypted Code: ---";
			lblKeyResult.Text = "Key Result: Pending operator validation";

			AddLog("VK message received.", "RECV");
			AddLog("Encrypted validation code stored.");

			btnValidateKey.Enabled = true;

			AddLog("Validate Key phase is now available.", "OK");
		}

		// =========================================================
		// SHIP CHECKSUM HANDLING
		// =========================================================

		private void HandleShipChecksum(string message)
		{
			if (!zipSent)
			{
				AddLog("Ship checksum received before PACS.zip was sent. Ignored.", "ERROR");

				MessageBox.Show(
					"The spaceship checksum arrived before PACS.zip was sent.\nThe protocol order is incorrect.",
					"Checksum error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (shipChecksumReceived)
			{
				AddLog("A ship checksum has already been received for this process.", "ERROR");

				MessageBox.Show(
					"A ship checksum has already been received.",
					"Checksum already received",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (!int.TryParse(message, out shipChecksum))
			{
				AddLog("Invalid checksum format.", "ERROR");

				MessageBox.Show(
					"The received checksum is not a valid number.",
					"Checksum error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);

				return;
			}

			shipChecksumReceived = true;

			lblShipChecksum.Text = "Ship Checksum: " + shipChecksum;
			lblPlanetChecksumFinal.Text = "Planet Checksum: " + planetChecksum;
			lblComparisonResult.Text = "Comparison Result: Pending operator resolution";

			AddLog("Ship checksum received: " + shipChecksum, "RECV");

			btnAcces.Enabled = true;

			AddLog("Resolve Access phase is now available.", "OK");
		}

		// =========================================================
		// SIMULATION BUTTONS
		// These simulate messages that will later come from TCP/IP.
		// =========================================================

		private void btnSimulateER_Click(object sender, EventArgs e)
		{
			string fakeER = "ERNAVE00000001DELIVERY0001";
			OnMessageReceived(fakeER, "192.168.1.50");
		}

		private void btnSimulateVK_Click(object sender, EventArgs e)
		{
			string fakeVK = "VKENCRYPTED_VALIDATION_CODE";
			OnMessageReceived(fakeVK, "192.168.1.50");
		}

		private void btnSimulateChecksum_Click(object sender, EventArgs e)
		{
			string fakeChecksum = "45231";
			OnMessageReceived(fakeChecksum, "192.168.1.50");
		}

		// =========================================================
		// PANEL 1 ACTION:
		// VALIDATE ENTRY
		// =========================================================

		private void btnRunValidateEntry_Click(object sender, EventArgs e)
		{
			if (!erReceived)
			{
				MessageBox.Show(
					"Cannot validate entry because ER has not been received.",
					"Validate Entry error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (vr1Sent)
			{
				MessageBox.Show(
					"VR1 has already been sent for this process.",
					"Validate Entry unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			AddLog("Checking DeliveryData table...");
			AddLog("TEMP mode: DeliveryData validation is simulated.");

			entryValidated = ValidateDeliveryData(
				currentShipId,
				currentDeliveryId,
				currentShipIp
			);

			if (entryValidated)
			{
				lblEntryResult.Text = "Entry Result: ACCEPTED";
				AddLog("DeliveryData validation accepted.", "OK");

				SendVR(1, currentShipId, "VP");

				vr1Sent = true;

				AddLog("Waiting for VK message from spaceship.");
			}
			else
			{
				lblEntryResult.Text = "Entry Result: DENIED";
				AddLog("DeliveryData validation rejected.", "ERROR");

				SendVR(1, currentShipId, "AD");

				vr1Sent = true;

				AddLog("Process stopped.", "ERROR");
			}
		}

		private bool ValidateDeliveryData(string shipId, string deliveryId, string shipIp)
		{
			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later this must check DeliveryData:
			 * - Ship exists.
			 * - Delivery exists.
			 * - Ship is authorized.
			 * - Ship IP matches.
			 * - Delivery belongs to this planet.
			 */

			return true;
		}

		// =========================================================
		// PANEL 2 ACTION:
		// VALIDATE KEY
		// =========================================================

		private void btnRunValidateKey_Click(object sender, EventArgs e)
		{
			if (!vkReceived)
			{
				MessageBox.Show(
					"Cannot validate key because VK has not been received.",
					"Validate Key error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (vr2Sent)
			{
				MessageBox.Show(
					"VR2 has already been sent for this process.",
					"Validate Key unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			AddLog("Decrypting VK using planet private key...");
			AddLog("TEMP mode: RSA decryption is simulated.");

			decryptedValidationCode = DecryptValidationCode(encryptedValidationCode);

			lblDecryptedCode.Text = "Decrypted Code: " + decryptedValidationCode;

			AddLog("Decrypted validation code: " + decryptedValidationCode);
			AddLog("Checking InnerEncryption table...");

			keyValidated = ValidateInnerEncryptionCode(decryptedValidationCode);

			if (keyValidated)
			{
				lblKeyResult.Text = "Key Result: ACCEPTED";
				AddLog("Validation code accepted.", "OK");

				SendVR(2, currentShipId, "VP");

				vr2Sent = true;

				btnCalculate.Enabled = true;

				AddLog("Prepare Challenge phase is now available.", "OK");
			}
			else
			{
				lblKeyResult.Text = "Key Result: DENIED";
				AddLog("Validation code rejected.", "ERROR");

				SendVR(2, currentShipId, "AD");

				vr2Sent = true;

				AddLog("Process stopped.", "ERROR");
			}
		}

		private string DecryptValidationCode(string encryptedCode)
		{
			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later:
			 * - Load private key from KeyPlanet.
			 * - Decrypt encryptedCode using RSA.
			 */

			return "ABC123XYZ789";
		}

		private bool ValidateInnerEncryptionCode(string decryptedCode)
		{
			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later:
			 * - Read expected validation code from InnerEncryption.
			 */

			string expectedCode = "ABC123XYZ789";

			return decryptedCode == expectedCode;
		}

		// =========================================================
		// PANEL 3 ACTION:
		// PREPARE CHALLENGE
		// =========================================================

		private void btnRunCalculations_Click(object sender, EventArgs e)
		{
			if (!keyValidated)
			{
				MessageBox.Show(
					"Cannot prepare challenge because the validation key has not been accepted.",
					"Prepare Challenge error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (zipSent || planetChecksumCalculated)
			{
				MessageBox.Show(
					"The challenge has already been prepared for this process.",
					"Prepare Challenge unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			try
			{
				AddLog("Preparing PACS.zip challenge...");

				PacsZipService zipService = new PacsZipService();

				PacsZipService.PacsZipResult result =
					zipService.GeneratePacsZip(Application.StartupPath);

				lblXmlStatus.Text = "XML Config: Loaded";
				lblFilesStatus.Text = "Generated Files: " + result.GeneratedFiles;
				lblZipStatus.Text = "PACS.zip: Generated";

				AddLog("XML config loaded: " + result.ConfigPath, "OK");
				AddLog("Work folder: " + result.WorkFolder);
				AddLog("Generated files folder: " + result.FilesFolder);
				AddLog("Files generated: " + result.GeneratedFiles);
				AddLog("Letters per file: " + result.LettersPerFile);
				AddLog("PACS.zip created: " + result.ZipPath, "OK");
				AddLog("PACS.zip size: " + result.ZipSizeBytes + " bytes");

				zipGenerated = true;

				AddLog("Simulating PACS.zip transfer...", "SEND");
				AddLog("TCP/IP file transfer is not connected yet.");
				AddLog("PACS.zip marked as sent for protocol testing.", "OK");

				zipSent = true;
				lblZipStatus.Text = "PACS.zip: Simulated Sent";

				AddLog("Calculating planet checksum...");

				planetChecksum = CalculatePlanetChecksum();

				planetChecksumCalculated = true;

				lblPlanetChecksum.Text = "Planet Checksum: " + planetChecksum;
				lblPlanetChecksumFinal.Text = "Planet Checksum: " + planetChecksum;

				AddLog("Planet checksum calculated: " + planetChecksum, "OK");
				AddLog("Waiting for spaceship checksum.");
			}
			catch (Exception ex)
			{
				AddLog("PACS.zip generation error: " + ex.Message, "ERROR");

				MessageBox.Show(
					"PACS.zip generation failed:\n\n" + ex.Message,
					"PACS.zip error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
		}

		private int CalculatePlanetChecksum()
		{
			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later:
			 * - Read generated files.
			 * - Use InnerEncryptionData dictionary.
			 * - Use TPL/Parallel processing.
			 * - Sum digits.
			 * - 0 counts as 10.
			 */

			return 45231;
		}

		// =========================================================
		// PANEL 4 ACTION:
		// RESOLVE ACCESS
		// =========================================================

		private void btnRunResolveAccess_Click(object sender, EventArgs e)
		{
			if (!shipChecksumReceived)
			{
				MessageBox.Show(
					"Cannot resolve access because the spaceship checksum has not been received.",
					"Resolve Access error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (!planetChecksumCalculated)
			{
				MessageBox.Show(
					"Cannot resolve access because the planet checksum has not been calculated.",
					"Resolve Access error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			if (finalResolved)
			{
				MessageBox.Show(
					"Access has already been resolved for this process.",
					"Resolve Access unavailable",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			AddLog("Comparing checksums...");
			AddLog("Planet checksum: " + planetChecksum);
			AddLog("Ship checksum: " + shipChecksum);

			if (planetChecksum == shipChecksum)
			{
				lblComparisonResult.Text = "Comparison Result: MATCH";

				AddLog("Checksum comparison successful.", "OK");

				SendVR(3, currentShipId, "AG");

				OpenShield();
			}
			else
			{
				lblComparisonResult.Text = "Comparison Result: MISMATCH";

				AddLog("Checksum comparison failed.", "ERROR");

				SendVR(3, currentShipId, "AD");

				lblShieldStatus.Text = "Shield Status: CLOSED";
				AddLog("Shield remains closed.", "ERROR");
			}

			finalResolved = true;
		}

		// =========================================================
		// SEND VR MESSAGE
		// =========================================================

		private void SendVR(int number, string shipId, string result)
		{
			string message = $"VR{number}{shipId}{result}";

			AddLog("Generated message: " + message, "SEND");

			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later this must send the message through the TCP service:
			 * - VR1
			 * - VR2
			 * - VR3
			 */
		}

		// =========================================================
		// FINAL ACTION
		// =========================================================

		private void OpenShield()
		{
			lblShieldStatus.Text = "Shield Status: OPEN";
			AddLog("Opening planetary energy shield...");
			AddLog("Shield opened successfully.", "OK");
		}
	}
}