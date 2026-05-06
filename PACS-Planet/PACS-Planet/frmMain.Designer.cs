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
            this.obtnTCP = new PACS_CustomControls.OptionButton();
            this.optionButton4 = new PACS_CustomControls.OptionButton();
            this.optionButton1 = new PACS_CustomControls.OptionButton();
            this.optionButton2 = new PACS_CustomControls.OptionButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelLog = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flowMenuLeft.SuspendLayout();
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
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
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
            this.flowMenuLeft.Controls.Add(this.optionButton4);
            this.flowMenuLeft.Controls.Add(this.optionButton1);
            this.flowMenuLeft.Controls.Add(this.optionButton2);
            this.flowMenuLeft.Name = "flowMenuLeft";
            // 
            // obtnTCP
            // 
            this.obtnTCP.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.obtnTCP.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.obtnTCP.BackColor = System.Drawing.Color.Transparent;
            this.obtnTCP.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.obtnTCP.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnTCP.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.obtnTCP.ClassName = "TcpDashboard.dll";
            this.obtnTCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnTCP.FormName = "TcpDashboard.frmTcpDashboard";
            this.obtnTCP.IsSelected = false;
            resources.ApplyResources(this.obtnTCP, "obtnTCP");
            this.obtnTCP.Name = "obtnTCP";
            this.obtnTCP.OptionIcon = null;
            this.obtnTCP.OptionText = "TCP Server";
            this.obtnTCP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
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
            resources.ApplyResources(this.optionButton4, "optionButton4");
            this.optionButton4.Name = "optionButton4";
            this.optionButton4.OptionIcon = null;
            this.optionButton4.OptionText = "SECURITY\nSETUP";
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
            resources.ApplyResources(this.optionButton1, "optionButton1");
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.OptionIcon = null;
            this.optionButton1.OptionText = "SECURITY\nSETUP";
            this.optionButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
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
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // panelLog
            // 
            this.panelLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            resources.ApplyResources(this.panelLog, "panelLog");
            this.panelLog.Name = "panelLog";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.FlowLayoutPanel flowMenuLeft;

        private System.Windows.Forms.Panel pnlMain;
        private PACS_CustomControls.OptionButton obtnTCP;
        private PACS_CustomControls.OptionButton optionButton4;
        private PACS_CustomControls.OptionButton optionButton1;
        private PACS_CustomControls.OptionButton optionButton2;
        private System.Windows.Forms.Label lblSubStatus;
        private System.Windows.Forms.Panel panelLog;
    }
}