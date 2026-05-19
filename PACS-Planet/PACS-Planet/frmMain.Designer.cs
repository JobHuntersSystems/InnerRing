namespace PACS_Planet
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pacsMinimizeButton1 = new PACS_InheratedControls.PacsMinimizeButton();
            this.btnClose = new PACS_InheratedControls.PacsCloseButton();
            this.pctConfiguration = new System.Windows.Forms.PictureBox();
            this.lblSubStatus = new System.Windows.Forms.Label();
            this.flowMenuLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.obtnRsa = new PACS_CustomControls.OptionButton();
            this.obtnValidationCode = new PACS_CustomControls.OptionButton();
            this.obtnTCP = new PACS_CustomControls.OptionButton();
            this.obtnGenerateZip = new PACS_CustomControls.OptionButton();
            this.obtnCheckSum = new PACS_CustomControls.OptionButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pctBackground = new System.Windows.Forms.PictureBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pcsStageIndicator = new PACS_CustomControls.PacsStageIndicator();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.optionButton4 = new PACS_CustomControls.OptionButton();
            this.optionButton1 = new PACS_CustomControls.OptionButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfiguration)).BeginInit();
            this.flowMenuLeft.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).BeginInit();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Controls.Add(this.pacsMinimizeButton1);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.pctConfiguration);
            this.panelHeader.Controls.Add(this.lblSubStatus);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1367, 39);
            this.panelHeader.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 821);
            this.panel1.TabIndex = 6;
            // 
            // pacsMinimizeButton1
            // 
            this.pacsMinimizeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.pacsMinimizeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pacsMinimizeButton1.DefaultClickEvent = true;
            this.pacsMinimizeButton1.FlatAppearance.BorderSize = 0;
            this.pacsMinimizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacsMinimizeButton1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.pacsMinimizeButton1.Location = new System.Drawing.Point(9, 9);
            this.pacsMinimizeButton1.Name = "pacsMinimizeButton1";
            this.pacsMinimizeButton1.Size = new System.Drawing.Size(41, 22);
            this.pacsMinimizeButton1.TabIndex = 5;
            this.pacsMinimizeButton1.Text = "-";
            this.pacsMinimizeButton1.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DefaultClickEvent = false;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(60, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 22);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pctConfiguration
            // 
            this.pctConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.pctConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("pctConfiguration.Image")));
            this.pctConfiguration.Location = new System.Drawing.Point(1320, 0);
            this.pctConfiguration.Name = "pctConfiguration";
            this.pctConfiguration.Size = new System.Drawing.Size(41, 39);
            this.pctConfiguration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctConfiguration.TabIndex = 3;
            this.pctConfiguration.TabStop = false;
            this.pctConfiguration.Click += new System.EventHandler(this.pctConfiguration_Click);
            // 
            // lblSubStatus
            // 
            this.lblSubStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubStatus.AutoSize = true;
            this.lblSubStatus.Font = new System.Drawing.Font("Courier New", 8F);
            this.lblSubStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSubStatus.Location = new System.Drawing.Point(2367, 10);
            this.lblSubStatus.Name = "lblSubStatus";
            this.lblSubStatus.Size = new System.Drawing.Size(196, 14);
            this.lblSubStatus.TabIndex = 1;
            this.lblSubStatus.Text = "PLANETARY DEFENSE INTERFACE";
            // 
            // flowMenuLeft
            // 
            this.flowMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.flowMenuLeft.Controls.Add(this.obtnRsa);
            this.flowMenuLeft.Controls.Add(this.obtnValidationCode);
            this.flowMenuLeft.Controls.Add(this.obtnTCP);
            this.flowMenuLeft.Controls.Add(this.obtnGenerateZip);
            this.flowMenuLeft.Controls.Add(this.obtnCheckSum);
            this.flowMenuLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowMenuLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.flowMenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.flowMenuLeft.Name = "flowMenuLeft";
            this.flowMenuLeft.Padding = new System.Windows.Forms.Padding(4);
            this.flowMenuLeft.Size = new System.Drawing.Size(249, 717);
            this.flowMenuLeft.TabIndex = 2;
            // 
            // obtnRsa
            // 
            this.obtnRsa.AccentColor = System.Drawing.Color.Lavender;
            this.obtnRsa.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.obtnRsa.BackColor = System.Drawing.Color.Transparent;
            this.obtnRsa.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(22)))));
            this.obtnRsa.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnRsa.BorderLightColor = System.Drawing.Color.Gold;
            this.obtnRsa.ClassName = null;
            this.obtnRsa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnRsa.FormName = null;
            this.obtnRsa.IsSelected = false;
            this.obtnRsa.Location = new System.Drawing.Point(10, 10);
            this.obtnRsa.Margin = new System.Windows.Forms.Padding(6);
            this.obtnRsa.Name = "obtnRsa";
            this.obtnRsa.OptionIcon = ((System.Drawing.Image)(resources.GetObject("obtnRsa.OptionIcon")));
            this.obtnRsa.OptionText = "RSA Generation";
            this.obtnRsa.Size = new System.Drawing.Size(220, 62);
            this.obtnRsa.TabIndex = 4;
            this.obtnRsa.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(201)))), ((int)(((byte)(107)))));
            this.obtnRsa.Click += new System.EventHandler(this.obtnRsa_Click);
            // 
            // obtnValidationCode
            // 
            this.obtnValidationCode.AccentColor = System.Drawing.Color.Lavender;
            this.obtnValidationCode.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.obtnValidationCode.BackColor = System.Drawing.Color.Transparent;
            this.obtnValidationCode.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.obtnValidationCode.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnValidationCode.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(78)))), ((int)(((byte)(138)))));
            this.obtnValidationCode.ClassName = null;
            this.obtnValidationCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnValidationCode.FormName = null;
            this.obtnValidationCode.IsSelected = false;
            this.obtnValidationCode.Location = new System.Drawing.Point(10, 84);
            this.obtnValidationCode.Margin = new System.Windows.Forms.Padding(6);
            this.obtnValidationCode.Name = "obtnValidationCode";
            this.obtnValidationCode.OptionIcon = null;
            this.obtnValidationCode.OptionText = "Validation Code ⭐ ";
            this.obtnValidationCode.Size = new System.Drawing.Size(220, 62);
            this.obtnValidationCode.TabIndex = 3;
            this.obtnValidationCode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(174)))), ((int)(((byte)(249)))));
            this.obtnValidationCode.Click += new System.EventHandler(this.obtnValidationCode_Click);
            // 
            // obtnTCP
            // 
            this.obtnTCP.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(249)))), ((int)(((byte)(85)))));
            this.obtnTCP.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(251)))), ((int)(((byte)(185)))));
            this.obtnTCP.BackColor = System.Drawing.Color.Transparent;
            this.obtnTCP.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.obtnTCP.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnTCP.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.obtnTCP.ClassName = "";
            this.obtnTCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnTCP.FormName = "";
            this.obtnTCP.IsSelected = false;
            this.obtnTCP.Location = new System.Drawing.Point(10, 158);
            this.obtnTCP.Margin = new System.Windows.Forms.Padding(6);
            this.obtnTCP.Name = "obtnTCP";
            this.obtnTCP.OptionIcon = ((System.Drawing.Image)(resources.GetObject("obtnTCP.OptionIcon")));
            this.obtnTCP.OptionText = "TCP Server";
            this.obtnTCP.Size = new System.Drawing.Size(220, 62);
            this.obtnTCP.TabIndex = 0;
            this.obtnTCP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.obtnTCP.Click += new System.EventHandler(this.obtnTCP_Click);
            // 
            // obtnGenerateZip
            // 
            this.obtnGenerateZip.AccentColor = System.Drawing.Color.Lavender;
            this.obtnGenerateZip.AccentHoverColor = System.Drawing.Color.Red;
            this.obtnGenerateZip.BackColor = System.Drawing.Color.Transparent;
            this.obtnGenerateZip.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(47)))));
            this.obtnGenerateZip.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnGenerateZip.BorderLightColor = System.Drawing.Color.Maroon;
            this.obtnGenerateZip.ClassName = null;
            this.obtnGenerateZip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnGenerateZip.FormName = null;
            this.obtnGenerateZip.IsSelected = false;
            this.obtnGenerateZip.Location = new System.Drawing.Point(10, 232);
            this.obtnGenerateZip.Margin = new System.Windows.Forms.Padding(6);
            this.obtnGenerateZip.Name = "obtnGenerateZip";
            this.obtnGenerateZip.OptionIcon = null;
            this.obtnGenerateZip.OptionText = "Zip    Generation";
            this.obtnGenerateZip.Size = new System.Drawing.Size(220, 62);
            this.obtnGenerateZip.TabIndex = 5;
            this.obtnGenerateZip.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.obtnGenerateZip.Visible = false;
            this.obtnGenerateZip.Click += new System.EventHandler(this.obtnGenerateZip_Click);
            // 
            // obtnCheckSum
            // 
            this.obtnCheckSum.AccentColor = System.Drawing.Color.Fuchsia;
            this.obtnCheckSum.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.obtnCheckSum.BackColor = System.Drawing.Color.Transparent;
            this.obtnCheckSum.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.obtnCheckSum.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnCheckSum.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.obtnCheckSum.ClassName = "";
            this.obtnCheckSum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnCheckSum.FormName = "";
            this.obtnCheckSum.IsSelected = false;
            this.obtnCheckSum.Location = new System.Drawing.Point(10, 306);
            this.obtnCheckSum.Margin = new System.Windows.Forms.Padding(6);
            this.obtnCheckSum.Name = "obtnCheckSum";
            this.obtnCheckSum.OptionIcon = null;
            this.obtnCheckSum.OptionText = "Check Sum";
            this.obtnCheckSum.Size = new System.Drawing.Size(220, 62);
            this.obtnCheckSum.TabIndex = 6;
            this.obtnCheckSum.TextColor = System.Drawing.Color.Plum;
            this.obtnCheckSum.Visible = false;
            this.obtnCheckSum.Click += new System.EventHandler(this.obtnCheckSum_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Controls.Add(this.pctBackground);
            this.pnlLeft.Controls.Add(this.flowMenuLeft);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 39);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(249, 846);
            this.pnlLeft.TabIndex = 6;
            // 
            // pctBackground
            // 
            this.pctBackground.BackColor = System.Drawing.Color.Transparent;
            this.pctBackground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pctBackground.Image = ((System.Drawing.Image)(resources.GetObject("pctBackground.Image")));
            this.pctBackground.Location = new System.Drawing.Point(0, 646);
            this.pctBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pctBackground.Name = "pctBackground";
            this.pctBackground.Size = new System.Drawing.Size(249, 200);
            this.pctBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBackground.TabIndex = 5;
            this.pctBackground.TabStop = false;
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.pnlButton.Controls.Add(this.pcsStageIndicator);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.pnlButton.Location = new System.Drawing.Point(249, 685);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1118, 200);
            this.pnlButton.TabIndex = 7;
            // 
            // pcsStageIndicator
            // 
            this.pcsStageIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.pcsStageIndicator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcsStageIndicator.Location = new System.Drawing.Point(0, 0);
            this.pcsStageIndicator.Name = "pcsStageIndicator";
            this.pcsStageIndicator.Size = new System.Drawing.Size(1118, 200);
            this.pcsStageIndicator.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(249, 39);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1118, 646);
            this.pnlMain.TabIndex = 8;
            // 
            // optionButton4
            // 
            this.optionButton4.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.optionButton4.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.optionButton4.BackColor = System.Drawing.Color.Transparent;
            this.optionButton4.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.optionButton4.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.optionButton4.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.optionButton4.ClassName = null;
            this.optionButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionButton4.FormName = null;
            this.optionButton4.IsSelected = false;
            this.optionButton4.Location = new System.Drawing.Point(16, 90);
            this.optionButton4.Margin = new System.Windows.Forms.Padding(6);
            this.optionButton4.Name = "optionButton4";
            this.optionButton4.OptionIcon = null;
            this.optionButton4.OptionText = "PLACE HOLDER";
            this.optionButton4.Size = new System.Drawing.Size(220, 62);
            this.optionButton4.TabIndex = 1;
            this.optionButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // optionButton1
            // 
            this.optionButton1.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.optionButton1.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.optionButton1.BackColor = System.Drawing.Color.Transparent;
            this.optionButton1.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.optionButton1.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.optionButton1.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.optionButton1.ClassName = null;
            this.optionButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionButton1.FormName = null;
            this.optionButton1.IsSelected = false;
            this.optionButton1.Location = new System.Drawing.Point(16, 164);
            this.optionButton1.Margin = new System.Windows.Forms.Padding(6);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.OptionIcon = null;
            this.optionButton1.OptionText = "PLACE HOLDER";
            this.optionButton1.Size = new System.Drawing.Size(220, 62);
            this.optionButton1.TabIndex = 2;
            this.optionButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1367, 885);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "PACS Planet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctConfiguration)).EndInit();
            this.flowMenuLeft.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctBackground)).EndInit();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelHeader;

        private System.Windows.Forms.FlowLayoutPanel flowMenuLeft;
        private PACS_CustomControls.OptionButton optionButton4;
        private PACS_CustomControls.OptionButton optionButton1;
        private PACS_CustomControls.OptionButton obtnValidationCode;
        private System.Windows.Forms.Label lblSubStatus;
        private PACS_CustomControls.OptionButton obtnTCP;
        private PACS_CustomControls.OptionButton obtnRsa;
        private System.Windows.Forms.PictureBox pctConfiguration;
        private PACS_InheratedControls.PacsCloseButton btnClose;
        private PACS_InheratedControls.PacsMinimizeButton pacsMinimizeButton1;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctBackground;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlMain;
        private PACS_CustomControls.OptionButton obtnGenerateZip;
        private PACS_CustomControls.OptionButton obtnCheckSum;
        private PACS_CustomControls.PacsStageIndicator pcsStageIndicator;
    }
}