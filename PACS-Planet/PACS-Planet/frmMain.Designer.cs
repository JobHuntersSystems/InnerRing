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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblSubStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flowMenuLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.obtnTCP = new PACS_CustomControls.OptionButton();
            this.optionButton2 = new PACS_CustomControls.OptionButton();
            this.optionButton4 = new PACS_CustomControls.OptionButton();
            this.optionButton1 = new PACS_CustomControls.OptionButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcsConsoleMain = new PACS_CustomControls.PacsConsole();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flowMenuLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.lblSubStatus);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1367, 65);
            this.panelHeader.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.DarkRed;
            this.picLogo.Location = new System.Drawing.Point(21, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(50, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lblTitle.Location = new System.Drawing.Point(460, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(558, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "··· PACS PLANET CONTROL CENTER ···";
            // 
            // flowMenuLeft
            // 
            this.flowMenuLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(16)))));
            this.flowMenuLeft.Controls.Add(this.obtnTCP);
            this.flowMenuLeft.Controls.Add(this.optionButton2);
            this.flowMenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowMenuLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowMenuLeft.Location = new System.Drawing.Point(0, 65);
            this.flowMenuLeft.Name = "flowMenuLeft";
            this.flowMenuLeft.Padding = new System.Windows.Forms.Padding(10);
            this.flowMenuLeft.Size = new System.Drawing.Size(242, 820);
            this.flowMenuLeft.TabIndex = 2;
            // 
            // obtnTCP
            // 
            this.obtnTCP.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.obtnTCP.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.obtnTCP.BackColor = System.Drawing.Color.Transparent;
            this.obtnTCP.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.obtnTCP.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.obtnTCP.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.obtnTCP.ClassName = "";
            this.obtnTCP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.obtnTCP.FormName = "";
            this.obtnTCP.IsSelected = false;
            this.obtnTCP.Location = new System.Drawing.Point(16, 16);
            this.obtnTCP.Margin = new System.Windows.Forms.Padding(6);
            this.obtnTCP.Name = "obtnTCP";
            this.obtnTCP.OptionIcon = null;
            this.obtnTCP.OptionText = "TCP Server";
            this.obtnTCP.Size = new System.Drawing.Size(220, 62);
            this.obtnTCP.TabIndex = 0;
            this.obtnTCP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            this.obtnTCP.Click += new System.EventHandler(this.obtnTCP_Click);
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
            this.optionButton2.Location = new System.Drawing.Point(16, 90);
            this.optionButton2.Margin = new System.Windows.Forms.Padding(6);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.OptionIcon = null;
            this.optionButton2.OptionText = "PLACE HOLDER";
            this.optionButton2.Size = new System.Drawing.Size(220, 62);
            this.optionButton2.TabIndex = 3;
            this.optionButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.pcsConsoleMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(242, 685);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 200);
            this.panel1.TabIndex = 1;
            // 
            // pcsConsoleMain
            // 
            this.pcsConsoleMain.AccentColor = System.Drawing.Color.Aqua;
            this.pcsConsoleMain.BackColor = System.Drawing.Color.Transparent;
            this.pcsConsoleMain.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.pcsConsoleMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcsConsoleMain.Location = new System.Drawing.Point(0, 0);
            this.pcsConsoleMain.Margin = new System.Windows.Forms.Padding(6);
            this.pcsConsoleMain.Name = "pcsConsoleMain";
            this.pcsConsoleMain.Size = new System.Drawing.Size(1125, 200);
            this.pcsConsoleMain.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(242, 65);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMain.Size = new System.Drawing.Size(1125, 620);
            this.pnlMain.TabIndex = 0;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1367, 885);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowMenuLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "PACS Planet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flowMenuLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.FlowLayoutPanel flowMenuLeft;
        private PACS_CustomControls.OptionButton optionButton4;
        private PACS_CustomControls.OptionButton optionButton1;
        private PACS_CustomControls.OptionButton optionButton2;
        private System.Windows.Forms.Label lblSubStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMain;
        private PACS_CustomControls.PacsConsole pcsConsoleMain;
        private PACS_CustomControls.OptionButton obtnTCP;
    }
}