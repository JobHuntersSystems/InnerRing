namespace TcpServer
{
    partial class frmTcpServerDashboard
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
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.lblControlsTitle = new System.Windows.Forms.Label();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.lblLastMessageValue = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblClientIpValue = new System.Windows.Forms.Label();
            this.lblClientIp = new System.Windows.Forms.Label();
            this.lblCurrentRequestValue = new System.Windows.Forms.Label();
            this.lblCurrentRequest = new System.Windows.Forms.Label();
            this.lblConnectionTitle = new System.Windows.Forms.Label();
            this.pnlLog = new System.Windows.Forms.Panel();
            this.pcsConsoleLog = new PACS_CustomControls.PacsConsole();
            this.tlpStatus = new System.Windows.Forms.TableLayoutPanel();
            this.pnlServerStatus = new System.Windows.Forms.Panel();
            this.lblServerStatusValue = new System.Windows.Forms.Label();
            this.lblServerStatusTitle = new System.Windows.Forms.Label();
            this.pnlDataPort = new System.Windows.Forms.Panel();
            this.lblDataPortValue = new System.Windows.Forms.Label();
            this.lblDataPortTitle = new System.Windows.Forms.Label();
            this.pnlFilePort = new System.Windows.Forms.Panel();
            this.lblFilePortValue = new System.Windows.Forms.Label();
            this.lblFilePortTitle = new System.Windows.Forms.Label();
            this.pnlConnections = new System.Windows.Forms.Panel();
            this.lblConnectionsValue = new System.Windows.Forms.Label();
            this.lblConnectionsTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlRoot.SuspendLayout();
            this.tlpCenter.SuspendLayout();
            this.pnlConfiguration.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlConnection.SuspendLayout();
            this.pnlLog.SuspendLayout();
            this.tlpStatus.SuspendLayout();
            this.pnlServerStatus.SuspendLayout();
            this.pnlDataPort.SuspendLayout();
            this.pnlFilePort.SuspendLayout();
            this.pnlConnections.SuspendLayout();
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
            this.pnlRoot.Size = new System.Drawing.Size(985, 617);
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
            this.tlpCenter.Size = new System.Drawing.Size(961, 255);
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
            this.pnlConfiguration.Size = new System.Drawing.Size(316, 228);
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
            this.txtFilePort.Text = "5051";
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
            this.txtDataPort.Text = "5050";
            // 
            // txtPlanetIp
            // 
            this.txtPlanetIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(8)))));
            this.txtPlanetIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanetIp.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtPlanetIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.txtPlanetIp.Location = new System.Drawing.Point(130, 51);
            this.txtPlanetIp.Name = "txtPlanetIp";
            this.txtPlanetIp.Size = new System.Drawing.Size(150, 23);
            this.txtPlanetIp.TabIndex = 2;
            this.txtPlanetIp.Text = "127.0.0.1";
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
            this.pnlControls.Controls.Add(this.btnClearLog);
            this.pnlControls.Controls.Add(this.btnCheckConnection);
            this.pnlControls.Controls.Add(this.btnStopServer);
            this.pnlControls.Controls.Add(this.btnStartServer);
            this.pnlControls.Controls.Add(this.lblControlsTitle);
            this.pnlControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(331, 13);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(5);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(14);
            this.pnlControls.Size = new System.Drawing.Size(297, 228);
            this.pnlControls.TabIndex = 1;
            // 
            // btnClearLog
            // 
            this.btnClearLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnClearLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.btnClearLog.FlatAppearance.BorderSize = 2;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.btnClearLog.Location = new System.Drawing.Point(20, 164);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(250, 32);
            this.btnClearLog.TabIndex = 4;
            this.btnClearLog.Text = "CLEAR TCP LOG";
            this.btnClearLog.UseVisualStyleBackColor = false;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnCheckConnection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCheckConnection.FlatAppearance.BorderSize = 2;
            this.btnCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckConnection.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCheckConnection.Location = new System.Drawing.Point(20, 126);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(250, 32);
            this.btnCheckConnection.TabIndex = 3;
            this.btnCheckConnection.Text = "CHECK CONNECTION";
            this.btnCheckConnection.UseVisualStyleBackColor = false;
            // 
            // btnStopServer
            // 
            this.btnStopServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnStopServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStopServer.FlatAppearance.BorderSize = 2;
            this.btnStopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnStopServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnStopServer.Location = new System.Drawing.Point(20, 88);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(250, 32);
            this.btnStopServer.TabIndex = 2;
            this.btnStopServer.Text = "STOP TCP SERVER";
            this.btnStopServer.UseVisualStyleBackColor = false;
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnStartServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.btnStartServer.FlatAppearance.BorderSize = 2;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnStartServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.btnStartServer.Location = new System.Drawing.Point(20, 50);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(250, 32);
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
            this.pnlConnection.Controls.Add(this.lblClientIpValue);
            this.pnlConnection.Controls.Add(this.lblClientIp);
            this.pnlConnection.Controls.Add(this.lblCurrentRequestValue);
            this.pnlConnection.Controls.Add(this.lblCurrentRequest);
            this.pnlConnection.Controls.Add(this.lblConnectionTitle);
            this.pnlConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConnection.Location = new System.Drawing.Point(638, 13);
            this.pnlConnection.Margin = new System.Windows.Forms.Padding(5);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Padding = new System.Windows.Forms.Padding(14);
            this.pnlConnection.Size = new System.Drawing.Size(318, 228);
            this.pnlConnection.TabIndex = 2;
            // 
            // lblLastMessageValue
            // 
            this.lblLastMessageValue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastMessageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblLastMessageValue.Location = new System.Drawing.Point(145, 127);
            this.lblLastMessageValue.Name = "lblLastMessageValue";
            this.lblLastMessageValue.Size = new System.Drawing.Size(150, 20);
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
            // lblClientIpValue
            // 
            this.lblClientIpValue.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblClientIpValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblClientIpValue.Location = new System.Drawing.Point(145, 89);
            this.lblClientIpValue.Name = "lblClientIpValue";
            this.lblClientIpValue.Size = new System.Drawing.Size(150, 20);
            this.lblClientIpValue.TabIndex = 4;
            this.lblClientIpValue.Text = "--";
            this.lblClientIpValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClientIp
            // 
            this.lblClientIp.AutoSize = true;
            this.lblClientIp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblClientIp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblClientIp.Location = new System.Drawing.Point(17, 92);
            this.lblClientIp.Name = "lblClientIp";
            this.lblClientIp.Size = new System.Drawing.Size(70, 14);
            this.lblClientIp.TabIndex = 3;
            this.lblClientIp.Text = "CLIENT IP";
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
            this.lblConnectionTitle.Size = new System.Drawing.Size(152, 18);
            this.lblConnectionTitle.TabIndex = 0;
            this.lblConnectionTitle.Text = "CURRENT CONNECTION";
            // 
            // pnlLog
            // 
            this.pnlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.pnlLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLog.Controls.Add(this.pcsConsoleLog);
            this.pnlLog.Location = new System.Drawing.Point(12, 415);
            this.pnlLog.Name = "pnlLog";
            this.pnlLog.Padding = new System.Windows.Forms.Padding(14, 32, 14, 14);
            this.pnlLog.Size = new System.Drawing.Size(957, 190);
            this.pnlLog.TabIndex = 3;
            // 
            // pcsConsoleLog
            // 
            this.pcsConsoleLog.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.pcsConsoleLog.BackColor = System.Drawing.Color.Transparent;
            this.pcsConsoleLog.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.pcsConsoleLog.Location = new System.Drawing.Point(2, -1);
            this.pcsConsoleLog.Name = "pcsConsoleLog";
            this.pcsConsoleLog.Size = new System.Drawing.Size(953, 187);
            this.pcsConsoleLog.TabIndex = 0;
            // 
            // tlpStatus
            // 
            this.tlpStatus.ColumnCount = 4;
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpStatus.Controls.Add(this.pnlServerStatus, 0, 0);
            this.tlpStatus.Controls.Add(this.pnlDataPort, 1, 0);
            this.tlpStatus.Controls.Add(this.pnlFilePort, 2, 0);
            this.tlpStatus.Controls.Add(this.pnlConnections, 3, 0);
            this.tlpStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpStatus.Location = new System.Drawing.Point(12, 70);
            this.tlpStatus.Name = "tlpStatus";
            this.tlpStatus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 6);
            this.tlpStatus.RowCount = 1;
            this.tlpStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStatus.Size = new System.Drawing.Size(961, 96);
            this.tlpStatus.TabIndex = 1;
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
            this.pnlServerStatus.Size = new System.Drawing.Size(230, 70);
            this.pnlServerStatus.TabIndex = 0;
            // 
            // lblServerStatusValue
            // 
            this.lblServerStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblServerStatusValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblServerStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblServerStatusValue.Location = new System.Drawing.Point(8, 30);
            this.lblServerStatusValue.Name = "lblServerStatusValue";
            this.lblServerStatusValue.Size = new System.Drawing.Size(212, 30);
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
            this.lblServerStatusTitle.Size = new System.Drawing.Size(212, 22);
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
            this.pnlDataPort.Location = new System.Drawing.Point(245, 15);
            this.pnlDataPort.Margin = new System.Windows.Forms.Padding(5);
            this.pnlDataPort.Name = "pnlDataPort";
            this.pnlDataPort.Padding = new System.Windows.Forms.Padding(8);
            this.pnlDataPort.Size = new System.Drawing.Size(230, 70);
            this.pnlDataPort.TabIndex = 1;
            // 
            // lblDataPortValue
            // 
            this.lblDataPortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataPortValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblDataPortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblDataPortValue.Location = new System.Drawing.Point(8, 30);
            this.lblDataPortValue.Name = "lblDataPortValue";
            this.lblDataPortValue.Size = new System.Drawing.Size(212, 30);
            this.lblDataPortValue.TabIndex = 1;
            this.lblDataPortValue.Text = "5050";
            this.lblDataPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataPortTitle
            // 
            this.lblDataPortTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataPortTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblDataPortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblDataPortTitle.Location = new System.Drawing.Point(8, 8);
            this.lblDataPortTitle.Name = "lblDataPortTitle";
            this.lblDataPortTitle.Size = new System.Drawing.Size(212, 22);
            this.lblDataPortTitle.TabIndex = 0;
            this.lblDataPortTitle.Text = "DATA PORT";
            this.lblDataPortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilePort
            // 
            this.pnlFilePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlFilePort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilePort.Controls.Add(this.lblFilePortValue);
            this.pnlFilePort.Controls.Add(this.lblFilePortTitle);
            this.pnlFilePort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilePort.Location = new System.Drawing.Point(485, 15);
            this.pnlFilePort.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFilePort.Name = "pnlFilePort";
            this.pnlFilePort.Padding = new System.Windows.Forms.Padding(8);
            this.pnlFilePort.Size = new System.Drawing.Size(230, 70);
            this.pnlFilePort.TabIndex = 2;
            // 
            // lblFilePortValue
            // 
            this.lblFilePortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilePortValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblFilePortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblFilePortValue.Location = new System.Drawing.Point(8, 30);
            this.lblFilePortValue.Name = "lblFilePortValue";
            this.lblFilePortValue.Size = new System.Drawing.Size(212, 30);
            this.lblFilePortValue.TabIndex = 1;
            this.lblFilePortValue.Text = "5051";
            this.lblFilePortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilePortTitle
            // 
            this.lblFilePortTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilePortTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilePortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblFilePortTitle.Location = new System.Drawing.Point(8, 8);
            this.lblFilePortTitle.Name = "lblFilePortTitle";
            this.lblFilePortTitle.Size = new System.Drawing.Size(212, 22);
            this.lblFilePortTitle.TabIndex = 0;
            this.lblFilePortTitle.Text = "FILE PORT";
            this.lblFilePortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlConnections
            // 
            this.pnlConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(22)))));
            this.pnlConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConnections.Controls.Add(this.lblConnectionsValue);
            this.pnlConnections.Controls.Add(this.lblConnectionsTitle);
            this.pnlConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConnections.Location = new System.Drawing.Point(725, 15);
            this.pnlConnections.Margin = new System.Windows.Forms.Padding(5);
            this.pnlConnections.Name = "pnlConnections";
            this.pnlConnections.Padding = new System.Windows.Forms.Padding(8);
            this.pnlConnections.Size = new System.Drawing.Size(231, 70);
            this.pnlConnections.TabIndex = 3;
            // 
            // lblConnectionsValue
            // 
            this.lblConnectionsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConnectionsValue.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblConnectionsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.lblConnectionsValue.Location = new System.Drawing.Point(8, 30);
            this.lblConnectionsValue.Name = "lblConnectionsValue";
            this.lblConnectionsValue.Size = new System.Drawing.Size(213, 30);
            this.lblConnectionsValue.TabIndex = 1;
            this.lblConnectionsValue.Text = "0";
            this.lblConnectionsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConnectionsTitle
            // 
            this.lblConnectionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblConnectionsTitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblConnectionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.lblConnectionsTitle.Location = new System.Drawing.Point(8, 8);
            this.lblConnectionsTitle.Name = "lblConnectionsTitle";
            this.lblConnectionsTitle.Size = new System.Drawing.Size(213, 22);
            this.lblConnectionsTitle.TabIndex = 0;
            this.lblConnectionsTitle.Text = "ACTIVE CONNECTIONS";
            this.lblConnectionsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(9)))), ((int)(((byte)(14)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.pnlHeader.Size = new System.Drawing.Size(961, 58);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(452, 6);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(495, 44);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "PLANET LISTENER MODULE  |  WAITING FOR OPERATOR";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // frmTcpServerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(985, 617);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTcpServerDashboard";
            this.Text = "TCP Server Dashboard";
            this.pnlRoot.ResumeLayout(false);
            this.tlpCenter.ResumeLayout(false);
            this.pnlConfiguration.ResumeLayout(false);
            this.pnlConfiguration.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.pnlLog.ResumeLayout(false);
            this.tlpStatus.ResumeLayout(false);
            this.pnlServerStatus.ResumeLayout(false);
            this.pnlDataPort.ResumeLayout(false);
            this.pnlFilePort.ResumeLayout(false);
            this.pnlConnections.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.TableLayoutPanel tlpStatus;
        private System.Windows.Forms.Panel pnlServerStatus;
        private System.Windows.Forms.Label lblServerStatusTitle;
        private System.Windows.Forms.Label lblServerStatusValue;
        private System.Windows.Forms.Panel pnlDataPort;
        private System.Windows.Forms.Label lblDataPortTitle;
        private System.Windows.Forms.Label lblDataPortValue;
        private System.Windows.Forms.Panel pnlFilePort;
        private System.Windows.Forms.Label lblFilePortTitle;
        private System.Windows.Forms.Label lblFilePortValue;
        private System.Windows.Forms.Panel pnlConnections;
        private System.Windows.Forms.Label lblConnectionsTitle;
        private System.Windows.Forms.Label lblConnectionsValue;

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
        private System.Windows.Forms.Button btnClearLog;

        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.Label lblConnectionTitle;
        private System.Windows.Forms.Label lblCurrentRequest;
        private System.Windows.Forms.Label lblCurrentRequestValue;
        private System.Windows.Forms.Label lblClientIp;
        private System.Windows.Forms.Label lblClientIpValue;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblLastMessageValue;
        private System.Windows.Forms.Panel pnlLog;
        private PACS_CustomControls.PacsConsole pcsConsoleLog;
    }
}