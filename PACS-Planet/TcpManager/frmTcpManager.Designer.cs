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
            this.components = new System.ComponentModel.Container();
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
            this.lblSpaceshipIpValue = new System.Windows.Forms.Label();
            this.btnAbortProtocol = new System.Windows.Forms.Button();
            this.lblSpaceshipIp = new System.Windows.Forms.Label();
            this.lblConnectionTitle = new System.Windows.Forms.Label();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.pcsConsoleLog = new PACS_CustomControls.PacsConsole();
            this.btnAbortProtocol = new System.Windows.Forms.Button();
            this.pctSpaceship = new System.Windows.Forms.PictureBox();
            this.pctPlanet = new System.Windows.Forms.PictureBox();
            this.pctSpaceBackground = new System.Windows.Forms.PictureBox();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctDataPort = new System.Windows.Forms.PictureBox();
            this.lblFilePortValue = new System.Windows.Forms.Label();
            this.lblFilePortTitle = new System.Windows.Forms.Label();
            this.pnlServerStatus = new System.Windows.Forms.Panel();
            this.pctServerStatus = new System.Windows.Forms.PictureBox();
            this.lblServerStatusValue = new System.Windows.Forms.Label();
            this.lblServerStatusTitle = new System.Windows.Forms.Label();
            this.pnlDataPort = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblDataPortValue = new System.Windows.Forms.Label();
            this.lblDataPortTitle = new System.Windows.Forms.Label();
            this.pnlFilePort = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.lblIPPlanetValue = new System.Windows.Forms.Label();
            this.lblIPPlanetTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pacsMinimizeButton1 = new PACS_InheratedControls.PacsMinimizeButton();
            this.btnClose = new PACS_InheratedControls.PacsCloseButton();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Animation = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.pctDataPort)).BeginInit();
            this.pnlServerStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctServerStatus)).BeginInit();
            this.pnlDataPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlFilePort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlRoot.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(12);
            this.pnlRoot.Size = new System.Drawing.Size(1102, 643);
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
            this.tlpCenter.Location = new System.Drawing.Point(12, 173);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.tlpCenter.RowCount = 1;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.Size = new System.Drawing.Size(1078, 200);
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
            this.pnlConfiguration.Size = new System.Drawing.Size(356, 174);
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
            this.pnlControls.Location = new System.Drawing.Point(371, 13);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(5);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(14);
            this.pnlControls.Size = new System.Drawing.Size(334, 174);
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
            this.btnCheckConnection.Size = new System.Drawing.Size(286, 32);
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
            this.btnStopServer.Size = new System.Drawing.Size(286, 32);
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
            this.btnStartServer.Size = new System.Drawing.Size(286, 32);
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
            this.pnlConnection.Controls.Add(this.lblSpaceshipIpValue);
            this.pnlConnection.Controls.Add(this.btnAbortProtocol);
            this.pnlConnection.Controls.Add(this.lblSpaceshipIp);
            this.pnlConnection.Controls.Add(this.lblConnectionTitle);
            this.pnlConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnection.Location = new System.Drawing.Point(715, 13);
            this.pnlConnection.Margin = new System.Windows.Forms.Padding(5);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Padding = new System.Windows.Forms.Padding(14);
            this.pnlConnection.Size = new System.Drawing.Size(358, 174);
            this.pnlConnection.TabIndex = 2;
            // 
            // lblSpaceshipIpValue
            // 
            this.lblSpaceshipIpValue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpaceshipIpValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSpaceshipIpValue.Location = new System.Drawing.Point(186, 62);
            this.lblSpaceshipIpValue.Name = "lblSpaceshipIpValue";
            this.lblSpaceshipIpValue.Size = new System.Drawing.Size(150, 20);
            this.lblSpaceshipIpValue.TabIndex = 4;
            this.lblSpaceshipIpValue.Text = "--";
            this.lblSpaceshipIpValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpaceshipIpValue.Click += new System.EventHandler(this.lblSpaceshipIpValue_Click);
            // 
            // btnAbortProtocol
            // 
            this.btnAbortProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbortProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnAbortProtocol.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnAbortProtocol.FlatAppearance.BorderSize = 2;
            this.btnAbortProtocol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbortProtocol.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnAbortProtocol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAbortProtocol.Location = new System.Drawing.Point(17, 110);
            this.btnAbortProtocol.Name = "btnAbortProtocol";
            this.btnAbortProtocol.Size = new System.Drawing.Size(319, 45);
            this.btnAbortProtocol.TabIndex = 5;
            this.btnAbortProtocol.Text = "⚠️ ABORT PROTOCOL";
            this.btnAbortProtocol.UseVisualStyleBackColor = false;
            this.btnAbortProtocol.Visible = false;
            this.btnAbortProtocol.Click += new System.EventHandler(this.btnAbortProtocol_Click);
            // 
            // lblSpaceshipIp
            // 
            this.lblSpaceshipIp.AutoSize = true;
            this.lblSpaceshipIp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblSpaceshipIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblSpaceshipIp.Location = new System.Drawing.Point(86, 66);
            this.lblSpaceshipIp.Name = "lblSpaceshipIp";
            this.lblSpaceshipIp.Size = new System.Drawing.Size(91, 14);
            this.lblSpaceshipIp.TabIndex = 3;
            this.lblSpaceshipIp.Text = "SPACESHIP IP";
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
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLog.Controls.Add(this.pcsConsoleLog);
            this.pnlLog.Controls.Add(this.pctSpaceship);
            this.pnlLog.Controls.Add(this.pctPlanet);
            this.pnlLog.Controls.Add(this.pctSpaceBackground);
            this.pnlLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLog.Location = new System.Drawing.Point(12, 384);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Size = new System.Drawing.Size(1078, 247);
            this.pnlLog.TabIndex = 3;
            // 
            // pcsConsoleLog
            // 
            this.pcsConsoleLog.AccentColor = System.Drawing.Color.Yellow;
            this.pcsConsoleLog.BackColor = System.Drawing.Color.Transparent;
            this.pcsConsoleLog.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.pcsConsoleLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcsConsoleLog.Location = new System.Drawing.Point(0, 0);
            this.pcsConsoleLog.Name = "pcsConsoleLog";
            this.pcsConsoleLog.Size = new System.Drawing.Size(604, 245);
            this.pcsConsoleLog.TabIndex = 6;
            // 
            // pctSpaceship
            // 
            this.pctSpaceship.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctSpaceship.Location = new System.Drawing.Point(948, 7);
            this.pctSpaceship.Name = "pctSpaceship";
            this.pctSpaceship.Size = new System.Drawing.Size(121, 116);
            this.pctSpaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSpaceship.TabIndex = 3;
            this.pctSpaceship.TabStop = false;
            this.pctSpaceship.Visible = false;
            // 
            // pctPlanet
            // 
            this.pctPlanet.Location = new System.Drawing.Point(587, 3);
            this.pctPlanet.Name = "pctPlanet";
            this.pctPlanet.Size = new System.Drawing.Size(236, 239);
            this.pctPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPlanet.TabIndex = 1;
            this.pctPlanet.TabStop = false;
            // 
            // pctSpaceBackground
            // 
            this.pctSpaceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.pctSpaceBackground.Dock = System.Windows.Forms.DockStyle.Right;
            this.pctSpaceBackground.Image = ((System.Drawing.Image)(resources.GetObject("pctSpaceBackground.Image")));
            this.pctSpaceBackground.Location = new System.Drawing.Point(647, 0);
            this.pctSpaceBackground.Name = "pctSpaceBackground";
            this.pctSpaceBackground.Size = new System.Drawing.Size(429, 245);
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
            this.tlpStatus.Location = new System.Drawing.Point(12, 77);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 6);
            this.tlpStatus.RowCount = 1;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.Size = new System.Drawing.Size(1078, 96);
            this.tlpStatus.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pctDataPort);
            this.panel1.Controls.Add(this.lblFilePortValue);
            this.panel1.Controls.Add(this.lblFilePortTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(274, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(259, 70);
            this.panel1.TabIndex = 3;
            // 
            // pctDataPort
            // 
            this.pctDataPort.BackColor = System.Drawing.Color.Transparent;
            this.pctDataPort.Image = ((System.Drawing.Image)(resources.GetObject("pctDataPort.Image")));
            this.pctDataPort.Location = new System.Drawing.Point(17, 12);
            this.pctDataPort.Name = "pctDataPort";
            this.pctDataPort.Size = new System.Drawing.Size(58, 45);
            this.pctDataPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDataPort.TabIndex = 4;
            this.pctDataPort.TabStop = false;
            // 
            // lblFilePortValue
            // 
            this.lblFilePortValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblFilePortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblFilePortValue.Location = new System.Drawing.Point(97, 30);
            this.lblFilePortValue.Name = "lblFilePortValue";
            this.lblFilePortValue.Size = new System.Drawing.Size(155, 30);
            this.lblFilePortValue.TabIndex = 1;
            this.lblFilePortValue.Text = "-";
            this.lblFilePortValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilePortTitle
            // 
            this.lblFilePortTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilePortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblFilePortTitle.Location = new System.Drawing.Point(97, 8);
            this.lblFilePortTitle.Name = "lblFilePortTitle";
            this.lblFilePortTitle.Size = new System.Drawing.Size(155, 22);
            this.lblFilePortTitle.TabIndex = 0;
            this.lblFilePortTitle.Text = "FILE PORT";
            this.lblFilePortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlServerStatus
            // 
            this.pnlServerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlServerStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlServerStatus.Controls.Add(this.pctServerStatus);
            this.pnlServerStatus.Controls.Add(this.lblServerStatusValue);
            this.pnlServerStatus.Controls.Add(this.lblServerStatusTitle);
            this.pnlServerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServerStatus.Location = new System.Drawing.Point(5, 15);
            this.pnlServerStatus.Margin = new System.Windows.Forms.Padding(5);
            this.pnlServerStatus.Name = "pnlServerStatus";
            this.pnlServerStatus.Padding = new System.Windows.Forms.Padding(8);
            this.pnlServerStatus.Size = new System.Drawing.Size(259, 70);
            this.pnlServerStatus.TabIndex = 0;
            // 
            // pctServerStatus
            // 
            this.pctServerStatus.BackColor = System.Drawing.Color.Transparent;
            this.pctServerStatus.Image = ((System.Drawing.Image)(resources.GetObject("pctServerStatus.Image")));
            this.pctServerStatus.Location = new System.Drawing.Point(9, 10);
            this.pctServerStatus.Name = "pctServerStatus";
            this.pctServerStatus.Size = new System.Drawing.Size(53, 46);
            this.pctServerStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctServerStatus.TabIndex = 5;
            this.pctServerStatus.TabStop = false;
            // 
            // lblServerStatusValue
            // 
            this.lblServerStatusValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblServerStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblServerStatusValue.Location = new System.Drawing.Point(75, 30);
            this.lblServerStatusValue.Name = "lblServerStatusValue";
            this.lblServerStatusValue.Size = new System.Drawing.Size(153, 30);
            this.lblServerStatusValue.TabIndex = 1;
            this.lblServerStatusValue.Text = "● OFFLINE";
            this.lblServerStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblServerStatusTitle
            // 
            this.lblServerStatusTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblServerStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblServerStatusTitle.Location = new System.Drawing.Point(75, 8);
            this.lblServerStatusTitle.Name = "lblServerStatusTitle";
            this.lblServerStatusTitle.Size = new System.Drawing.Size(153, 22);
            this.lblServerStatusTitle.TabIndex = 0;
            this.lblServerStatusTitle.Text = "SERVER STATUS";
            this.lblServerStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDataPort
            // 
            this.pnlDataPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlDataPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataPort.Controls.Add(this.pictureBox2);
            this.pnlDataPort.Controls.Add(this.lblDataPortValue);
            this.pnlDataPort.Controls.Add(this.lblDataPortTitle);
            this.pnlDataPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDataPort.Location = new System.Drawing.Point(543, 15);
            this.pnlDataPort.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDataPort.Name = "pnlDataPort";
            this.pnlDataPort.Padding = new System.Windows.Forms.Padding(8);
            this.pnlDataPort.Size = new System.Drawing.Size(252, 70);
            this.pnlDataPort.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblDataPortValue
            // 
            this.lblDataPortValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblDataPortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblDataPortValue.Location = new System.Drawing.Point(98, 30);
            this.lblDataPortValue.Name = "lblDataPortValue";
            this.lblDataPortValue.Size = new System.Drawing.Size(151, 30);
            this.lblDataPortValue.TabIndex = 1;
            this.lblDataPortValue.Text = "-";
            this.lblDataPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataPortTitle
            // 
            this.lblDataPortTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataPortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblDataPortTitle.Location = new System.Drawing.Point(98, 8);
            this.lblDataPortTitle.Name = "lblDataPortTitle";
            this.lblDataPortTitle.Size = new System.Drawing.Size(154, 22);
            this.lblDataPortTitle.TabIndex = 0;
            this.lblDataPortTitle.Text = "DATA PORT";
            this.lblDataPortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilePort
            // 
            this.pnlFilePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlFilePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilePort.Controls.Add(this.pictureBox1);
            this.pnlFilePort.Controls.Add(this.btnBrowseImage);
            this.pnlFilePort.Controls.Add(this.lblIPPlanetValue);
            this.pnlFilePort.Controls.Add(this.lblIPPlanetTitle);
            this.pnlFilePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilePort.Location = new System.Drawing.Point(805, 15);
            this.pnlFilePort.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFilePort.Name = "pnlFilePort";
            this.pnlFilePort.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFilePort.Size = new System.Drawing.Size(268, 70);
            this.pnlFilePort.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.btnBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(224, 4);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(38, 21);
            this.btnBrowseImage.TabIndex = 10;
            this.btnBrowseImage.Text = "☁︎↑";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // lblIPPlanetValue
            // 
            this.lblIPPlanetValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblIPPlanetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblIPPlanetValue.Location = new System.Drawing.Point(95, 30);
            this.lblIPPlanetValue.Name = "lblIPPlanetValue";
            this.lblIPPlanetValue.Size = new System.Drawing.Size(174, 30);
            this.lblIPPlanetValue.TabIndex = 1;
            this.lblIPPlanetValue.Text = "-";
            this.lblIPPlanetValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIPPlanetTitle
            // 
            this.lblIPPlanetTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblIPPlanetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblIPPlanetTitle.Location = new System.Drawing.Point(92, 8);
            this.lblIPPlanetTitle.Name = "lblIPPlanetTitle";
            this.lblIPPlanetTitle.Size = new System.Drawing.Size(177, 22);
            this.lblIPPlanetTitle.TabIndex = 0;
            this.lblIPPlanetTitle.Text = "CURRENT PLANET IP";
            this.lblIPPlanetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.pacsMinimizeButton1);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblPlanetName);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlHeader.Size = new System.Drawing.Size(1078, 65);
            this.pnlHeader.TabIndex = 0;
            // 
            // pacsMinimizeButton1
            // 
            this.pacsMinimizeButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pacsMinimizeButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.pacsMinimizeButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pacsMinimizeButton1.DefaultClickEvent = true;
            this.pacsMinimizeButton1.FlatAppearance.BorderSize = 0;
            this.pacsMinimizeButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacsMinimizeButton1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.pacsMinimizeButton1.Location = new System.Drawing.Point(988, 4);
            this.pacsMinimizeButton1.Name = "pacsMinimizeButton1";
            this.pacsMinimizeButton1.Size = new System.Drawing.Size(41, 22);
            this.pacsMinimizeButton1.TabIndex = 8;
            this.pacsMinimizeButton1.Text = "-";
            this.pacsMinimizeButton1.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DefaultClickEvent = false;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1032, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 22);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPlanetName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblPlanetName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPlanetName.Location = new System.Drawing.Point(222, 18);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPlanetName.Size = new System.Drawing.Size(346, 27);
            this.lblPlanetName.TabIndex = 1;
            this.lblPlanetName.Text = "-";
            this.lblPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Violet;
            this.lblTitle.Location = new System.Drawing.Point(6, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TCP/IP MANAGER |";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Animation
            // 
            this.Animation.Interval = 3000;
            this.Animation.Tick += new System.EventHandler(this.Animation_Tick);
            // 
            // frmTcpManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1102, 643);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTcpManager";
            this.Text = "TCP Server Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTcpManager_FormClosing);
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
            ((System.ComponentModel.ISupportInitialize)(this.pctDataPort)).EndInit();
            this.pnlServerStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctServerStatus)).EndInit();
            this.pnlDataPort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlFilePort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label lblSpaceshipIp;
        private System.Windows.Forms.Label lblSpaceshipIpValue;
        private System.Windows.Forms.Panel pnlLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFilePortValue;
        private System.Windows.Forms.Label lblFilePortTitle;
        private System.Windows.Forms.PictureBox pctPlanet;
        private System.Windows.Forms.PictureBox pctSpaceBackground;
        private System.Windows.Forms.PictureBox pctSpaceship;
        private PACS_InheratedControls.PacsMinimizeButton pacsMinimizeButton1;
        private PACS_InheratedControls.PacsCloseButton btnClose;
        private System.Windows.Forms.PictureBox pctDataPort;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox pctServerStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAbortProtocol;
        private PACS_CustomControls.PacsConsole pcsConsoleLog;
        private System.Windows.Forms.Timer Animation;
    }
}