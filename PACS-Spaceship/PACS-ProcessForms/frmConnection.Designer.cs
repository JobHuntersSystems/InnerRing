using System;

namespace PACS_ProcessForms
{
    partial class frmConnection
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
            this.pnlBackGround = new PACS_CustomControls.CustomPanel();
            this.pacsConsole2 = new PACS_CustomControls.PacsConsole();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTopDown = new System.Windows.Forms.Panel();
            this.pnlTopRigh = new System.Windows.Forms.Panel();
            this.pnlTopFillLeft = new System.Windows.Forms.Panel();
            this.lblHeaderLeft = new System.Windows.Forms.Label();
            this.lblHeaderRight = new System.Windows.Forms.Label();
            this.pnlStatus = new PACS_CustomControls.CustomPanel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.pnlPlanetIP = new PACS_CustomControls.CustomPanel();
            this.lblPlanetIPTitle = new System.Windows.Forms.Label();
            this.lblPlanetIPValue = new System.Windows.Forms.Label();
            this.pnlDataPort = new PACS_CustomControls.CustomPanel();
            this.lblDataPortTitle = new System.Windows.Forms.Label();
            this.lblDataPortValue = new System.Windows.Forms.Label();
            this.pnlFilePort = new PACS_CustomControls.CustomPanel();
            this.lblFilePortTitle = new System.Windows.Forms.Label();
            this.lblFilePortValue = new System.Windows.Forms.Label();
            this.pnlTarget = new PACS_CustomControls.CustomPanel();
            this.lblTargetTitle = new System.Windows.Forms.Label();
            this.cmbTargetIP = new System.Windows.Forms.ComboBox();
            this.pnlConfig = new PACS_CustomControls.CustomPanel();
            this.lblConfigTitle = new System.Windows.Forms.Label();
            this.lblShipCode = new System.Windows.Forms.Label();
            this.txtShipID = new System.Windows.Forms.TextBox();
            this.lblDeliveryCode = new System.Windows.Forms.Label();
            this.txtDeliveryID = new System.Windows.Forms.TextBox();
            this.pnlControls = new PACS_CustomControls.CustomPanel();
            this.lblControlsTitle = new System.Windows.Forms.Label();
            this.btnPing = new PACS_CustomControls.ProcessButton();
            this.btnProceed = new PACS_CustomControls.ProcessButton();
            this.pnlConnection = new PACS_CustomControls.CustomPanel();
            this.lblConnTitle = new System.Windows.Forms.Label();
            this.lblLastRespTitle = new System.Windows.Forms.Label();
            this.lblLastRespValue = new System.Windows.Forms.Label();
            this.lblAuthStateTitle = new System.Windows.Forms.Label();
            this.lblAuthStateValue = new System.Windows.Forms.Label();
            this.lblSecureCoreTitle = new System.Windows.Forms.Label();
            this.lblSecureCoreValue = new System.Windows.Forms.Label();
            this.pnlBackGround.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlPlanetIP.SuspendLayout();
            this.pnlDataPort.SuspendLayout();
            this.pnlFilePort.SuspendLayout();
            this.pnlTarget.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.Angulo = 90F;
            this.pnlBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackGround.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnlBackGround.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBackGround.ColorBordeNeon = System.Drawing.Color.Red;
            this.pnlBackGround.Controls.Add(this.pacsConsole2);
            this.pnlBackGround.Controls.Add(this.panel1);
            this.pnlBackGround.Controls.Add(this.pnlStatus);
            this.pnlBackGround.Controls.Add(this.pnlPlanetIP);
            this.pnlBackGround.Controls.Add(this.pnlDataPort);
            this.pnlBackGround.Controls.Add(this.pnlFilePort);
            this.pnlBackGround.Controls.Add(this.pnlTarget);
            this.pnlBackGround.Controls.Add(this.pnlConfig);
            this.pnlBackGround.Controls.Add(this.pnlControls);
            this.pnlBackGround.Controls.Add(this.pnlConnection);
            this.pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackGround.GrosorBorde = 1;
            this.pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(980, 600);
            this.pnlBackGround.TabIndex = 0;
            // 
            // pacsConsole2
            // 
            this.pacsConsole2.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pacsConsole2.BackColor = System.Drawing.Color.Transparent;
            this.pacsConsole2.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.pacsConsole2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pacsConsole2.Location = new System.Drawing.Point(0, 393);
            this.pacsConsole2.Name = "pacsConsole2";
            this.pacsConsole2.Size = new System.Drawing.Size(980, 207);
            this.pacsConsole2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlTopDown);
            this.panel1.Controls.Add(this.pnlTopRigh);
            this.panel1.Controls.Add(this.pnlTopFillLeft);
            this.panel1.Controls.Add(this.lblHeaderLeft);
            this.panel1.Controls.Add(this.lblHeaderRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 46);
            this.panel1.TabIndex = 20;
            // 
            // pnlTopDown
            // 
            this.pnlTopDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTopDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopDown.Location = new System.Drawing.Point(20, 44);
            this.pnlTopDown.Name = "pnlTopDown";
            this.pnlTopDown.Size = new System.Drawing.Size(940, 2);
            this.pnlTopDown.TabIndex = 16;
            // 
            // pnlTopRigh
            // 
            this.pnlTopRigh.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRigh.Location = new System.Drawing.Point(960, 0);
            this.pnlTopRigh.Name = "pnlTopRigh";
            this.pnlTopRigh.Size = new System.Drawing.Size(20, 46);
            this.pnlTopRigh.TabIndex = 15;
            // 
            // pnlTopFillLeft
            // 
            this.pnlTopFillLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopFillLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFillLeft.Name = "pnlTopFillLeft";
            this.pnlTopFillLeft.Size = new System.Drawing.Size(20, 46);
            this.pnlTopFillLeft.TabIndex = 14;
            // 
            // lblHeaderLeft
            // 
            this.lblHeaderLeft.AutoSize = true;
            this.lblHeaderLeft.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblHeaderLeft.Location = new System.Drawing.Point(20, 10);
            this.lblHeaderLeft.Name = "lblHeaderLeft";
            this.lblHeaderLeft.Size = new System.Drawing.Size(264, 26);
            this.lblHeaderLeft.TabIndex = 12;
            this.lblHeaderLeft.Text = "///SPACESHIP COMMLINK";
            // 
            // lblHeaderRight
            // 
            this.lblHeaderRight.AutoSize = true;
            this.lblHeaderRight.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblHeaderRight.Location = new System.Drawing.Point(586, 17);
            this.lblHeaderRight.Name = "lblHeaderRight";
            this.lblHeaderRight.Size = new System.Drawing.Size(320, 17);
            this.lblHeaderRight.TabIndex = 13;
            this.lblHeaderRight.Text = "PACS CLIENT MODULE  |  AWAITING COMMAND";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Angulo = 135F;
            this.pnlStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatus.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.pnlStatus.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.pnlStatus.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlStatus.Controls.Add(this.lblStatusTitle);
            this.pnlStatus.Controls.Add(this.lblStatusValue);
            this.pnlStatus.GrosorBorde = 1;
            this.pnlStatus.Location = new System.Drawing.Point(20, 66);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(220, 70);
            this.pnlStatus.TabIndex = 12;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblStatusTitle.Location = new System.Drawing.Point(0, 10);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(220, 20);
            this.lblStatusTitle.TabIndex = 0;
            this.lblStatusTitle.Text = "UPLINK STATUS";
            this.lblStatusTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatusValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.lblStatusValue.Location = new System.Drawing.Point(0, 35);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(220, 25);
            this.lblStatusValue.TabIndex = 1;
            this.lblStatusValue.Text = "● DISCONNECTED";
            this.lblStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPlanetIP
            // 
            this.pnlPlanetIP.Angulo = 90F;
            this.pnlPlanetIP.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlanetIP.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlPlanetIP.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlPlanetIP.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlPlanetIP.Controls.Add(this.lblPlanetIPTitle);
            this.pnlPlanetIP.Controls.Add(this.lblPlanetIPValue);
            this.pnlPlanetIP.GrosorBorde = 1;
            this.pnlPlanetIP.Location = new System.Drawing.Point(260, 66);
            this.pnlPlanetIP.Name = "pnlPlanetIP";
            this.pnlPlanetIP.Size = new System.Drawing.Size(220, 70);
            this.pnlPlanetIP.TabIndex = 15;
            // 
            // lblPlanetIPTitle
            // 
            this.lblPlanetIPTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlanetIPTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblPlanetIPTitle.Location = new System.Drawing.Point(0, 10);
            this.lblPlanetIPTitle.Name = "lblPlanetIPTitle";
            this.lblPlanetIPTitle.Size = new System.Drawing.Size(220, 20);
            this.lblPlanetIPTitle.TabIndex = 0;
            this.lblPlanetIPTitle.Text = "TARGET PLANET IP";
            this.lblPlanetIPTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlanetIPValue
            // 
            this.lblPlanetIPValue.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlanetIPValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblPlanetIPValue.Location = new System.Drawing.Point(0, 35);
            this.lblPlanetIPValue.Name = "lblPlanetIPValue";
            this.lblPlanetIPValue.Size = new System.Drawing.Size(220, 25);
            this.lblPlanetIPValue.TabIndex = 1;
            this.lblPlanetIPValue.Text = "0.0.0.0";
            this.lblPlanetIPValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDataPort
            // 
            this.pnlDataPort.Angulo = 90F;
            this.pnlDataPort.BackColor = System.Drawing.Color.Transparent;
            this.pnlDataPort.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlDataPort.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlDataPort.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlDataPort.Controls.Add(this.lblDataPortTitle);
            this.pnlDataPort.Controls.Add(this.lblDataPortValue);
            this.pnlDataPort.GrosorBorde = 1;
            this.pnlDataPort.Location = new System.Drawing.Point(500, 66);
            this.pnlDataPort.Name = "pnlDataPort";
            this.pnlDataPort.Size = new System.Drawing.Size(220, 70);
            this.pnlDataPort.TabIndex = 14;
            // 
            // lblDataPortTitle
            // 
            this.lblDataPortTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblDataPortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblDataPortTitle.Location = new System.Drawing.Point(0, 10);
            this.lblDataPortTitle.Name = "lblDataPortTitle";
            this.lblDataPortTitle.Size = new System.Drawing.Size(220, 20);
            this.lblDataPortTitle.TabIndex = 0;
            this.lblDataPortTitle.Text = "DATA PORT";
            this.lblDataPortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataPortValue
            // 
            this.lblDataPortValue.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblDataPortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblDataPortValue.Location = new System.Drawing.Point(0, 35);
            this.lblDataPortValue.Name = "lblDataPortValue";
            this.lblDataPortValue.Size = new System.Drawing.Size(220, 25);
            this.lblDataPortValue.TabIndex = 1;
            this.lblDataPortValue.Text = "--";
            this.lblDataPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFilePort
            // 
            this.pnlFilePort.Angulo = 90F;
            this.pnlFilePort.BackColor = System.Drawing.Color.Transparent;
            this.pnlFilePort.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlFilePort.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlFilePort.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlFilePort.Controls.Add(this.lblFilePortTitle);
            this.pnlFilePort.Controls.Add(this.lblFilePortValue);
            this.pnlFilePort.GrosorBorde = 1;
            this.pnlFilePort.Location = new System.Drawing.Point(740, 66);
            this.pnlFilePort.Name = "pnlFilePort";
            this.pnlFilePort.Size = new System.Drawing.Size(220, 70);
            this.pnlFilePort.TabIndex = 13;
            // 
            // lblFilePortTitle
            // 
            this.lblFilePortTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblFilePortTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblFilePortTitle.Location = new System.Drawing.Point(0, 10);
            this.lblFilePortTitle.Name = "lblFilePortTitle";
            this.lblFilePortTitle.Size = new System.Drawing.Size(220, 20);
            this.lblFilePortTitle.TabIndex = 0;
            this.lblFilePortTitle.Text = "FILE PORT";
            this.lblFilePortTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilePortValue
            // 
            this.lblFilePortValue.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilePortValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblFilePortValue.Location = new System.Drawing.Point(0, 35);
            this.lblFilePortValue.Name = "lblFilePortValue";
            this.lblFilePortValue.Size = new System.Drawing.Size(220, 25);
            this.lblFilePortValue.TabIndex = 1;
            this.lblFilePortValue.Text = "--";
            this.lblFilePortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTarget
            // 
            this.pnlTarget.Angulo = 90F;
            this.pnlTarget.BackColor = System.Drawing.Color.Transparent;
            this.pnlTarget.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlTarget.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlTarget.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlTarget.Controls.Add(this.lblTargetTitle);
            this.pnlTarget.Controls.Add(this.cmbTargetIP);
            this.pnlTarget.GrosorBorde = 1;
            this.pnlTarget.Location = new System.Drawing.Point(20, 156);
            this.pnlTarget.Name = "pnlTarget";
            this.pnlTarget.Size = new System.Drawing.Size(300, 90);
            this.pnlTarget.TabIndex = 16;
            // 
            // lblTargetTitle
            // 
            this.lblTargetTitle.AutoSize = true;
            this.lblTargetTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblTargetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblTargetTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTargetTitle.Name = "lblTargetTitle";
            this.lblTargetTitle.Size = new System.Drawing.Size(136, 17);
            this.lblTargetTitle.TabIndex = 0;
            this.lblTargetTitle.Text = "///TARGET PLANET";
            // 
            // cmbTargetIP
            // 
            this.cmbTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.cmbTargetIP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetIP.Font = new System.Drawing.Font("Consolas", 11F);
            this.cmbTargetIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.cmbTargetIP.FormattingEnabled = true;
            this.cmbTargetIP.Location = new System.Drawing.Point(20, 45);
            this.cmbTargetIP.Name = "cmbTargetIP";
            this.cmbTargetIP.Size = new System.Drawing.Size(250, 26);
            this.cmbTargetIP.TabIndex = 1;
            this.cmbTargetIP.SelectedIndexChanged += new System.EventHandler(this.cmbTargetIP_SelectedIndexChanged);
            // 
            // pnlConfig
            // 
            this.pnlConfig.Angulo = 90F;
            this.pnlConfig.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfig.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlConfig.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlConfig.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlConfig.Controls.Add(this.lblConfigTitle);
            this.pnlConfig.Controls.Add(this.lblShipCode);
            this.pnlConfig.Controls.Add(this.txtShipID);
            this.pnlConfig.Controls.Add(this.lblDeliveryCode);
            this.pnlConfig.Controls.Add(this.txtDeliveryID);
            this.pnlConfig.GrosorBorde = 1;
            this.pnlConfig.Location = new System.Drawing.Point(20, 256);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(300, 120);
            this.pnlConfig.TabIndex = 21;
            // 
            // lblConfigTitle
            // 
            this.lblConfigTitle.AutoSize = true;
            this.lblConfigTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfigTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblConfigTitle.Location = new System.Drawing.Point(20, 15);
            this.lblConfigTitle.Name = "lblConfigTitle";
            this.lblConfigTitle.Size = new System.Drawing.Size(160, 17);
            this.lblConfigTitle.TabIndex = 0;
            this.lblConfigTitle.Text = "///SHIP CREDENTIALS";
            // 
            // lblShipCode
            // 
            this.lblShipCode.AutoSize = true;
            this.lblShipCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblShipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblShipCode.Location = new System.Drawing.Point(20, 45);
            this.lblShipCode.Name = "lblShipCode";
            this.lblShipCode.Size = new System.Drawing.Size(80, 17);
            this.lblShipCode.TabIndex = 1;
            this.lblShipCode.Text = "SPACESHIP";
            // 
            // txtShipID
            // 
            this.txtShipID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtShipID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShipID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShipID.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtShipID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtShipID.Location = new System.Drawing.Point(130, 42);
            this.txtShipID.MaxLength = 12;
            this.txtShipID.Name = "txtShipID";
            this.txtShipID.Size = new System.Drawing.Size(140, 25);
            this.txtShipID.TabIndex = 2;
            this.txtShipID.Text = "FALCON000001";
            // 
            // lblDeliveryCode
            // 
            this.lblDeliveryCode.AutoSize = true;
            this.lblDeliveryCode.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblDeliveryCode.Location = new System.Drawing.Point(20, 85);
            this.lblDeliveryCode.Name = "lblDeliveryCode";
            this.lblDeliveryCode.Size = new System.Drawing.Size(96, 17);
            this.lblDeliveryCode.TabIndex = 3;
            this.lblDeliveryCode.Text = "DELIVERY ID";
            // 
            // txtDeliveryID
            // 
            this.txtDeliveryID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtDeliveryID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeliveryID.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtDeliveryID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtDeliveryID.Location = new System.Drawing.Point(130, 82);
            this.txtDeliveryID.MaxLength = 12;
            this.txtDeliveryID.Name = "txtDeliveryID";
            this.txtDeliveryID.Size = new System.Drawing.Size(140, 25);
            this.txtDeliveryID.TabIndex = 4;
            this.txtDeliveryID.Text = "DEL000000001";
            // 
            // pnlControls
            // 
            this.pnlControls.Angulo = 90F;
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlControls.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlControls.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlControls.Controls.Add(this.lblControlsTitle);
            this.pnlControls.Controls.Add(this.btnPing);
            this.pnlControls.Controls.Add(this.btnProceed);
            this.pnlControls.GrosorBorde = 1;
            this.pnlControls.Location = new System.Drawing.Point(340, 156);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(320, 220);
            this.pnlControls.TabIndex = 17;
            // 
            // lblControlsTitle
            // 
            this.lblControlsTitle.AutoSize = true;
            this.lblControlsTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblControlsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblControlsTitle.Location = new System.Drawing.Point(20, 15);
            this.lblControlsTitle.Name = "lblControlsTitle";
            this.lblControlsTitle.Size = new System.Drawing.Size(152, 17);
            this.lblControlsTitle.TabIndex = 0;
            this.lblControlsTitle.Text = "///UPLINK CONTROLS";
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.Transparent;
            this.btnPing.ButtonText = "1. PING PLANET";
            this.btnPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPing.Location = new System.Drawing.Point(23, 48);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(270, 40);
            this.btnPing.TabIndex = 1;
            this.btnPing.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.Transparent;
            this.btnProceed.ButtonText = "2. SEND REQ (ER)";
            this.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProceed.Location = new System.Drawing.Point(23, 100);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(270, 40);
            this.btnProceed.TabIndex = 2;
            this.btnProceed.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // pnlConnection
            // 
            this.pnlConnection.Angulo = 90F;
            this.pnlConnection.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnection.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlConnection.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlConnection.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlConnection.Controls.Add(this.lblConnTitle);
            this.pnlConnection.Controls.Add(this.lblLastRespTitle);
            this.pnlConnection.Controls.Add(this.lblLastRespValue);
            this.pnlConnection.Controls.Add(this.lblAuthStateTitle);
            this.pnlConnection.Controls.Add(this.lblAuthStateValue);
            this.pnlConnection.Controls.Add(this.lblSecureCoreTitle);
            this.pnlConnection.Controls.Add(this.lblSecureCoreValue);
            this.pnlConnection.GrosorBorde = 1;
            this.pnlConnection.Location = new System.Drawing.Point(680, 156);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(280, 220);
            this.pnlConnection.TabIndex = 18;
            // 
            // lblConnTitle
            // 
            this.lblConnTitle.AutoSize = true;
            this.lblConnTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblConnTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblConnTitle.Location = new System.Drawing.Point(20, 15);
            this.lblConnTitle.Name = "lblConnTitle";
            this.lblConnTitle.Size = new System.Drawing.Size(168, 17);
            this.lblConnTitle.TabIndex = 0;
            this.lblConnTitle.Text = "///VALIDATION STATUS";
            // 
            // lblLastRespTitle
            // 
            this.lblLastRespTitle.AutoSize = true;
            this.lblLastRespTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastRespTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblLastRespTitle.Location = new System.Drawing.Point(20, 70);
            this.lblLastRespTitle.Name = "lblLastRespTitle";
            this.lblLastRespTitle.Size = new System.Drawing.Size(112, 17);
            this.lblLastRespTitle.TabIndex = 1;
            this.lblLastRespTitle.Text = "LAST RESPONSE";
            // 
            // lblLastRespValue
            // 
            this.lblLastRespValue.AutoSize = true;
            this.lblLastRespValue.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblLastRespValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.lblLastRespValue.Location = new System.Drawing.Point(160, 70);
            this.lblLastRespValue.Name = "lblLastRespValue";
            this.lblLastRespValue.Size = new System.Drawing.Size(24, 18);
            this.lblLastRespValue.TabIndex = 2;
            this.lblLastRespValue.Text = "--";
            // 
            // lblAuthStateTitle
            // 
            this.lblAuthStateTitle.AutoSize = true;
            this.lblAuthStateTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblAuthStateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblAuthStateTitle.Location = new System.Drawing.Point(20, 120);
            this.lblAuthStateTitle.Name = "lblAuthStateTitle";
            this.lblAuthStateTitle.Size = new System.Drawing.Size(88, 17);
            this.lblAuthStateTitle.TabIndex = 3;
            this.lblAuthStateTitle.Text = "AUTH STATE";
            // 
            // lblAuthStateValue
            // 
            this.lblAuthStateValue.AutoSize = true;
            this.lblAuthStateValue.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblAuthStateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblAuthStateValue.Location = new System.Drawing.Point(160, 120);
            this.lblAuthStateValue.Name = "lblAuthStateValue";
            this.lblAuthStateValue.Size = new System.Drawing.Size(24, 18);
            this.lblAuthStateValue.TabIndex = 4;
            this.lblAuthStateValue.Text = "--";
            // 
            // lblSecureCoreTitle
            // 
            this.lblSecureCoreTitle.AutoSize = true;
            this.lblSecureCoreTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecureCoreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblSecureCoreTitle.Location = new System.Drawing.Point(20, 170);
            this.lblSecureCoreTitle.Name = "lblSecureCoreTitle";
            this.lblSecureCoreTitle.Size = new System.Drawing.Size(96, 17);
            this.lblSecureCoreTitle.TabIndex = 5;
            this.lblSecureCoreTitle.Text = "SECURE CORE";
            // 
            // lblSecureCoreValue
            // 
            this.lblSecureCoreValue.AutoSize = true;
            this.lblSecureCoreValue.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblSecureCoreValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblSecureCoreValue.Location = new System.Drawing.Point(160, 170);
            this.lblSecureCoreValue.Name = "lblSecureCoreValue";
            this.lblSecureCoreValue.Size = new System.Drawing.Size(40, 18);
            this.lblSecureCoreValue.TabIndex = 6;
            this.lblSecureCoreValue.Text = "SYNC";
            // 
            // frmConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(980, 600);
            this.Controls.Add(this.pnlBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConnection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpaceShip Client - Cyberpunk Interface";
            this.pnlBackGround.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlPlanetIP.ResumeLayout(false);
            this.pnlDataPort.ResumeLayout(false);
            this.pnlFilePort.ResumeLayout(false);
            this.pnlTarget.ResumeLayout(false);
            this.pnlTarget.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.pnlConfig.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PACS_CustomControls.CustomPanel pnlBackGround;
        private PACS_CustomControls.PacsConsole pacsConsole1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTopDown;
        private System.Windows.Forms.Panel pnlTopRigh;
        private System.Windows.Forms.Panel pnlTopFillLeft;
        private System.Windows.Forms.Label lblHeaderLeft;
        private System.Windows.Forms.Label lblHeaderRight;

        private PACS_CustomControls.CustomPanel pnlStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatusValue;

        private PACS_CustomControls.CustomPanel pnlPlanetIP;
        private System.Windows.Forms.Label lblPlanetIPTitle;
        private System.Windows.Forms.Label lblPlanetIPValue;

        private PACS_CustomControls.CustomPanel pnlDataPort;
        private System.Windows.Forms.Label lblDataPortTitle;
        private System.Windows.Forms.Label lblDataPortValue;

        private PACS_CustomControls.CustomPanel pnlFilePort;
        private System.Windows.Forms.Label lblFilePortTitle;
        private System.Windows.Forms.Label lblFilePortValue;

        // Panel de Selección de Planeta (NUEVO)
        private PACS_CustomControls.CustomPanel pnlTarget;
        private System.Windows.Forms.Label lblTargetTitle;
        private System.Windows.Forms.ComboBox cmbTargetIP;

        // Panel de Configuración/Credenciales de la Nave
        private PACS_CustomControls.CustomPanel pnlConfig;
        private System.Windows.Forms.Label lblConfigTitle;
        private System.Windows.Forms.Label lblShipCode;
        private System.Windows.Forms.TextBox txtShipID;
        private System.Windows.Forms.Label lblDeliveryCode;
        private System.Windows.Forms.TextBox txtDeliveryID;

        private PACS_CustomControls.CustomPanel pnlControls;
        private System.Windows.Forms.Label lblControlsTitle;
        private PACS_CustomControls.ProcessButton btnPing;
        private PACS_CustomControls.ProcessButton btnProceed;

        private PACS_CustomControls.CustomPanel pnlConnection;
        private System.Windows.Forms.Label lblConnTitle;
        private System.Windows.Forms.Label lblLastRespTitle;
        private System.Windows.Forms.Label lblLastRespValue;
        private System.Windows.Forms.Label lblAuthStateTitle;
        private System.Windows.Forms.Label lblAuthStateValue;
        private System.Windows.Forms.Label lblSecureCoreTitle;
        private System.Windows.Forms.Label lblSecureCoreValue;
        private PACS_CustomControls.PacsConsole pacsConsole2;
    }
}