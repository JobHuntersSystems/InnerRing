
namespace PACS_Planet
{
	partial class FrmPlanetValidation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LstProtocolLogs = new System.Windows.Forms.ListBox();
			this.btnValidateEntry = new System.Windows.Forms.Button();
			this.btnValidateKey = new System.Windows.Forms.Button();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnAcces = new System.Windows.Forms.Button();
			this.pnlStartProcess = new System.Windows.Forms.Panel();
			this.pnlResolveAccess = new System.Windows.Forms.Panel();
			this.btnRunResolveAccess = new System.Windows.Forms.Button();
			this.lblShieldStatus = new System.Windows.Forms.Label();
			this.lblComparisonResult = new System.Windows.Forms.Label();
			this.lblPlanetChecksumFinal = new System.Windows.Forms.Label();
			this.lblShipChecksum = new System.Windows.Forms.Label();
			this.btnRunValidateEntry = new System.Windows.Forms.Button();
			this.lblEntryResult = new System.Windows.Forms.Label();
			this.lblEntryShipIP = new System.Windows.Forms.Label();
			this.lblEntryDeliveryID = new System.Windows.Forms.Label();
			this.lblEntryShipID = new System.Windows.Forms.Label();
			this.pnlCalculations = new System.Windows.Forms.Panel();
			this.btnRunCalculations = new System.Windows.Forms.Button();
			this.lblPlanetChecksum = new System.Windows.Forms.Label();
			this.lblFilesStatus = new System.Windows.Forms.Label();
			this.lblXmlStatus = new System.Windows.Forms.Label();
			this.lblZipStatus = new System.Windows.Forms.Label();
			this.pnlValidateKey = new System.Windows.Forms.Panel();
			this.btnRunValidateKey = new System.Windows.Forms.Button();
			this.lblKeyResult = new System.Windows.Forms.Label();
			this.lblDecryptedCode = new System.Windows.Forms.Label();
			this.lblEncryptedCode = new System.Windows.Forms.Label();
			this.lblKeyStatus = new System.Windows.Forms.Label();
			this.btnSimulateER = new System.Windows.Forms.Button();
			this.btnSimulateVK = new System.Windows.Forms.Button();
			this.btnSimulateChecksum = new System.Windows.Forms.Button();
			this.pnlStartProcess.SuspendLayout();
			this.pnlResolveAccess.SuspendLayout();
			this.pnlCalculations.SuspendLayout();
			this.pnlValidateKey.SuspendLayout();
			this.SuspendLayout();
			// 
			// LstProtocolLogs
			// 
			this.LstProtocolLogs.FormattingEnabled = true;
			this.LstProtocolLogs.ItemHeight = 16;
			this.LstProtocolLogs.Location = new System.Drawing.Point(538, 13);
			this.LstProtocolLogs.Name = "LstProtocolLogs";
			this.LstProtocolLogs.Size = new System.Drawing.Size(257, 436);
			this.LstProtocolLogs.TabIndex = 0;
			// 
			// btnValidateEntry
			// 
			this.btnValidateEntry.Enabled = false;
			this.btnValidateEntry.Location = new System.Drawing.Point(3, 97);
			this.btnValidateEntry.Name = "btnValidateEntry";
			this.btnValidateEntry.Size = new System.Drawing.Size(78, 70);
			this.btnValidateEntry.TabIndex = 1;
			this.btnValidateEntry.Text = "Start Process";
			this.btnValidateEntry.UseVisualStyleBackColor = true;
			this.btnValidateEntry.Click += new System.EventHandler(this.btnValidateEntry_Click);
			// 
			// btnValidateKey
			// 
			this.btnValidateKey.Enabled = false;
			this.btnValidateKey.Location = new System.Drawing.Point(3, 162);
			this.btnValidateKey.Name = "btnValidateKey";
			this.btnValidateKey.Size = new System.Drawing.Size(78, 65);
			this.btnValidateKey.TabIndex = 2;
			this.btnValidateKey.Text = "Validate Key";
			this.btnValidateKey.UseVisualStyleBackColor = true;
			this.btnValidateKey.Click += new System.EventHandler(this.btnValidateKey_Click);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(3, 223);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(78, 64);
			this.btnCalculate.TabIndex = 3;
			this.btnCalculate.Text = "Calculations";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnAcces
			// 
			this.btnAcces.Location = new System.Drawing.Point(3, 286);
			this.btnAcces.Name = "btnAcces";
			this.btnAcces.Size = new System.Drawing.Size(78, 69);
			this.btnAcces.TabIndex = 4;
			this.btnAcces.Text = "Access";
			this.btnAcces.UseVisualStyleBackColor = true;
			this.btnAcces.Click += new System.EventHandler(this.btnAcces_Click);
			// 
			// pnlStartProcess
			// 
			this.pnlStartProcess.Controls.Add(this.btnRunValidateEntry);
			this.pnlStartProcess.Controls.Add(this.lblEntryResult);
			this.pnlStartProcess.Controls.Add(this.lblEntryShipIP);
			this.pnlStartProcess.Controls.Add(this.lblEntryDeliveryID);
			this.pnlStartProcess.Controls.Add(this.lblEntryShipID);
			this.pnlStartProcess.Location = new System.Drawing.Point(99, 97);
			this.pnlStartProcess.Name = "pnlStartProcess";
			this.pnlStartProcess.Size = new System.Drawing.Size(433, 249);
			this.pnlStartProcess.TabIndex = 5;
			this.pnlStartProcess.Visible = false;
			// 
			// pnlResolveAccess
			// 
			this.pnlResolveAccess.Controls.Add(this.btnRunResolveAccess);
			this.pnlResolveAccess.Controls.Add(this.lblShieldStatus);
			this.pnlResolveAccess.Controls.Add(this.lblComparisonResult);
			this.pnlResolveAccess.Controls.Add(this.lblPlanetChecksumFinal);
			this.pnlResolveAccess.Controls.Add(this.lblShipChecksum);
			this.pnlResolveAccess.Location = new System.Drawing.Point(0, 0);
			this.pnlResolveAccess.Name = "pnlResolveAccess";
			this.pnlResolveAccess.Size = new System.Drawing.Size(430, 249);
			this.pnlResolveAccess.TabIndex = 8;
			this.pnlResolveAccess.Visible = false;
			// 
			// btnRunResolveAccess
			// 
			this.btnRunResolveAccess.Location = new System.Drawing.Point(154, 115);
			this.btnRunResolveAccess.Name = "btnRunResolveAccess";
			this.btnRunResolveAccess.Size = new System.Drawing.Size(263, 23);
			this.btnRunResolveAccess.TabIndex = 4;
			this.btnRunResolveAccess.Text = "COMPARE AND RESOLVE ACCESS";
			this.btnRunResolveAccess.UseVisualStyleBackColor = true;
			this.btnRunResolveAccess.Click += new System.EventHandler(this.btnRunResolveAccess_Click);
			// 
			// lblShieldStatus
			// 
			this.lblShieldStatus.AutoSize = true;
			this.lblShieldStatus.Location = new System.Drawing.Point(27, 212);
			this.lblShieldStatus.Name = "lblShieldStatus";
			this.lblShieldStatus.Size = new System.Drawing.Size(155, 17);
			this.lblShieldStatus.TabIndex = 3;
			this.lblShieldStatus.Text = "Shield Status: CLOSED";
			// 
			// lblComparisonResult
			// 
			this.lblComparisonResult.AutoSize = true;
			this.lblComparisonResult.Location = new System.Drawing.Point(27, 149);
			this.lblComparisonResult.Name = "lblComparisonResult";
			this.lblComparisonResult.Size = new System.Drawing.Size(150, 17);
			this.lblComparisonResult.TabIndex = 2;
			this.lblComparisonResult.Text = "Comparison Result: ---";
			// 
			// lblPlanetChecksumFinal
			// 
			this.lblPlanetChecksumFinal.AutoSize = true;
			this.lblPlanetChecksumFinal.Location = new System.Drawing.Point(27, 88);
			this.lblPlanetChecksumFinal.Name = "lblPlanetChecksumFinal";
			this.lblPlanetChecksumFinal.Size = new System.Drawing.Size(140, 17);
			this.lblPlanetChecksumFinal.TabIndex = 1;
			this.lblPlanetChecksumFinal.Text = "Planet Checksum: ---";
			// 
			// lblShipChecksum
			// 
			this.lblShipChecksum.AutoSize = true;
			this.lblShipChecksum.Location = new System.Drawing.Point(27, 19);
			this.lblShipChecksum.Name = "lblShipChecksum";
			this.lblShipChecksum.Size = new System.Drawing.Size(128, 17);
			this.lblShipChecksum.TabIndex = 0;
			this.lblShipChecksum.Text = "Ship Checksum: ---";
			// 
			// btnRunValidateEntry
			// 
			this.btnRunValidateEntry.Location = new System.Drawing.Point(157, 115);
			this.btnRunValidateEntry.Name = "btnRunValidateEntry";
			this.btnRunValidateEntry.Size = new System.Drawing.Size(263, 23);
			this.btnRunValidateEntry.TabIndex = 4;
			this.btnRunValidateEntry.Text = "VALIDATE DELIVERY AND SEND VR1";
			this.btnRunValidateEntry.UseVisualStyleBackColor = true;
			this.btnRunValidateEntry.Click += new System.EventHandler(this.btnRunValidateEntry_Click);
			// 
			// lblEntryResult
			// 
			this.lblEntryResult.AutoSize = true;
			this.lblEntryResult.Location = new System.Drawing.Point(30, 212);
			this.lblEntryResult.Name = "lblEntryResult";
			this.lblEntryResult.Size = new System.Drawing.Size(108, 17);
			this.lblEntryResult.TabIndex = 3;
			this.lblEntryResult.Text = "Entry Result: ---";
			// 
			// lblEntryShipIP
			// 
			this.lblEntryShipIP.AutoSize = true;
			this.lblEntryShipIP.Location = new System.Drawing.Point(30, 149);
			this.lblEntryShipIP.Name = "lblEntryShipIP";
			this.lblEntryShipIP.Size = new System.Drawing.Size(75, 17);
			this.lblEntryShipIP.TabIndex = 2;
			this.lblEntryShipIP.Text = "Ship IP: ---";
			// 
			// lblEntryDeliveryID
			// 
			this.lblEntryDeliveryID.AutoSize = true;
			this.lblEntryDeliveryID.Location = new System.Drawing.Point(30, 88);
			this.lblEntryDeliveryID.Name = "lblEntryDeliveryID";
			this.lblEntryDeliveryID.Size = new System.Drawing.Size(99, 17);
			this.lblEntryDeliveryID.TabIndex = 1;
			this.lblEntryDeliveryID.Text = "Delivery ID: ---";
			// 
			// lblEntryShipID
			// 
			this.lblEntryShipID.AutoSize = true;
			this.lblEntryShipID.Location = new System.Drawing.Point(30, 23);
			this.lblEntryShipID.Name = "lblEntryShipID";
			this.lblEntryShipID.Size = new System.Drawing.Size(76, 17);
			this.lblEntryShipID.TabIndex = 0;
			this.lblEntryShipID.Text = "Ship ID: ---";
			// 
			// pnlCalculations
			// 
			this.pnlCalculations.Controls.Add(this.btnRunCalculations);
			this.pnlCalculations.Controls.Add(this.lblPlanetChecksum);
			this.pnlCalculations.Controls.Add(this.lblFilesStatus);
			this.pnlCalculations.Controls.Add(this.lblZipStatus);
			this.pnlCalculations.Controls.Add(this.lblXmlStatus);
			this.pnlCalculations.Location = new System.Drawing.Point(0, 0);
			this.pnlCalculations.Name = "pnlCalculations";
			this.pnlCalculations.Size = new System.Drawing.Size(430, 249);
			this.pnlCalculations.TabIndex = 7;
			this.pnlCalculations.Visible = false;
			// 
			// btnRunCalculations
			// 
			this.btnRunCalculations.Location = new System.Drawing.Point(154, 118);
			this.btnRunCalculations.Name = "btnRunCalculations";
			this.btnRunCalculations.Size = new System.Drawing.Size(263, 23);
			this.btnRunCalculations.TabIndex = 4;
			this.btnRunCalculations.Text = "GENERATE ZIP AND CALCULATE CHECKSUM";
			this.btnRunCalculations.UseVisualStyleBackColor = true;
			this.btnRunCalculations.Click += new System.EventHandler(this.btnRunCalculations_Click);
			// 
			// lblPlanetChecksum
			// 
			this.lblPlanetChecksum.AutoSize = true;
			this.lblPlanetChecksum.Location = new System.Drawing.Point(27, 212);
			this.lblPlanetChecksum.Name = "lblPlanetChecksum";
			this.lblPlanetChecksum.Size = new System.Drawing.Size(140, 17);
			this.lblPlanetChecksum.TabIndex = 3;
			this.lblPlanetChecksum.Text = "Planet Checksum: ---";
			// 
			// lblFilesStatus
			// 
			this.lblFilesStatus.AutoSize = true;
			this.lblFilesStatus.Location = new System.Drawing.Point(27, 88);
			this.lblFilesStatus.Name = "lblFilesStatus";
			this.lblFilesStatus.Size = new System.Drawing.Size(132, 17);
			this.lblFilesStatus.TabIndex = 1;
			this.lblFilesStatus.Text = "Generated Files: ---";
			// 
			// lblXmlStatus
			// 
			this.lblXmlStatus.AutoSize = true;
			this.lblXmlStatus.Location = new System.Drawing.Point(27, 19);
			this.lblXmlStatus.Name = "lblXmlStatus";
			this.lblXmlStatus.Size = new System.Drawing.Size(103, 17);
			this.lblXmlStatus.TabIndex = 0;
			this.lblXmlStatus.Text = "XML Config: ---";
			// 
			// lblZipStatus
			// 
			this.lblZipStatus.AutoSize = true;
			this.lblZipStatus.Location = new System.Drawing.Point(27, 151);
			this.lblZipStatus.Name = "lblZipStatus";
			this.lblZipStatus.Size = new System.Drawing.Size(89, 17);
			this.lblZipStatus.TabIndex = 2;
			this.lblZipStatus.Text = "PACS.zip: ---";
			// 
			// pnlValidateKey
			// 
			this.pnlValidateKey.Controls.Add(this.btnRunValidateKey);
			this.pnlValidateKey.Controls.Add(this.lblKeyResult);
			this.pnlValidateKey.Controls.Add(this.lblDecryptedCode);
			this.pnlValidateKey.Controls.Add(this.lblEncryptedCode);
			this.pnlValidateKey.Controls.Add(this.lblKeyStatus);
			this.pnlValidateKey.Location = new System.Drawing.Point(102, 94);
			this.pnlValidateKey.Name = "pnlValidateKey";
			this.pnlValidateKey.Size = new System.Drawing.Size(430, 249);
			this.pnlValidateKey.TabIndex = 6;
			this.pnlValidateKey.Visible = false;
			// 
			// btnRunValidateKey
			// 
			this.btnRunValidateKey.Location = new System.Drawing.Point(191, 115);
			this.btnRunValidateKey.Name = "btnRunValidateKey";
			this.btnRunValidateKey.Size = new System.Drawing.Size(226, 23);
			this.btnRunValidateKey.TabIndex = 4;
			this.btnRunValidateKey.Text = "DECRYPT KEY AND SEND VR2";
			this.btnRunValidateKey.UseVisualStyleBackColor = true;
			this.btnRunValidateKey.Click += new System.EventHandler(this.btnRunValidateKey_Click);
			// 
			// lblKeyResult
			// 
			this.lblKeyResult.AutoSize = true;
			this.lblKeyResult.Location = new System.Drawing.Point(27, 212);
			this.lblKeyResult.Name = "lblKeyResult";
			this.lblKeyResult.Size = new System.Drawing.Size(99, 17);
			this.lblKeyResult.TabIndex = 3;
			this.lblKeyResult.Text = "Key Result: ---";
			// 
			// lblDecryptedCode
			// 
			this.lblDecryptedCode.AutoSize = true;
			this.lblDecryptedCode.Location = new System.Drawing.Point(27, 149);
			this.lblDecryptedCode.Name = "lblDecryptedCode";
			this.lblDecryptedCode.Size = new System.Drawing.Size(133, 17);
			this.lblDecryptedCode.TabIndex = 2;
			this.lblDecryptedCode.Text = "Decrypted Code: ---";
			// 
			// lblEncryptedCode
			// 
			this.lblEncryptedCode.AutoSize = true;
			this.lblEncryptedCode.Location = new System.Drawing.Point(27, 88);
			this.lblEncryptedCode.Name = "lblEncryptedCode";
			this.lblEncryptedCode.Size = new System.Drawing.Size(132, 17);
			this.lblEncryptedCode.TabIndex = 1;
			this.lblEncryptedCode.Text = "Encrypted Code: ---";
			// 
			// lblKeyStatus
			// 
			this.lblKeyStatus.AutoSize = true;
			this.lblKeyStatus.Location = new System.Drawing.Point(27, 19);
			this.lblKeyStatus.Name = "lblKeyStatus";
			this.lblKeyStatus.Size = new System.Drawing.Size(93, 17);
			this.lblKeyStatus.TabIndex = 0;
			this.lblKeyStatus.Text = "VK Status: ---";
			// 
			// btnSimulateER
			// 
			this.btnSimulateER.Location = new System.Drawing.Point(68, 13);
			this.btnSimulateER.Name = "btnSimulateER";
			this.btnSimulateER.Size = new System.Drawing.Size(119, 23);
			this.btnSimulateER.TabIndex = 7;
			this.btnSimulateER.Text = "SIMULATE ER";
			this.btnSimulateER.UseVisualStyleBackColor = true;
			this.btnSimulateER.Click += new System.EventHandler(this.btnSimulateER_Click);
			// 
			// btnSimulateVK
			// 
			this.btnSimulateVK.Location = new System.Drawing.Point(210, 13);
			this.btnSimulateVK.Name = "btnSimulateVK";
			this.btnSimulateVK.Size = new System.Drawing.Size(112, 23);
			this.btnSimulateVK.TabIndex = 8;
			this.btnSimulateVK.Text = "SIMULATE VK";
			this.btnSimulateVK.UseVisualStyleBackColor = true;
			this.btnSimulateVK.Click += new System.EventHandler(this.btnSimulateVK_Click);
			// 
			// btnSimulateChecksum
			// 
			this.btnSimulateChecksum.Location = new System.Drawing.Point(343, 13);
			this.btnSimulateChecksum.Name = "btnSimulateChecksum";
			this.btnSimulateChecksum.Size = new System.Drawing.Size(171, 23);
			this.btnSimulateChecksum.TabIndex = 9;
			this.btnSimulateChecksum.Text = "SIMULATE CHECKSUM";
			this.btnSimulateChecksum.UseVisualStyleBackColor = true;
			this.btnSimulateChecksum.Click += new System.EventHandler(this.btnSimulateChecksum_Click);
			// 
			// FrmPlanetValidation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pnlStartProcess);
			this.Controls.Add(this.pnlValidateKey);
			this.Controls.Add(this.pnlCalculations);
			this.Controls.Add(this.pnlResolveAccess);
			this.Controls.Add(this.btnSimulateChecksum);
			this.Controls.Add(this.btnSimulateVK);
			this.Controls.Add(this.btnSimulateER);
			this.Controls.Add(this.btnAcces);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.btnValidateKey);
			this.Controls.Add(this.btnValidateEntry);
			this.Controls.Add(this.LstProtocolLogs);
			this.Name = "FrmPlanetValidation";
			this.Text = "FrmPlanetValidation";
			this.pnlStartProcess.ResumeLayout(false);
			this.pnlStartProcess.PerformLayout();
			this.pnlResolveAccess.ResumeLayout(false);
			this.pnlResolveAccess.PerformLayout();
			this.pnlCalculations.ResumeLayout(false);
			this.pnlCalculations.PerformLayout();
			this.pnlValidateKey.ResumeLayout(false);
			this.pnlValidateKey.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox LstProtocolLogs;
		private System.Windows.Forms.Button btnValidateEntry;
		private System.Windows.Forms.Button btnValidateKey;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnAcces;
		private System.Windows.Forms.Panel pnlStartProcess;
		private System.Windows.Forms.Button btnRunValidateEntry;
		private System.Windows.Forms.Label lblEntryResult;
		private System.Windows.Forms.Label lblEntryShipIP;
		private System.Windows.Forms.Label lblEntryDeliveryID;
		private System.Windows.Forms.Label lblEntryShipID;
		private System.Windows.Forms.Panel pnlCalculations;
		private System.Windows.Forms.Panel pnlResolveAccess;
		private System.Windows.Forms.Button btnRunResolveAccess;
		private System.Windows.Forms.Label lblShieldStatus;
		private System.Windows.Forms.Label lblComparisonResult;
		private System.Windows.Forms.Label lblPlanetChecksumFinal;
		private System.Windows.Forms.Label lblShipChecksum;
		private System.Windows.Forms.Button btnRunCalculations;
		private System.Windows.Forms.Label lblPlanetChecksum;
		private System.Windows.Forms.Label lblZipStatus;
		private System.Windows.Forms.Label lblFilesStatus;
		private System.Windows.Forms.Label lblXmlStatus;
		private System.Windows.Forms.Panel pnlValidateKey;
		private System.Windows.Forms.Button btnRunValidateKey;
		private System.Windows.Forms.Label lblKeyResult;
		private System.Windows.Forms.Label lblDecryptedCode;
		private System.Windows.Forms.Label lblEncryptedCode;
		private System.Windows.Forms.Label lblKeyStatus;
		private System.Windows.Forms.Button btnSimulateER;
		private System.Windows.Forms.Button btnSimulateVK;
		private System.Windows.Forms.Button btnSimulateChecksum;
	}
}