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
            this.lblModeTag = new System.Windows.Forms.Label();
            this.lblClockTag = new System.Windows.Forms.Label();
            this.lblStatusIndicator = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.pnlTopbarGlow = new System.Windows.Forms.Panel();
            this.pnlNeonTopLine = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
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
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.btnSummery = new PACS_CustomControls.OptionButton();
            this.btnAuthentification = new PACS_CustomControls.OptionButton();
            this.btnConnection = new PACS_CustomControls.OptionButton();
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
            this.pnlTopbar.Location = new System.Drawing.Point(20, 20);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Size = new System.Drawing.Size(1240, 54);
            this.pnlTopbar.TabIndex = 0;
            // 
            // lblModeTag
            // 
            this.lblModeTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblModeTag.AutoSize = true;
            this.lblModeTag.Font = new System.Drawing.Font("Consolas", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModeTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(136)))));
            this.lblModeTag.Location = new System.Drawing.Point(641, 13);
            this.lblModeTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModeTag.Name = "lblModeTag";
            this.lblModeTag.Size = new System.Drawing.Size(133, 15);
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
            this.lblClockTag.Location = new System.Drawing.Point(413, 14);
            this.lblClockTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClockTag.Name = "lblClockTag";
            this.lblClockTag.Size = new System.Drawing.Size(224, 14);
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
            this.lblStatusIndicator.Location = new System.Drawing.Point(413, 28);
            this.lblStatusIndicator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusIndicator.Name = "lblStatusIndicator";
            this.lblStatusIndicator.Size = new System.Drawing.Size(256, 17);
            this.lblStatusIndicator.TabIndex = 2;
            this.lblStatusIndicator.Text = "[ UPLINK STATE // ESTABLISHED ]";
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Consolas", 14.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSystemTitle.Location = new System.Drawing.Point(12, 16);
            this.lblSystemTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(395, 23);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "/// PACS-SPACECHIP // _CONTROL CORE";
            // 
            // pnlTopbarGlow
            // 
            this.pnlTopbarGlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(72)))), ((int)(((byte)(136)))));
            this.pnlTopbarGlow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbarGlow.Location = new System.Drawing.Point(0, 0);
            this.pnlTopbarGlow.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTopbarGlow.Name = "pnlTopbarGlow";
            this.pnlTopbarGlow.Size = new System.Drawing.Size(1240, 1);
            this.pnlTopbarGlow.TabIndex = 3;
            // 
            // pnlNeonTopLine
            // 
            this.pnlNeonTopLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(237)))), ((int)(((byte)(255)))));
            this.pnlNeonTopLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNeonTopLine.Location = new System.Drawing.Point(0, 52);
            this.pnlNeonTopLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNeonTopLine.Name = "pnlNeonTopLine";
            this.pnlNeonTopLine.Size = new System.Drawing.Size(1240, 2);
            this.pnlNeonTopLine.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(13)))), ((int)(((byte)(18)))));
            this.pnlSidebar.Controls.Add(this.btnSummery);
            this.pnlSidebar.Controls.Add(this.btnAuthentification);
            this.pnlSidebar.Controls.Add(this.btnConnection);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Controls.Add(this.pnlNeonSideLine);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(20, 74);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(11, 15, 11, 12);
            this.pnlSidebar.Size = new System.Drawing.Size(320, 626);
            this.pnlSidebar.TabIndex = 1;
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.pnlSidebarHeader.Controls.Add(this.lblSidebarCaption);
            this.pnlSidebarHeader.Controls.Add(this.pnlSidebarAccentLine2);
            this.pnlSidebarHeader.Controls.Add(this.pnlSidebarAccentLine);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(11, 15);
            this.pnlSidebarHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(297, 58);
            this.pnlSidebarHeader.TabIndex = 3;
            // 
            // lblSidebarCaption
            // 
            this.lblSidebarCaption.AutoSize = true;
            this.lblSidebarCaption.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(188)))), ((int)(((byte)(70)))));
            this.lblSidebarCaption.Location = new System.Drawing.Point(8, 20);
            this.lblSidebarCaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSidebarCaption.Name = "lblSidebarCaption";
            this.lblSidebarCaption.Size = new System.Drawing.Size(264, 17);
            this.lblSidebarCaption.TabIndex = 2;
            this.lblSidebarCaption.Text = "/// TACTICAL MODULES // LAYER-01";
            // 
            // pnlSidebarAccentLine2
            // 
            this.pnlSidebarAccentLine2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(120)))));
            this.pnlSidebarAccentLine2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarAccentLine2.Location = new System.Drawing.Point(0, 55);
            this.pnlSidebarAccentLine2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebarAccentLine2.Name = "pnlSidebarAccentLine2";
            this.pnlSidebarAccentLine2.Size = new System.Drawing.Size(297, 1);
            this.pnlSidebarAccentLine2.TabIndex = 1;
            // 
            // pnlSidebarAccentLine
            // 
            this.pnlSidebarAccentLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlSidebarAccentLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarAccentLine.Location = new System.Drawing.Point(0, 56);
            this.pnlSidebarAccentLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSidebarAccentLine.Name = "pnlSidebarAccentLine";
            this.pnlSidebarAccentLine.Size = new System.Drawing.Size(297, 2);
            this.pnlSidebarAccentLine.TabIndex = 0;
            // 
            // pnlNeonSideLine
            // 
            this.pnlNeonSideLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlNeonSideLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNeonSideLine.Location = new System.Drawing.Point(308, 15);
            this.pnlNeonSideLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNeonSideLine.Name = "pnlNeonSideLine";
            this.pnlNeonSideLine.Size = new System.Drawing.Size(1, 599);
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
            this.pnlMain.Location = new System.Drawing.Point(340, 74);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.pnlMain.Size = new System.Drawing.Size(920, 626);
            this.pnlMain.TabIndex = 2;
            // 
            // lblMainGhostTitle
            // 
            this.lblMainGhostTitle.AutoSize = true;
            this.lblMainGhostTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMainGhostTitle.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainGhostTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(118)))));
            this.lblMainGhostTitle.Location = new System.Drawing.Point(21, 25);
            this.lblMainGhostTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMainGhostTitle.Name = "lblMainGhostTitle";
            this.lblMainGhostTitle.Size = new System.Drawing.Size(370, 22);
            this.lblMainGhostTitle.TabIndex = 6;
            this.lblMainGhostTitle.Text = "/// TACTICAL DISPLAY // STANDBY MODE";
            // 
            // pnlMainScanLine
            // 
            this.pnlMainScanLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(255)))), ((int)(((byte)(173)))));
            this.pnlMainScanLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainScanLine.Location = new System.Drawing.Point(15, 16);
            this.pnlMainScanLine.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainScanLine.Name = "pnlMainScanLine";
            this.pnlMainScanLine.Size = new System.Drawing.Size(890, 1);
            this.pnlMainScanLine.TabIndex = 5;
            // 
            // pnlMainFrameBottom
            // 
            this.pnlMainFrameBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.pnlMainFrameBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMainFrameBottom.Location = new System.Drawing.Point(15, 610);
            this.pnlMainFrameBottom.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainFrameBottom.Name = "pnlMainFrameBottom";
            this.pnlMainFrameBottom.Size = new System.Drawing.Size(890, 1);
            this.pnlMainFrameBottom.TabIndex = 1;
            // 
            // pnlMainFrameRight
            // 
            this.pnlMainFrameRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.pnlMainFrameRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMainFrameRight.Location = new System.Drawing.Point(905, 16);
            this.pnlMainFrameRight.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainFrameRight.Name = "pnlMainFrameRight";
            this.pnlMainFrameRight.Size = new System.Drawing.Size(1, 595);
            this.pnlMainFrameRight.TabIndex = 2;
            // 
            // pnlMainFrameLeft
            // 
            this.pnlMainFrameLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlMainFrameLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMainFrameLeft.Location = new System.Drawing.Point(14, 16);
            this.pnlMainFrameLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainFrameLeft.Name = "pnlMainFrameLeft";
            this.pnlMainFrameLeft.Size = new System.Drawing.Size(1, 595);
            this.pnlMainFrameLeft.TabIndex = 3;
            // 
            // pnlMainFrameTop
            // 
            this.pnlMainFrameTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pnlMainFrameTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainFrameTop.Location = new System.Drawing.Point(14, 15);
            this.pnlMainFrameTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainFrameTop.Name = "pnlMainFrameTop";
            this.pnlMainFrameTop.Size = new System.Drawing.Size(892, 1);
            this.pnlMainFrameTop.TabIndex = 4;
            // 
            // pnlMainCornerAccent
            // 
            this.pnlMainCornerAccent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainCornerAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(76)))), ((int)(((byte)(136)))));
            this.pnlMainCornerAccent.Location = new System.Drawing.Point(890, 608);
            this.pnlMainCornerAccent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainCornerAccent.Name = "pnlMainCornerAccent";
            this.pnlMainCornerAccent.Size = new System.Drawing.Size(16, 3);
            this.pnlMainCornerAccent.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.lblClose.Location = new System.Drawing.Point(1194, 16);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(32, 17);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "[X]";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.lblMinimize.Location = new System.Drawing.Point(1158, 16);
            this.lblMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(32, 17);
            this.lblMinimize.TabIndex = 7;
            this.lblMinimize.Text = "[-]";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // btnSummery
            // 
            this.btnSummery.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.btnSummery.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(190)))));
            this.btnSummery.BackColor = System.Drawing.Color.Transparent;
            this.btnSummery.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(18)))), ((int)(((byte)(24)))));
            this.btnSummery.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSummery.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
            this.btnSummery.ClassName = "PACS-ProcessForms.dll";
            this.btnSummery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSummery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSummery.FormName = "WpnSystems.FrmWeapons";
            this.btnSummery.IsSelected = false;
            this.btnSummery.Location = new System.Drawing.Point(11, 229);
            this.btnSummery.Margin = new System.Windows.Forms.Padding(4);
            this.btnSummery.Name = "btnSummery";
            this.btnSummery.OptionIcon = null;
            this.btnSummery.OptionText = "SUMMARY";
            this.btnSummery.Size = new System.Drawing.Size(297, 78);
            this.btnSummery.TabIndex = 4;
            this.btnSummery.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(212)))));
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
            this.btnAuthentification.Location = new System.Drawing.Point(11, 151);
            this.btnAuthentification.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuthentification.Name = "btnAuthentification";
            this.btnAuthentification.OptionIcon = null;
            this.btnAuthentification.OptionText = "AUTHENTIFICATION";
            this.btnAuthentification.Size = new System.Drawing.Size(297, 78);
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
            this.btnConnection.Location = new System.Drawing.Point(11, 73);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.OptionIcon = null;
            this.btnConnection.OptionText = "CONNECTION";
            this.btnConnection.Size = new System.Drawing.Size(297, 78);
            this.btnConnection.TabIndex = 1;
            this.btnConnection.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PACS_Spaceship.Properties.Resources.qimono_earth_1756274;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTopbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20);
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

        private PACS_CustomControls.OptionButton btnSummery;
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