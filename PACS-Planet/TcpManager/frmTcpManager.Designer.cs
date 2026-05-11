namespace TcpManager
{
    partial class frmTcpManager
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTcpManager));
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.tlpCenter = new System.Windows.Forms.TableLayoutPanel();
            this.pnlConfiguration = new System.Windows.Forms.Panel();
            this.txtFilePort = new System.Windows.Forms.TextBox();
            this.txtDataPort = new System.Windows.Forms.TextBox();
            this.txtPlanetIp = new System.Windows.Forms.TextBox();
            this.lblFilePort = new System.Windows.Forms.Label();
            this.lblDataPort = new System.Windows.Forms.Label();
            this.lblPlanetIp = new System.Windows.Forms.Label();
            this.lblConfigurationTitle = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.lblControlsTitle = new System.Windows.Forms.Label();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.lblLastMessageValue = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblSpaceshipIpValue = new System.Windows.Forms.Label();
            this.lblSpaceshipIp = new System.Windows.Forms.Label();
            this.lblCurrentRequestValue = new System.Windows.Forms.Label();
            this.lblCurrentRequest = new System.Windows.Forms.Label();
            this.lblConnectionTitle = new System.Windows.Forms.Label();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.pcsConsoleLog = new PACS_CustomControls.PacsConsole();
            this.pctSpaceship = new System.Windows.Forms.PictureBox();
            this.pctPlanet = new System.Windows.Forms.PictureBox();
            this.pctSpaceBackground = new System.Windows.Forms.PictureBox();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFilePortValue = new System.Windows.Forms.Label();
            this.lblFilePortTitle = new System.Windows.Forms.Label();
            this.pnlServerStatus = new System.Windows.Forms.Panel();
            this.lblServerStatusValue = new System.Windows.Forms.Label();
            this.lblServerStatusTitle = new System.Windows.Forms.Label();
            this.pnlDataPort = new System.Windows.Forms.Panel();
            this.lblDataPortValue = new System.Windows.Forms.Label();
            this.lblDataPortTitle = new System.Windows.Forms.Label();
            this.pnlFilePort = new System.Windows.Forms.Panel();
            this.lblIPPlanetValue = new System.Windows.Forms.Label();
            this.lblIPPlanetTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.tlpCenter.SuspendLayout();
            this.pnlConfiguration.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlConnection.SuspendLayout();
            this.pnlLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpaceship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlanet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpaceBackground)).BeginInit();
            this.tlpStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlServerStatus.SuspendLayout();
            this.pnlDataPort.SuspendLayout();
            this.pnlFilePort.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.pnlRoot.Controls.Add(this.tlpCenter);
            this.pnlRoot.Controls.Add(this.pnlLog);
            this.pnlRoot.Controls.Add(this.tlpStatus);
            this.pnlRoot.Controls.Add(this.pnlHeader);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRoot.Size = new System.Drawing.Size(1114, 617);
            this.pnlRoot.TabIndex = 0;
            // 
            // tlpCenter
            // 
            this.tlpCenter.ColumnCount = 3;
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlpCenter.Controls.Add(this.pnlConfiguration, 0, 0);
            this.tlpCenter.Controls.Add(this.pnlControls, 1, 0);
            this.tlpCenter.Controls.Add(this.pnlConnection, 2, 0);
            this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCenter.Location = new System.Drawing.Point(12, 166);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.tlpCenter.RowCount = 1;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.Size = new System.Drawing.Size(1090, 200);
            this.tlpCenter.TabIndex = 2;
            // 
            // pnlConfiguration
            // 
            this.pnlConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pnlConfiguration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguration.Controls.Add(this.txtFilePort);
            this.pnlConfiguration.Controls.Add(this.txtDataPort);
            this.pnlConfiguration.Controls.Add(this.txtPlanetIp);
            this.pnlConfiguration.Controls.Add(this.lblFilePort);
            this.pnlConfiguration.Controls.Add(this.lblDataPort);
            this.pnlConfiguration.Controls.Add(this.lblPlanetIp);
            this.pnlConfiguration.Controls.Add(this.lblConfigurationTitle);
            this.pnlConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguration.Location = new System.Drawing.Point(5, 13);
            this.pnlConfiguration.Margin = new System.Windows.Forms.Padding(5);
            this.pnlConfiguration.Name = "pnlConfiguration";
            this.pnlConfiguration.Padding = new System.Windows.Forms.Padding(14);
            this.pnlConfiguration.Size = new System.Drawing.Size(360, 174);
            this.pnlConfiguration.TabIndex = 0;
            // 
            // txtFilePort
            // 
            this.txtFilePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(8)))));
            this.txtFilePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePort.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtFilePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtFilePort.Location = new System.Drawing.Point(130, 131);
            this.txtFilePort.Name = "txtFilePort";
            this.txtFilePort.Size = new System.Drawing.Size(150, 23);
            this.txtFilePort.TabIndex = 6;
            // 
            // txtDataPort
            // 
            this.txtDataPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(8)))));
            this.txtDataPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataPort.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtDataPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.txtDataPort.Location = new System.Drawing.Point(130, 91);
            this.txtDataPort.Name = "txtDataPort";
            this.txtDataPort.Size = new System.Drawing.Size(150, 23);
            this.txtDataPort.TabIndex = 4;
            // 
            // txtPlanetIp
            // 
            this.txtPlanetIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(8)))));
            this.txtPlanetIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanetIp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtPlanetIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.txtPlanetIp.Location = new System.Drawing.Point(130, 51);
            this.txtPlanetIp.Name = "txtPlanetIp";
            this.txtPlanetIp.ReadOnly = true;
            this.txtPlanetIp.Size = new System.Drawing.Size(150, 23);
            this.txtPlanetIp.TabIndex = 2;
            // 
            // lblFilePort
            // 
            this.lblFilePort.AutoSize = true;
            this.lblFilePort.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilePort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblFilePort.Location = new System.Drawing.Point(17, 135);
            this.lblFilePort.Name = "lblFilePort";
            this.lblFilePort.Size = new System.Drawing.Size(70, 14);
            this.lblFilePort.TabIndex = 5;
            this.lblFilePort.Text = "FILE PORT";
            // 
            // lblDataPort
            // 
            this.lblDataPort.AutoSize = true;
            this.lblDataPort.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblDataPort.Location = new System.Drawing.Point(17, 95);
            this.lblDataPort.Name = "lblDataPort";
            this.lblDataPort.Size = new System.Drawing.Size(70, 14);
            this.lblDataPort.TabIndex = 3;
            this.lblDataPort.Text = "DATA PORT";
            // 
            // lblPlanetIp
            // 
            this.lblPlanetIp.AutoSize = true;
            this.lblPlanetIp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlanetIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblPlanetIp.Location = new System.Drawing.Point(17, 55);
            this.lblPlanetIp.Name = "lblPlanetIp";
            this.lblPlanetIp.Size = new System.Drawing.Size(70, 14);
            this.lblPlanetIp.TabIndex = 1;
            this.lblPlanetIp.Text = "PLANET IP";
            // 
            // lblConfigurationTitle
            // 
            this.lblConfigurationTitle.AutoSize = true;
            this.lblConfigurationTitle.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblConfigurationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblConfigurationTitle.Location = new System.Drawing.Point(14, 12);
            this.lblConfigurationTitle.Name = "lblConfigurationTitle";
            this.lblConfigurationTitle.Size = new System.Drawing.Size(144, 18);
            this.lblConfigurationTitle.TabIndex = 0;
            this.lblConfigurationTitle.Text = "TCP CONFIGURATION";
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.btnCheckConnection);
            this.pnlControls.Controls.Add(this.btnStopServer);
            this.pnlControls.Controls.Add(this.btnStartServer);
            this.pnlControls.Controls.Add(this.lblControlsTitle);
            this.pnlControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(375, 13);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(5);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(14);
            this.pnlControls.Size = new System.Drawing.Size(338, 174);
            this.pnlControls.TabIndex = 1;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnCheckConnection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCheckConnection.FlatAppearance.BorderSize = 2;
            this.btnCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckConnection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCheckConnection.Location = new System.Drawing.Point(20, 126);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(290, 32);
            this.btnCheckConnection.TabIndex = 3;
            this.btnCheckConnection.Text = "CHECK CONNECTION";
            this.btnCheckConnection.UseVisualStyleBackColor = false;
            this.btnCheckConnection.Visible = false;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnStopServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStopServer.FlatAppearance.BorderSize = 2;
            this.btnStopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnStopServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStopServer.Location = new System.Drawing.Point(20, 88);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(290, 32);
            this.btnStopServer.TabIndex = 2;
            this.btnStopServer.Text = "STOP TCP SERVER";
            this.btnStopServer.UseVisualStyleBackColor = false;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnStartServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.btnStartServer.FlatAppearance.BorderSize = 2;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.btnStartServer.Location = new System.Drawing.Point(20, 50);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(290, 32);
            this.btnStartServer.TabIndex = 1;
            this.btnStartServer.Text = "START TCP SERVER";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // lblControlsTitle
            // 
            this.lblControlsTitle.AutoSize = true;
            this.lblControlsTitle.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblControlsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblControlsTitle.Location = new System.Drawing.Point(14, 12);
            this.lblControlsTitle.Name = "lblControlsTitle";
            this.lblControlsTitle.Size = new System.Drawing.Size(128, 18);
            this.lblControlsTitle.TabIndex = 0;
            this.lblControlsTitle.Text = "SERVER CONTROLS";
            // 
            // pnlConnection
            // 
            this.pnlConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pnlConnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnection.Controls.Add(this.lblLastMessageValue);
            this.pnlConnection.Controls.Add(this.lblLastMessage);
            this.pnlConnection.Controls.Add(this.lblSpaceshipIpValue);
            this.pnlConnection.Controls.Add(this.lblSpaceshipIp);
            this.pnlConnection.Controls.Add(this.lblCurrentRequestValue);
            this.pnlConnection.Controls.Add(this.lblCurrentRequest);
            this.pnlConnection.Controls.Add(this.lblConnectionTitle);
            this.pnlConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnection.Location = new System.Drawing.Point(723, 13);
            this.pnlConnection.Margin = new System.Windows.Forms.Padding(5);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Padding = new System.Windows.Forms.Padding(14);
            this.pnlConnection.Size = new System.Drawing.Size(362, 174);
            this.pnlConnection.TabIndex = 2;
            // 
            // lblLastMessageValue
            // 
            this.lblLastMessageValue.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMessageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblLastMessageValue.Location = new System.Drawing.Point(145, 127);
            this.lblLastMessageValue.Name = "lblLastMessageValue";
            this.lblLastMessageValue.Size = new System.Drawing.Size(216, 20);
            this.lblLastMessageValue.TabIndex = 6;
            this.lblLastMessageValue.Text = "NONE";
            this.lblLastMessageValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblLastMessage.Location = new System.Drawing.Point(17, 130);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(91, 14);
            this.lblLastMessage.TabIndex = 5;
            this.lblLastMessage.Text = "LAST MESSAGE";
            // 
            // lblSpaceshipIpValue
            // 
            this.lblSpaceshipIpValue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpaceshipIpValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSpaceshipIpValue.Location = new System.Drawing.Point(145, 89);
            this.lblSpaceshipIpValue.Name = "lblSpaceshipIpValue";
            this.lblSpaceshipIpValue.Size = new System.Drawing.Size(150, 20);
            this.lblSpaceshipIpValue.TabIndex = 4;
            this.lblSpaceshipIpValue.Text = "--";
            this.lblSpaceshipIpValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSpaceshipIp
            // 
            this.lblSpaceshipIp.AutoSize = true;
            this.lblSpaceshipIp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblSpaceshipIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblSpaceshipIp.Location = new System.Drawing.Point(17, 92);
            this.lblSpaceshipIp.Name = "lblSpaceshipIp";
            this.lblSpaceshipIp.Size = new System.Drawing.Size(91, 14);
            this.lblSpaceshipIp.TabIndex = 3;
            this.lblSpaceshipIp.Text = "SPACESHIP IP";
            // 
            // lblCurrentRequestValue
            // 
            this.lblCurrentRequestValue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentRequestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lblCurrentRequestValue.Location = new System.Drawing.Point(145, 52);
            this.lblCurrentRequestValue.Name = "lblCurrentRequestValue";
            this.lblCurrentRequestValue.Size = new System.Drawing.Size(150, 20);
            this.lblCurrentRequestValue.TabIndex = 2;
            this.lblCurrentRequestValue.Text = "--";
            this.lblCurrentRequestValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentRequest
            // 
            this.lblCurrentRequest.AutoSize = true;
            this.lblCurrentRequest.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblCurrentRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblCurrentRequest.Location = new System.Drawing.Point(17, 55);
            this.lblCurrentRequest.Name = "lblCurrentRequest";
            this.lblCurrentRequest.Size = new System.Drawing.Size(91, 14);
            this.lblCurrentRequest.TabIndex = 1;
            this.lblCurrentRequest.Text = "CURRENT REQ.";
            // 
            // lblConnectionTitle
            // 
            this.lblConnectionTitle.AutoSize = true;
            this.lblConnectionTitle.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblConnectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblConnectionTitle.Location = new System.Drawing.Point(14, 12);
            this.lblConnectionTitle.Name = "lblConnectionTitle";
            this.lblConnectionTitle.Size = new System.Drawing.Size(144, 18);
            this.lblConnectionTitle.TabIndex = 0;
            this.lblConnectionTitle.Text = "CURRENT SPACESHIP";
            // 
            // pnlLog
            // 
            this.pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLog.Controls.Add(this.pcsConsoleLog);
            this.pnlLog.Controls.Add(this.pctSpaceship);
            this.pnlLog.Controls.Add(this.pctPlanet);
            this.pnlLog.Controls.Add(this.pctSpaceBackground);
            this.pnlLog.Location = new System.Drawing.Point(12, 372);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(1086, 233);
            this.pnlLog.TabIndex = 3;
            // 
            // pcsConsoleLog
            // 
            this.pcsConsoleLog.AccentColor = System.Drawing.Color.Yellow;
            this.pcsConsoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcsConsoleLog.BackColor = System.Drawing.Color.Transparent;
            this.pcsConsoleLog.ConsoleTitle = "TCP LOG CONSOLE";
            this.pcsConsoleLog.Location = new System.Drawing.Point(3, 3);
            this.pcsConsoleLog.Name = "pcsConsoleLog";
            this.pcsConsoleLog.Size = new System.Drawing.Size(535, 225);
            this.pcsConsoleLog.TabIndex = 4;
            // 
            // pctSpaceship
            // 
            this.pctSpaceship.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSpaceship.Location = new System.Drawing.Point(956, 7);
            this.pctSpaceship.Name = "pctSpaceship";
            this.pctSpaceship.Size = new System.Drawing.Size(121, 116);
            this.pctSpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSpaceship.TabIndex = 3;
            this.pctSpaceship.TabStop = false;
            this.pctSpaceship.Visible = false;
            // 
            // pctPlanet
            // 
            this.pctPlanet.Location = new System.Drawing.Point(543, 8);
            this.pctPlanet.Name = "pctPlanet";
            this.pctPlanet.Size = new System.Drawing.Size(212, 214);
            this.pctPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlanet.TabIndex = 1;
            this.pctPlanet.TabStop = false;
            // 
            // pctSpaceBackground
            // 
            this.pctSpaceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pctSpaceBackground.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctSpaceBackground.Image = ((System.Drawing.Image)(resources.GetObject("pctSpaceBackground.Image")));
            this.pctSpaceBackground.Location = new System.Drawing.Point(655, 0);
            this.pctSpaceBackground.Name = "pctSpaceBackground";
            this.pctSpaceBackground.Size = new System.Drawing.Size(429, 231);
            this.pctSpaceBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctSpaceBackground.TabIndex = 2;
            this.pctSpaceBackground.TabStop = false;
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 4;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.34964F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.70239F));
            this.tlpStatus.Controls.Add(this.panel1, 0, 0);
            this.tlpStatus.Controls.Add(this.pnlServerStatus, 0, 0);
            this.tlpStatus.Controls.Add(this.pnlDataPort, 1, 0);
            this.tlpStatus.Controls.Add(this.pnlFilePort, 2, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpStatus.Location = new System.Drawing.Point(12, 70);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 6);
            this.tlpStatus.RowCount = 1;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.Size = new System.Drawing.Size(1090, 96);
            this.tlpStatus.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFilePortValue);
            this.panel1.Controls.Add(this.lblFilePortTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(277, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(262, 70);
            this.panel1.TabIndex = 3;
            // 
            // lblFilePortValue
            // 
            this.lblFilePortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilePortValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblFilePortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblFilePortValue.Location = new System.Drawing.Point(8, 30);
            this.lblFilePortValue.Name = "lblFilePortValue";
            this.lblFilePortValue.Size = new System.Drawing.Size(244, 30);
            this.lblFilePortValue.TabIndex = 1;
            this.lblFilePortValue.Text = "-";
            this.lblFilePortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilePortTitle
            // 
            this.lblFilePortTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilePortTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilePortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblFilePortTitle.Location = new System.Drawing.Point(8, 8);
            this.lblFilePortTitle.Name = "lblFilePortTitle";
            this.lblFilePortTitle.Size = new System.Drawing.Size(244, 22);
            this.lblFilePortTitle.TabIndex = 0;
            this.lblFilePortTitle.Text = "FILE PORT";
            this.lblFilePortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlServerStatus
            // 
            this.pnlServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlServerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServerStatus.Controls.Add(this.lblServerStatusValue);
            this.pnlServerStatus.Controls.Add(this.lblServerStatusTitle);
            this.pnlServerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServerStatus.Location = new System.Drawing.Point(5, 15);
            this.pnlServerStatus.Margin = new System.Windows.Forms.Padding(5);
            this.pnlServerStatus.Name = "pnlServerStatus";
            this.pnlServerStatus.Padding = new System.Windows.Forms.Padding(8);
            this.pnlServerStatus.Size = new System.Drawing.Size(262, 70);
            this.pnlServerStatus.TabIndex = 0;
            // 
            // lblServerStatusValue
            // 
            this.lblServerStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerStatusValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblServerStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblServerStatusValue.Location = new System.Drawing.Point(8, 30);
            this.lblServerStatusValue.Name = "lblServerStatusValue";
            this.lblServerStatusValue.Size = new System.Drawing.Size(244, 30);
            this.lblServerStatusValue.TabIndex = 1;
            this.lblServerStatusValue.Text = "● OFFLINE";
            this.lblServerStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblServerStatusTitle
            // 
            this.lblServerStatusTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServerStatusTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblServerStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblServerStatusTitle.Location = new System.Drawing.Point(8, 8);
            this.lblServerStatusTitle.Name = "lblServerStatusTitle";
            this.lblServerStatusTitle.Size = new System.Drawing.Size(244, 22);
            this.lblServerStatusTitle.TabIndex = 0;
            this.lblServerStatusTitle.Text = "SERVER STATUS";
            this.lblServerStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDataPort
            // 
            this.pnlDataPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlDataPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataPort.Controls.Add(this.lblDataPortValue);
            this.pnlDataPort.Controls.Add(this.lblDataPortTitle);
            this.pnlDataPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataPort.Location = new System.Drawing.Point(549, 15);
            this.pnlDataPort.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDataPort.Name = "pnlDataPort";
            this.pnlDataPort.Padding = new System.Windows.Forms.Padding(8);
            this.pnlDataPort.Size = new System.Drawing.Size(255, 70);
            this.pnlDataPort.TabIndex = 1;
            // 
            // lblDataPortValue
            // 
            this.lblDataPortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataPortValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblDataPortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblDataPortValue.Location = new System.Drawing.Point(8, 30);
            this.lblDataPortValue.Name = "lblDataPortValue";
            this.lblDataPortValue.Size = new System.Drawing.Size(237, 30);
            this.lblDataPortValue.TabIndex = 1;
            this.lblDataPortValue.Text = "-";
            this.lblDataPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataPortTitle
            // 
            this.lblDataPortTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataPortTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataPortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblDataPortTitle.Location = new System.Drawing.Point(8, 8);
            this.lblDataPortTitle.Name = "lblDataPortTitle";
            this.lblDataPortTitle.Size = new System.Drawing.Size(237, 22);
            this.lblDataPortTitle.TabIndex = 0;
            this.lblDataPortTitle.Text = "DATA PORT";
            this.lblDataPortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilePort
            // 
            this.pnlFilePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlFilePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilePort.Controls.Add(this.lblIPPlanetValue);
            this.pnlFilePort.Controls.Add(this.lblIPPlanetTitle);
            this.pnlFilePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilePort.Location = new System.Drawing.Point(814, 15);
            this.pnlFilePort.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFilePort.Name = "pnlFilePort";
            this.pnlFilePort.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFilePort.Size = new System.Drawing.Size(271, 70);
            this.pnlFilePort.TabIndex = 2;
            // 
            // lblIPPlanetValue
            // 
            this.lblIPPlanetValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIPPlanetValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblIPPlanetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblIPPlanetValue.Location = new System.Drawing.Point(8, 30);
            this.lblIPPlanetValue.Name = "lblIPPlanetValue";
            this.lblIPPlanetValue.Size = new System.Drawing.Size(253, 30);
            this.lblIPPlanetValue.TabIndex = 1;
            this.lblIPPlanetValue.Text = "-";
            this.lblIPPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIPPlanetTitle
            // 
            this.lblIPPlanetTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIPPlanetTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblIPPlanetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblIPPlanetTitle.Location = new System.Drawing.Point(8, 8);
            this.lblIPPlanetTitle.Name = "lblIPPlanetTitle";
            this.lblIPPlanetTitle.Size = new System.Drawing.Size(253, 22);
            this.lblIPPlanetTitle.TabIndex = 0;
            this.lblIPPlanetTitle.Text = "PLANET IP";
            this.lblIPPlanetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblPlanetName);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlHeader.Size = new System.Drawing.Size(1090, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanetName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblPlanetName.Location = new System.Drawing.Point(452, 6);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(624, 44);
            this.lblPlanetName.TabIndex = 1;
            this.lblPlanetName.Text = "-";
            this.lblPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TCP/IP SERVER CONTROL";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmTcpManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1114, 617);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTcpManager";
            this.Text = "TCP Server Dashboard";
            this.Load += new System.EventHandler(this.frmTcpManager_Load);
            this.pnlRoot.ResumeLayout(false);
            this.tlpCenter.ResumeLayout(false);
            this.pnlConfiguration.ResumeLayout(false);
            this.pnlConfiguration.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.pnlLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctSpaceship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlanet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpaceBackground)).EndInit();
            this.tlpStatus.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlServerStatus.ResumeLayout(false);
            this.pnlDataPort.ResumeLayout(false);
            this.pnlFilePort.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPlanetName;

        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.Panel pnlServerStatus;
        private System.Windows.Forms.Label lblServerStatusTitle;
        private System.Windows.Forms.Label lblServerStatusValue;
        private System.Windows.Forms.Panel pnlDataPort;
        private System.Windows.Forms.Label lblDataPortTitle;
        private System.Windows.Forms.Label lblDataPortValue;
        private System.Windows.Forms.Panel pnlFilePort;
        private System.Windows.Forms.Label lblIPPlanetTitle;
        private System.Windows.Forms.Label lblIPPlanetValue;

        private System.Windows.Forms.TableLayoutPanel tlpCenter;
        private System.Windows.Forms.Panel pnlConfiguration;
        private System.Windows.Forms.Label lblConfigurationTitle;
        private System.Windows.Forms.Label lblPlanetIp;
        private System.Windows.Forms.TextBox txtPlanetIp;
        private System.Windows.Forms.Label lblDataPort;
        private System.Windows.Forms.TextBox txtDataPort;
        private System.Windows.Forms.Label lblFilePort;
        private System.Windows.Forms.TextBox txtFilePort;

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblControlsTitle;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnCheckConnection;

        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.Label lblConnectionTitle;
        private System.Windows.Forms.Label lblCurrentRequest;
        private System.Windows.Forms.Label lblCurrentRequestValue;
        private System.Windows.Forms.Label lblSpaceshipIp;
        private System.Windows.Forms.Label lblSpaceshipIpValue;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblLastMessageValue;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilePortValue;
        private System.Windows.Forms.Label lblFilePortTitle;
        private System.Windows.Forms.PictureBox pctPlanet;
        private System.Windows.Forms.PictureBox pctSpaceBackground;
        private System.Windows.Forms.PictureBox pctSpaceship;
        private PACS_CustomControls.PacsConsole pcsConsoleLog;
    }
}