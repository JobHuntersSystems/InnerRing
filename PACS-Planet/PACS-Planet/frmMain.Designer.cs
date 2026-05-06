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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSubStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowMenuLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLogTitle = new System.Windows.Forms.Label();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.obtnTCP = new PACS_CustomControls.OptionButton();
            this.btnKey = new PACS_CustomControls.OptionButton();
            this.btnCode = new PACS_CustomControls.OptionButton();
            this.optionButton2 = new PACS_CustomControls.OptionButton();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flowMenuLeft.SuspendLayout();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.lblSubStatus);
            this.panelHeader.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.panelHeader, "panelHeader");
            this.panelHeader.Name = "panelHeader";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.picLogo, "picLogo");
            this.picLogo.Name = "picLogo";
            this.picLogo.TabStop = false;
            // 
            // lblSubStatus
            // 
            resources.ApplyResources(this.lblSubStatus, "lblSubStatus");
            this.lblSubStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSubStatus.Name = "lblSubStatus";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lblTitle.Name = "lblTitle";
            // 
            // flowMenuLeft
            // 
            resources.ApplyResources(this.flowMenuLeft, "flowMenuLeft");
            this.flowMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(16)))));
            this.flowMenuLeft.Controls.Add(this.obtnTCP);
            this.flowMenuLeft.Controls.Add(this.btnKey);
            this.flowMenuLeft.Controls.Add(this.btnCode);
            this.flowMenuLeft.Controls.Add(this.optionButton2);
            this.flowMenuLeft.Name = "flowMenuLeft";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // lblLogTitle
            // 
            resources.ApplyResources(this.lblLogTitle, "lblLogTitle");
            this.lblLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblLogTitle.Name = "lblLogTitle";
            // 
            // rtbLogs
            // 
            this.rtbLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(8)))));
            this.rtbLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtbLogs, "rtbLogs");
            this.rtbLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.panelLog.Controls.Add(this.rtbLogs);
            this.panelLog.Controls.Add(this.lblLogTitle);
            resources.ApplyResources(this.panelLog, "panelLog");
            this.panelLog.Name = "panelLog";
            // 
            // obtnTCP
            // 
            this.obtnTCP.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.obtnTCP.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.obtnTCP.BackColor = System.Drawing.Color.Transparent;
            this.obtnTCP.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.obtnTCP.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnTCP.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.obtnTCP.ClassName = "TcpServer.dll";
            this.obtnTCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnTCP.FormName = "TcpServer.frmTcpServerDashboard";
            this.obtnTCP.IsSelected = false;
            resources.ApplyResources(this.obtnTCP, "obtnTCP");
            this.obtnTCP.Name = "obtnTCP";
            this.obtnTCP.OptionIcon = null;
            this.obtnTCP.OptionText = "TCP Server";
            this.obtnTCP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // btnKey
            // 
            this.btnKey.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.btnKey.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnKey.BackColor = System.Drawing.Color.Transparent;
            this.btnKey.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnKey.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnKey.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.btnKey.ClassName = "PACS-Center.dll";
            this.btnKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKey.FormName = "PACS_Center.frmKeyManager";
            this.btnKey.IsSelected = false;
            resources.ApplyResources(this.btnKey, "btnKey");
            this.btnKey.Name = "btnKey";
            this.btnKey.OptionIcon = null;
            this.btnKey.OptionText = "Key Generator";
            this.btnKey.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // btnCode
            // 
            this.btnCode.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.btnCode.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCode.BackColor = System.Drawing.Color.Transparent;
            this.btnCode.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnCode.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCode.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.btnCode.ClassName = "PACS_Center.dll";
            this.btnCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCode.FormName = "PACS_Center.frmInnerEncryption";
            this.btnCode.IsSelected = false;
            resources.ApplyResources(this.btnCode, "btnCode");
            this.btnCode.Name = "btnCode";
            this.btnCode.OptionIcon = null;
            this.btnCode.OptionText = "Inner Encryption";
            this.btnCode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // optionButton2
            // 
            this.optionButton2.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.optionButton2.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.optionButton2.BackColor = System.Drawing.Color.Transparent;
            this.optionButton2.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.optionButton2.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.optionButton2.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.optionButton2.ClassName = null;
            this.optionButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionButton2.FormName = null;
            this.optionButton2.IsSelected = false;
            resources.ApplyResources(this.optionButton2, "optionButton2");
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.OptionIcon = null;
            this.optionButton2.OptionText = "SECURITY\nSETUP";
            this.optionButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flowMenuLeft);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flowMenuLeft.ResumeLayout(false);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.FlowLayoutPanel flowMenuLeft;

        private System.Windows.Forms.Panel pnlMain;
        private PACS_CustomControls.OptionButton obtnTCP;
        private PACS_CustomControls.OptionButton btnKey;
        private PACS_CustomControls.OptionButton btnCode;
        private PACS_CustomControls.OptionButton optionButton2;
        private System.Windows.Forms.Label lblSubStatus;
        private System.Windows.Forms.Label lblLogTitle;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.Panel panelLog;
    }
}