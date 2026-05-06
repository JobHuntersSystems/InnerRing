using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public void OnMessageReceived(string message, string remoteIp)
		{
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

		private void HandleER(string message, string remoteIp)
		{
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

		private bool ValidateDeliveryData(string shipId, string deliveryId, string shipIp)
		{
			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later this must check the DeliveryData table:
			 * - Ship exists.
			 * - Delivery exists.
			 * - Ship is authorized.
			 * - Ship IP matches.
			 * - Delivery belongs to this planet.
			 */

			return true;
		}

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

		private void SendVR(int number, string shipId, string result)
		{
			string message = $"VR{number}{shipId}{result}";

			AddLog("Generated message: " + message, "SEND");

			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later:
			 * - Send through TCP/IP.
			 */
		}

		private void OpenShield()
		{
			lblShieldStatus.Text = "Shield Status: OPEN";
			AddLog("Opening planetary energy shield...");
			AddLog("Shield opened successfully.", "OK");
		}

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

			AddLog("Reading XML configuration...");
			lblXmlStatus.Text = "XML Config: Loaded";

			AddLog("Generating PACS files...");
			lblFilesStatus.Text = "Generated Files: OK";

			AddLog("Creating PACS.zip...");
			zipGenerated = true;
			lblZipStatus.Text = "PACS.zip: Generated";

			AddLog("Sending PACS.zip...", "SEND");

			if (!zipGenerated)
			{
				MessageBox.Show(
					"Cannot send PACS.zip because it has not been generated.",
					"ZIP error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning
				);

				return;
			}

			/*
			 * TEMPORARY PLACEHOLDER.
			 *
			 * Later:
			 * - Send the real PACS.zip using TCP/IP.
			 */

			zipSent = true;
			lblZipStatus.Text = "PACS.zip: Sent";

			AddLog("PACS.zip sent successfully.", "OK");

			AddLog("Calculating planet checksum...");
			planetChecksum = CalculatePlanetChecksum();

			planetChecksumCalculated = true;

			lblPlanetChecksum.Text = "Planet Checksum: " + planetChecksum;
			lblPlanetChecksumFinal.Text = "Planet Checksum: " + planetChecksum;

			AddLog("Planet checksum calculated: " + planetChecksum, "OK");
			AddLog("Waiting for spaceship checksum.");
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
	}
}
