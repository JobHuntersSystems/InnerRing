namespace PACS_Spaceship
{
    partial class FrmMain
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
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblModeTag = new System.Windows.Forms.Label();
            this.lblClockTag = new System.Windows.Forms.Label();
            this.lblStatusIndicator = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.pnlTopbarGlow = new System.Windows.Forms.Panel();
            this.pnlNeonTopLine = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnAuthentification = new PACS_CustomControls.OptionButton();
            this.btnConnection = new PACS_CustomControls.OptionButton();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblSidebarCaption = new System.Windows.Forms.Label();
            this.pnlSidebarAccentLine2 = new System.Windows.Forms.Panel();
            this.pnlSidebarAccentLine = new System.Windows.Forms.Panel();
            this.pnlNeonSideLine = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblMainGhostTitle = new System.Windows.Forms.Label();
            this.pnlMainScanLine = new System.Windows.Forms.Panel();
            this.pnlMainFrameBottom = new System.Windows.Forms.Panel();
            this.pnlMainFrameRight = new System.Windows.Forms.Panel();
            this.pnlMainFrameLeft = new System.Windows.Forms.Panel();
            this.pnlMainFrameTop = new System.Windows.Forms.Panel();
            this.pnlMainCornerAccent = new System.Windows.Forms.Panel();
            this.pnlTopbar.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(10)))), ((int)(((byte)(14)))));
            this.pnlTopbar.Controls.Add(this.lblMinimize);
            this.pnlTopbar.Controls.Add(this.lblClose);
            this.pnlTopbar.Controls.Add(this.lblModeTag);
            this.pnlTopbar.Controls.Add(this.lblClockTag);
            this.pnlTopbar.Controls.Add(this.lblStatusIndicator);
            this.pnlTopbar.Controls.Add(this.lblSystemTitle);
            this.pnlTopbar.Controls.Add(this.pnlTopbarGlow);
            this.pnlTopbar.Controls.Add(this.pnlNeonTopLine);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(27, 25);
            this.pnlTopbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1653, 66);
            this.pnlTopbar.TabIndex = 0;
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.lblMinimize.Location = new System.Drawing.Point(1544, 20);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(36, 20);
            this.lblMinimize.TabIndex = 7;
            this.lblMinimize.Text = "[-]";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.lblClose.Location = new System.Drawing.Point(1592, 20);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(36, 20);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "[X]";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblModeTag
            // 
            this.lblModeTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModeTag.AutoSize = true;
            this.lblModeTag.Font = new System.Drawing.Font("Consolas", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(136)))));
            this.lblModeTag.Location = new System.Drawing.Point(855, 16);
            this.lblModeTag.Name = "lblModeTag";
            this.lblModeTag.Size = new System.Drawing.Size(171, 19);
            this.lblModeTag.TabIndex = 5;
            this.lblModeTag.Text = "MODE // CONNECTION";
            // 
            // lblClockTag
            // 
            this.lblClockTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblClockTag.AutoSize = true;
            this.lblClockTag.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClockTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(201)))), ((int)(((byte)(255)))));
            this.lblClockTag.Location = new System.Drawing.Point(551, 17);
            this.lblClockTag.Name = "lblClockTag";
            this.lblClockTag.Size = new System.Drawing.Size(256, 18);
            this.lblClockTag.TabIndex = 4;
            this.lblClockTag.Text = "SECTOR TIME: 23:14:09 // UTC+00";
            // 
            // lblStatusIndicator
            // 
            this.lblStatusIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusIndicator.AutoSize = true;
            this.lblStatusIndicator.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusIndicator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.lblStatusIndicator.Location = new System.Drawing.Point(551, 34);
            this.lblStatusIndicator.Name = "lblStatusIndicator";
            this.lblStatusIndicator.Size = new System.Drawing.Size(288, 20);
            this.lblStatusIndicator.TabIndex = 2;
            this.lblStatusIndicator.Text = "[ UPLINK STATE // ESTABLISHED ]";
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Consolas", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSystemTitle.Location = new System.Drawing.Point(16, 20);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(503, 29);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "/// PACS-SPACECHIP // _CONTROL CORE";
            // 
            // pnlTopbarGlow
            // 
            this.pnlTopbarGlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(136)))));
            this.pnlTopbarGlow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbarGlow.Location = new System.Drawing.Point(0, 0);
            this.pnlTopbarGlow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTopbarGlow.Name = "pnlTopbarGlow";
            this.pnlTopbarGlow.Size = new System.Drawing.Size(1653, 1);
            this.pnlTopbarGlow.TabIndex = 3;
            // 
            // pnlNeonTopLine
            // 
            this.pnlNeonTopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.pnlNeonTopLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNeonTopLine.Location = new System.Drawing.Point(0, 64);
            this.pnlNeonTopLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNeonTopLine.Name = "pnlNeonTopLine";
            this.pnlNeonTopLine.Size = new System.Drawing.Size(1653, 2);
            this.pnlNeonTopLine.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.pnlSidebar.Controls.Add(this.btnAuthentification);
            this.pnlSidebar.Controls.Add(this.btnConnection);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Controls.Add(this.pnlNeonSideLine);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(27, 91);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(15, 18, 15, 15);
            this.pnlSidebar.Size = new System.Drawing.Size(427, 770);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnAuthentification
            // 
            this.btnAuthentification.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAuthentification.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAuthentification.BackColor = System.Drawing.Color.Transparent;
            this.btnAuthentification.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.btnAuthentification.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAuthentification.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAuthentification.ClassName = "PACS-ProcessForms.dll";
            this.btnAuthentification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAuthentification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAuthentification.FormName = "PACS_ProcessForms.frmAuthentification";
            this.btnAuthentification.IsSelected = false;
            this.btnAuthentification.Location = new System.Drawing.Point(15, 185);
            this.btnAuthentification.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAuthentification.Name = "btnAuthentification";
            this.btnAuthentification.OptionIcon = null;
            this.btnAuthentification.OptionText = "AUTHENTIFICATION";
            this.btnAuthentification.Size = new System.Drawing.Size(396, 96);
            this.btnAuthentification.TabIndex = 2;
            this.btnAuthentification.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // btnConnection
            // 
            this.btnConnection.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.btnConnection.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConnection.BackColor = System.Drawing.Color.Transparent;
            this.btnConnection.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.btnConnection.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConnection.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.btnConnection.ClassName = "PACS-ProcessForms.dll";
            this.btnConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnection.FormName = "PACS_ProcessForms.frmConnection";
            this.btnConnection.IsSelected = false;
            this.btnConnection.Location = new System.Drawing.Point(15, 89);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.OptionIcon = null;
            this.btnConnection.OptionText = "CONNECTION";
            this.btnConnection.Size = new System.Drawing.Size(396, 96);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarCaption);
            this.pnlSidebarHeader.Controls.Add(this.pnlSidebarAccentLine2);
            this.pnlSidebarHeader.Controls.Add(this.pnlSidebarAccentLine);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(15, 18);
            this.pnlSidebarHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(396, 71);
            this.pnlSidebarHeader.TabIndex = 3;
            // 
            // lblSidebarCaption
            // 
            this.lblSidebarCaption.AutoSize = true;
            this.lblSidebarCaption.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.lblSidebarCaption.Location = new System.Drawing.Point(11, 25);
            this.lblSidebarCaption.Name = "lblSidebarCaption";
            this.lblSidebarCaption.Size = new System.Drawing.Size(297, 20);
            this.lblSidebarCaption.TabIndex = 2;
            this.lblSidebarCaption.Text = "/// TACTICAL MODULES // LAYER-01";
            // 
            // pnlSidebarAccentLine2
            // 
            this.pnlSidebarAccentLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.pnlSidebarAccentLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarAccentLine2.Location = new System.Drawing.Point(0, 68);
            this.pnlSidebarAccentLine2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebarAccentLine2.Name = "pnlSidebarAccentLine2";
            this.pnlSidebarAccentLine2.Size = new System.Drawing.Size(396, 1);
            this.pnlSidebarAccentLine2.TabIndex = 1;
            // 
            // pnlSidebarAccentLine
            // 
            this.pnlSidebarAccentLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlSidebarAccentLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarAccentLine.Location = new System.Drawing.Point(0, 69);
            this.pnlSidebarAccentLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSidebarAccentLine.Name = "pnlSidebarAccentLine";
            this.pnlSidebarAccentLine.Size = new System.Drawing.Size(396, 2);
            this.pnlSidebarAccentLine.TabIndex = 0;
            // 
            // pnlNeonSideLine
            // 
            this.pnlNeonSideLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlNeonSideLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNeonSideLine.Location = new System.Drawing.Point(411, 18);
            this.pnlNeonSideLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlNeonSideLine.Name = "pnlNeonSideLine";
            this.pnlNeonSideLine.Size = new System.Drawing.Size(1, 737);
            this.pnlNeonSideLine.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.pnlMain.Controls.Add(this.lblMainGhostTitle);
            this.pnlMain.Controls.Add(this.pnlMainScanLine);
            this.pnlMain.Controls.Add(this.pnlMainFrameBottom);
            this.pnlMain.Controls.Add(this.pnlMainFrameRight);
            this.pnlMain.Controls.Add(this.pnlMainFrameLeft);
            this.pnlMain.Controls.Add(this.pnlMainFrameTop);
            this.pnlMain.Controls.Add(this.pnlMainCornerAccent);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Location = new System.Drawing.Point(454, 91);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(19, 18, 19, 18);
            this.pnlMain.Size = new System.Drawing.Size(1226, 770);
            this.pnlMain.TabIndex = 2;
            // 
            // lblMainGhostTitle
            // 
            this.lblMainGhostTitle.AutoSize = true;
            this.lblMainGhostTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainGhostTitle.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainGhostTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.lblMainGhostTitle.Location = new System.Drawing.Point(28, 31);
            this.lblMainGhostTitle.Name = "lblMainGhostTitle";
            this.lblMainGhostTitle.Size = new System.Drawing.Size(444, 26);
            this.lblMainGhostTitle.TabIndex = 6;
            this.lblMainGhostTitle.Text = "/// TACTICAL DISPLAY // STANDBY MODE";
            // 
            // pnlMainScanLine
            // 
            this.pnlMainScanLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(173)))));
            this.pnlMainScanLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainScanLine.Location = new System.Drawing.Point(20, 19);
            this.pnlMainScanLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainScanLine.Name = "pnlMainScanLine";
            this.pnlMainScanLine.Size = new System.Drawing.Size(1186, 1);
            this.pnlMainScanLine.TabIndex = 5;
            // 
            // pnlMainFrameBottom
            // 
            this.pnlMainFrameBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.pnlMainFrameBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainFrameBottom.Location = new System.Drawing.Point(20, 751);
            this.pnlMainFrameBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainFrameBottom.Name = "pnlMainFrameBottom";
            this.pnlMainFrameBottom.Size = new System.Drawing.Size(1186, 1);
            this.pnlMainFrameBottom.TabIndex = 1;
            // 
            // pnlMainFrameRight
            // 
            this.pnlMainFrameRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.pnlMainFrameRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMainFrameRight.Location = new System.Drawing.Point(1206, 19);
            this.pnlMainFrameRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainFrameRight.Name = "pnlMainFrameRight";
            this.pnlMainFrameRight.Size = new System.Drawing.Size(1, 733);
            this.pnlMainFrameRight.TabIndex = 2;
            // 
            // pnlMainFrameLeft
            // 
            this.pnlMainFrameLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlMainFrameLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainFrameLeft.Location = new System.Drawing.Point(19, 19);
            this.pnlMainFrameLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainFrameLeft.Name = "pnlMainFrameLeft";
            this.pnlMainFrameLeft.Size = new System.Drawing.Size(1, 733);
            this.pnlMainFrameLeft.TabIndex = 3;
            // 
            // pnlMainFrameTop
            // 
            this.pnlMainFrameTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlMainFrameTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainFrameTop.Location = new System.Drawing.Point(19, 18);
            this.pnlMainFrameTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainFrameTop.Name = "pnlMainFrameTop";
            this.pnlMainFrameTop.Size = new System.Drawing.Size(1188, 1);
            this.pnlMainFrameTop.TabIndex = 4;
            // 
            // pnlMainCornerAccent
            // 
            this.pnlMainCornerAccent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainCornerAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.pnlMainCornerAccent.Location = new System.Drawing.Point(1186, 748);
            this.pnlMainCornerAccent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMainCornerAccent.Name = "pnlMainCornerAccent";
            this.pnlMainCornerAccent.Size = new System.Drawing.Size(21, 4);
            this.pnlMainCornerAccent.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PACS_Spaceship.Properties.Resources.qimono_earth_1756274;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlSidebarHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain; // OBLIGATORIO LLAMARSE ASÍ
        private PACS_CustomControls.OptionButton btnConnection;
        private PACS_CustomControls.OptionButton btnAuthentification;

        private System.Windows.Forms.Panel pnlTopbarGlow;
        private System.Windows.Forms.Panel pnlNeonTopLine;
        private System.Windows.Forms.Panel pnlNeonSideLine;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblStatusIndicator;
        private System.Windows.Forms.Label lblModeTag;
        private System.Windows.Forms.Label lblClockTag;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblSidebarCaption;
        private System.Windows.Forms.Panel pnlSidebarAccentLine;
        private System.Windows.Forms.Panel pnlSidebarAccentLine2;
        private System.Windows.Forms.Panel pnlMainFrameTop;
        private System.Windows.Forms.Panel pnlMainFrameLeft;
        private System.Windows.Forms.Panel pnlMainFrameRight;
        private System.Windows.Forms.Panel pnlMainFrameBottom;
        private System.Windows.Forms.Panel pnlMainScanLine;
        private System.Windows.Forms.Label lblMainGhostTitle;
        private System.Windows.Forms.Panel pnlMainCornerAccent;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
    }
}