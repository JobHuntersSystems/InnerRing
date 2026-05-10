using System;

namespace PACS_ProcessForms
{
    partial class frmConnection
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
            this.pnlBackGround = new PACS_CustomControls.CustomPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTopDown = new System.Windows.Forms.Panel();
            this.pnlTopRigh = new System.Windows.Forms.Panel();
            this.pnlTopFillLeft = new System.Windows.Forms.Panel();
            this.lblHeaderLeft = new System.Windows.Forms.Label();
            this.lblHeaderRight = new System.Windows.Forms.Label();
            this.pacsConsole1 = new PACS_CustomControls.PacsConsole();
            this.pnlStatus = new PACS_CustomControls.CustomPanel();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.pnlFilePort = new PACS_CustomControls.CustomPanel();
            this.lblFilePortTitle = new System.Windows.Forms.Label();
            this.lblFilePortValue = new System.Windows.Forms.Label();
            this.pnlDataPort = new PACS_CustomControls.CustomPanel();
            this.lblDataPortTitle = new System.Windows.Forms.Label();
            this.lblDataPortValue = new System.Windows.Forms.Label();
            this.pnlPlanetIP = new PACS_CustomControls.CustomPanel();
            this.lblPlanetIPTitle = new System.Windows.Forms.Label();
            this.lblPlanetIPValue = new System.Windows.Forms.Label();
            this.pnlConfig = new PACS_CustomControls.CustomPanel();
            this.lblConfigTitle = new System.Windows.Forms.Label();
            this.lblConfIP = new System.Windows.Forms.Label();
            this.txtConfIP = new System.Windows.Forms.TextBox();
            this.lblConfData = new System.Windows.Forms.Label();
            this.txtConfData = new System.Windows.Forms.TextBox();
            this.lblConfFile = new System.Windows.Forms.Label();
            this.txtConfFile = new System.Windows.Forms.TextBox();
            this.pnlControls = new PACS_CustomControls.CustomPanel();
            this.lblControlsTitle = new System.Windows.Forms.Label();
            this.btnStart = new PACS_CustomControls.ProcessButton();
            this.btnStop = new PACS_CustomControls.ProcessButton();
            this.btnCheck = new PACS_CustomControls.ProcessButton();
            this.pnlConnection = new PACS_CustomControls.CustomPanel();
            this.lblConnTitle = new System.Windows.Forms.Label();
            this.lblReqTitle = new System.Windows.Forms.Label();
            this.lblReqValue = new System.Windows.Forms.Label();
            this.lblClientTitle = new System.Windows.Forms.Label();
            this.lblClientValue = new System.Windows.Forms.Label();
            this.lblMsgTitle = new System.Windows.Forms.Label();
            this.lblMsgValue = new System.Windows.Forms.Label();
            this.pnlBackGround.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.pnlFilePort.SuspendLayout();
            this.pnlDataPort.SuspendLayout();
            this.pnlPlanetIP.SuspendLayout();
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
            this.pnlBackGround.Controls.Add(this.panel1);
            this.pnlBackGround.Controls.Add(this.pacsConsole1);
            this.pnlBackGround.Controls.Add(this.pnlStatus);
            this.pnlBackGround.Controls.Add(this.pnlFilePort);
            this.pnlBackGround.Controls.Add(this.pnlDataPort);
            this.pnlBackGround.Controls.Add(this.pnlPlanetIP);
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
            this.lblHeaderLeft.Text = "TCP/IP SERVER CONTROL";
            // 
            // lblHeaderRight
            // 
            this.lblHeaderRight.AutoSize = true;
            this.lblHeaderRight.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblHeaderRight.Location = new System.Drawing.Point(576, 17);
            this.lblHeaderRight.Name = "lblHeaderRight";
            this.lblHeaderRight.Size = new System.Drawing.Size(384, 17);
            this.lblHeaderRight.TabIndex = 13;
            this.lblHeaderRight.Text = "PLANET LISTENER MODULE  |  WAITING FOR OPERATOR";
            // 
            // pacsConsole1
            // 
            this.pacsConsole1.AccentColor = System.Drawing.Color.Empty;
            this.pacsConsole1.BackColor = System.Drawing.Color.Transparent;
            this.pacsConsole1.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.pacsConsole1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pacsConsole1.Location = new System.Drawing.Point(20, 394);
            this.pacsConsole1.Name = "pacsConsole1";
            this.pacsConsole1.Size = new System.Drawing.Size(940, 190);
            this.pacsConsole1.TabIndex = 19;
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
            this.lblStatusTitle.Text = "SERVER STATUS";
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
            this.lblStatusValue.Text = "● OFFLINE";
            this.lblStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlFilePort.Location = new System.Drawing.Point(260, 66);
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
            this.lblFilePortValue.Text = "5051";
            this.lblFilePortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblDataPortValue.Text = "5050";
            this.lblDataPortValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnlPlanetIP.Location = new System.Drawing.Point(740, 66);
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
            this.lblPlanetIPTitle.Text = "SPACESHIP IP";
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
            this.lblPlanetIPValue.Text = "127.0.0.1";
            this.lblPlanetIPValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlConfig
            // 
            this.pnlConfig.Angulo = 90F;
            this.pnlConfig.BackColor = System.Drawing.Color.Transparent;
            this.pnlConfig.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlConfig.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlConfig.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlConfig.Controls.Add(this.lblConfigTitle);
            this.pnlConfig.Controls.Add(this.lblConfIP);
            this.pnlConfig.Controls.Add(this.txtConfIP);
            this.pnlConfig.Controls.Add(this.lblConfData);
            this.pnlConfig.Controls.Add(this.txtConfData);
            this.pnlConfig.Controls.Add(this.lblConfFile);
            this.pnlConfig.Controls.Add(this.txtConfFile);
            this.pnlConfig.GrosorBorde = 1;
            this.pnlConfig.Location = new System.Drawing.Point(20, 156);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Size = new System.Drawing.Size(300, 220);
            this.pnlConfig.TabIndex = 16;
            // 
            // lblConfigTitle
            // 
            this.lblConfigTitle.AutoSize = true;
            this.lblConfigTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfigTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblConfigTitle.Location = new System.Drawing.Point(20, 15);
            this.lblConfigTitle.Name = "lblConfigTitle";
            this.lblConfigTitle.Size = new System.Drawing.Size(144, 17);
            this.lblConfigTitle.TabIndex = 0;
            this.lblConfigTitle.Text = "TCP CONFIGURATION";
            // 
            // lblConfIP
            // 
            this.lblConfIP.AutoSize = true;
            this.lblConfIP.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblConfIP.Location = new System.Drawing.Point(20, 60);
            this.lblConfIP.Name = "lblConfIP";
            this.lblConfIP.Size = new System.Drawing.Size(80, 17);
            this.lblConfIP.TabIndex = 1;
            this.lblConfIP.Text = "PLANET IP";
            // 
            // txtConfIP
            // 
            this.txtConfIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtConfIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfIP.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtConfIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtConfIP.Location = new System.Drawing.Point(120, 57);
            this.txtConfIP.Name = "txtConfIP";
            this.txtConfIP.Size = new System.Drawing.Size(150, 25);
            this.txtConfIP.TabIndex = 2;
            this.txtConfIP.Text = "127.0.0.1";
            // 
            // lblConfData
            // 
            this.lblConfData.AutoSize = true;
            this.lblConfData.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblConfData.Location = new System.Drawing.Point(20, 110);
            this.lblConfData.Name = "lblConfData";
            this.lblConfData.Size = new System.Drawing.Size(80, 17);
            this.lblConfData.TabIndex = 3;
            this.lblConfData.Text = "DATA PORT";
            // 
            // txtConfData
            // 
            this.txtConfData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtConfData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfData.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtConfData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtConfData.Location = new System.Drawing.Point(120, 107);
            this.txtConfData.Name = "txtConfData";
            this.txtConfData.Size = new System.Drawing.Size(150, 25);
            this.txtConfData.TabIndex = 4;
            this.txtConfData.Text = "5050";
            // 
            // lblConfFile
            // 
            this.lblConfFile.AutoSize = true;
            this.lblConfFile.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblConfFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblConfFile.Location = new System.Drawing.Point(20, 160);
            this.lblConfFile.Name = "lblConfFile";
            this.lblConfFile.Size = new System.Drawing.Size(80, 17);
            this.lblConfFile.TabIndex = 5;
            this.lblConfFile.Text = "FILE PORT";
            // 
            // txtConfFile
            // 
            this.txtConfFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtConfFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfFile.Font = new System.Drawing.Font("Consolas", 11F);
            this.txtConfFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.txtConfFile.Location = new System.Drawing.Point(120, 157);
            this.txtConfFile.Name = "txtConfFile";
            this.txtConfFile.Size = new System.Drawing.Size(150, 25);
            this.txtConfFile.TabIndex = 6;
            this.txtConfFile.Text = "5051";
            // 
            // pnlControls
            // 
            this.pnlControls.Angulo = 90F;
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlControls.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlControls.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlControls.Controls.Add(this.lblControlsTitle);
            this.pnlControls.Controls.Add(this.btnStart);
            this.pnlControls.Controls.Add(this.btnStop);
            this.pnlControls.Controls.Add(this.btnCheck);
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
            this.lblControlsTitle.Size = new System.Drawing.Size(128, 17);
            this.lblControlsTitle.TabIndex = 0;
            this.lblControlsTitle.Text = "SERVER CONTROLS";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ButtonText = "START TCP SERVER";
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(35, 50);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(250, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.ButtonText = "STOP TCP SERVER";
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.Location = new System.Drawing.Point(35, 105);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(250, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.ButtonText = "CHECK CONNECTION";
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.Location = new System.Drawing.Point(35, 160);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(250, 40);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            // 
            // pnlConnection
            // 
            this.pnlConnection.Angulo = 90F;
            this.pnlConnection.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnection.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlConnection.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlConnection.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlConnection.Controls.Add(this.lblConnTitle);
            this.pnlConnection.Controls.Add(this.lblReqTitle);
            this.pnlConnection.Controls.Add(this.lblReqValue);
            this.pnlConnection.Controls.Add(this.lblClientTitle);
            this.pnlConnection.Controls.Add(this.lblClientValue);
            this.pnlConnection.Controls.Add(this.lblMsgTitle);
            this.pnlConnection.Controls.Add(this.lblMsgValue);
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
            this.lblConnTitle.Size = new System.Drawing.Size(152, 17);
            this.lblConnTitle.TabIndex = 0;
            this.lblConnTitle.Text = "CURRENT CONNECTION";
            // 
            // lblReqTitle
            // 
            this.lblReqTitle.AutoSize = true;
            this.lblReqTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblReqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblReqTitle.Location = new System.Drawing.Point(20, 70);
            this.lblReqTitle.Name = "lblReqTitle";
            this.lblReqTitle.Size = new System.Drawing.Size(104, 17);
            this.lblReqTitle.TabIndex = 1;
            this.lblReqTitle.Text = "CURRENT REQ.";
            // 
            // lblReqValue
            // 
            this.lblReqValue.AutoSize = true;
            this.lblReqValue.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblReqValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.lblReqValue.Location = new System.Drawing.Point(160, 70);
            this.lblReqValue.Name = "lblReqValue";
            this.lblReqValue.Size = new System.Drawing.Size(24, 18);
            this.lblReqValue.TabIndex = 2;
            this.lblReqValue.Text = "--";
            // 
            // lblClientTitle
            // 
            this.lblClientTitle.AutoSize = true;
            this.lblClientTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblClientTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblClientTitle.Location = new System.Drawing.Point(20, 120);
            this.lblClientTitle.Name = "lblClientTitle";
            this.lblClientTitle.Size = new System.Drawing.Size(80, 17);
            this.lblClientTitle.TabIndex = 3;
            this.lblClientTitle.Text = "CLIENT IP";
            // 
            // lblClientValue
            // 
            this.lblClientValue.AutoSize = true;
            this.lblClientValue.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblClientValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblClientValue.Location = new System.Drawing.Point(160, 120);
            this.lblClientValue.Name = "lblClientValue";
            this.lblClientValue.Size = new System.Drawing.Size(24, 18);
            this.lblClientValue.TabIndex = 4;
            this.lblClientValue.Text = "--";
            // 
            // lblMsgTitle
            // 
            this.lblMsgTitle.AutoSize = true;
            this.lblMsgTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblMsgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.lblMsgTitle.Location = new System.Drawing.Point(20, 170);
            this.lblMsgTitle.Name = "lblMsgTitle";
            this.lblMsgTitle.Size = new System.Drawing.Size(104, 17);
            this.lblMsgTitle.TabIndex = 5;
            this.lblMsgTitle.Text = "LAST MESSAGE";
            // 
            // lblMsgValue
            // 
            this.lblMsgValue.AutoSize = true;
            this.lblMsgValue.Font = new System.Drawing.Font("Consolas", 11F);
            this.lblMsgValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(214)))), ((int)(((byte)(75)))));
            this.lblMsgValue.Location = new System.Drawing.Point(160, 170);
            this.lblMsgValue.Name = "lblMsgValue";
            this.lblMsgValue.Size = new System.Drawing.Size(40, 18);
            this.lblMsgValue.TabIndex = 6;
            this.lblMsgValue.Text = "NONE";
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
            this.Text = "Planet Listener - Cyberpunk Interface";
            this.pnlBackGround.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStatus.ResumeLayout(false);
            this.pnlFilePort.ResumeLayout(false);
            this.pnlDataPort.ResumeLayout(false);
            this.pnlPlanetIP.ResumeLayout(false);
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
        private PACS_CustomControls.CustomPanel pnlStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatusValue;
        private PACS_CustomControls.CustomPanel pnlFilePort;
        private System.Windows.Forms.Label lblFilePortTitle;
        private System.Windows.Forms.Label lblFilePortValue;
        private PACS_CustomControls.CustomPanel pnlDataPort;
        private System.Windows.Forms.Label lblDataPortTitle;
        private System.Windows.Forms.Label lblDataPortValue;
        private PACS_CustomControls.CustomPanel pnlPlanetIP;
        private System.Windows.Forms.Label lblPlanetIPTitle;
        private System.Windows.Forms.Label lblPlanetIPValue;
        private PACS_CustomControls.CustomPanel pnlConfig;
        private System.Windows.Forms.Label lblConfigTitle;
        private System.Windows.Forms.Label lblConfIP;
        private System.Windows.Forms.TextBox txtConfIP;
        private System.Windows.Forms.Label lblConfData;
        private System.Windows.Forms.TextBox txtConfData;
        private System.Windows.Forms.Label lblConfFile;
        private System.Windows.Forms.TextBox txtConfFile;
        private PACS_CustomControls.CustomPanel pnlControls;
        private System.Windows.Forms.Label lblControlsTitle;
        private PACS_CustomControls.ProcessButton btnStart;
        private PACS_CustomControls.ProcessButton btnStop;
        private PACS_CustomControls.ProcessButton btnCheck;
        private PACS_CustomControls.CustomPanel pnlConnection;
        private System.Windows.Forms.Label lblConnTitle;
        private System.Windows.Forms.Label lblReqTitle;
        private System.Windows.Forms.Label lblReqValue;
        private System.Windows.Forms.Label lblClientTitle;
        private System.Windows.Forms.Label lblClientValue;
        private System.Windows.Forms.Label lblMsgTitle;
        private System.Windows.Forms.Label lblMsgValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlTopDown;
        private System.Windows.Forms.Panel pnlTopRigh;
        private System.Windows.Forms.Panel pnlTopFillLeft;
        private System.Windows.Forms.Label lblHeaderLeft;
        private System.Windows.Forms.Label lblHeaderRight;
    }
}