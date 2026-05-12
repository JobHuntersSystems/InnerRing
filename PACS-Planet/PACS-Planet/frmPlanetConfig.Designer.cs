namespace PACS_Planet
{
    partial class frmPlanetConfig
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblIdPlanet;
        private System.Windows.Forms.Label lblCodePlanet;
        private System.Windows.Forms.Label lblDescPlanet;
        private System.Windows.Forms.Label lblPlanetPicture;
        private System.Windows.Forms.Label lblIPPlanet;
        private System.Windows.Forms.Label lblPortPlanet;
        private System.Windows.Forms.Label lblPortPlanet1;
        private System.Windows.Forms.Label lblPreviewTitle;

        private System.Windows.Forms.TextBox txtIdPlanet;
        private System.Windows.Forms.TextBox txtCodePlanet;
        private System.Windows.Forms.TextBox txtDescPlanet;
        private System.Windows.Forms.TextBox txtPlanetPicture;
        private System.Windows.Forms.TextBox txtIPPlanet;
        private System.Windows.Forms.TextBox txtPortPlanet;
        private System.Windows.Forms.TextBox txtPortPlanet1;

        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnSaveConfig;

        private System.Windows.Forms.PictureBox pctPlanet;
        private System.Windows.Forms.OpenFileDialog openFileDialogPlanetImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIdPlanet = new System.Windows.Forms.Label();
            this.lblCodePlanet = new System.Windows.Forms.Label();
            this.lblDescPlanet = new System.Windows.Forms.Label();
            this.lblPlanetPicture = new System.Windows.Forms.Label();
            this.lblIPPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet = new System.Windows.Forms.Label();
            this.lblPortPlanet1 = new System.Windows.Forms.Label();
            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.txtIdPlanet = new System.Windows.Forms.TextBox();
            this.txtCodePlanet = new System.Windows.Forms.TextBox();
            this.txtDescPlanet = new System.Windows.Forms.TextBox();
            this.txtPlanetPicture = new System.Windows.Forms.TextBox();
            this.txtIPPlanet = new System.Windows.Forms.TextBox();
            this.txtPortPlanet = new System.Windows.Forms.TextBox();
            this.txtPortPlanet1 = new System.Windows.Forms.TextBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.pctPlanet = new System.Windows.Forms.PictureBox();
            this.openFileDialogPlanetImage = new System.Windows.Forms.OpenFileDialog();
            this.pacsCloseButton1 = new PACS_InheratedControls.PacsCloseButton();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlanet)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(21)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.pacsCloseButton1);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.lblIdPlanet);
            this.pnlMain.Controls.Add(this.lblCodePlanet);
            this.pnlMain.Controls.Add(this.lblDescPlanet);
            this.pnlMain.Controls.Add(this.lblPlanetPicture);
            this.pnlMain.Controls.Add(this.lblIPPlanet);
            this.pnlMain.Controls.Add(this.lblPortPlanet);
            this.pnlMain.Controls.Add(this.lblPortPlanet1);
            this.pnlMain.Controls.Add(this.lblPreviewTitle);
            this.pnlMain.Controls.Add(this.txtIdPlanet);
            this.pnlMain.Controls.Add(this.txtCodePlanet);
            this.pnlMain.Controls.Add(this.txtDescPlanet);
            this.pnlMain.Controls.Add(this.txtPlanetPicture);
            this.pnlMain.Controls.Add(this.txtIPPlanet);
            this.pnlMain.Controls.Add(this.txtPortPlanet);
            this.pnlMain.Controls.Add(this.txtPortPlanet1);
            this.pnlMain.Controls.Add(this.btnBrowseImage);
            this.pnlMain.Controls.Add(this.btnSaveConfig);
            this.pnlMain.Controls.Add(this.pctPlanet);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(619, 414);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(19)))), ((int)(((byte)(25)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Location = new System.Drawing.Point(15, 36);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(589, 45);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.lblTitle.Location = new System.Drawing.Point(16, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(272, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PLANET CONFIGURATION";
            // 
            // lblIdPlanet
            // 
            this.lblIdPlanet.AutoSize = true;
            this.lblIdPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblIdPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblIdPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblIdPlanet.Location = new System.Drawing.Point(36, 120);
            this.lblIdPlanet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPlanet.Name = "lblIdPlanet";
            this.lblIdPlanet.Size = new System.Drawing.Size(80, 17);
            this.lblIdPlanet.TabIndex = 1;
            this.lblIdPlanet.Text = "ID PLANET";
            // 
            // lblCodePlanet
            // 
            this.lblCodePlanet.AutoSize = true;
            this.lblCodePlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblCodePlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodePlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblCodePlanet.Location = new System.Drawing.Point(36, 156);
            this.lblCodePlanet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodePlanet.Name = "lblCodePlanet";
            this.lblCodePlanet.Size = new System.Drawing.Size(96, 17);
            this.lblCodePlanet.TabIndex = 3;
            this.lblCodePlanet.Text = "CODE PLANET";
            // 
            // lblDescPlanet
            // 
            this.lblDescPlanet.AutoSize = true;
            this.lblDescPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblDescPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblDescPlanet.Location = new System.Drawing.Point(36, 192);
            this.lblDescPlanet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescPlanet.Name = "lblDescPlanet";
            this.lblDescPlanet.Size = new System.Drawing.Size(96, 17);
            this.lblDescPlanet.TabIndex = 5;
            this.lblDescPlanet.Text = "DESCRIPTION";
            // 
            // lblPlanetPicture
            // 
            this.lblPlanetPicture.AutoSize = true;
            this.lblPlanetPicture.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanetPicture.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPlanetPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblPlanetPicture.Location = new System.Drawing.Point(36, 227);
            this.lblPlanetPicture.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlanetPicture.Name = "lblPlanetPicture";
            this.lblPlanetPicture.Size = new System.Drawing.Size(88, 17);
            this.lblPlanetPicture.TabIndex = 7;
            this.lblPlanetPicture.Text = "IMAGE PATH";
            // 
            // lblIPPlanet
            // 
            this.lblIPPlanet.AutoSize = true;
            this.lblIPPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblIPPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblIPPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblIPPlanet.Location = new System.Drawing.Point(36, 263);
            this.lblIPPlanet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPPlanet.Name = "lblIPPlanet";
            this.lblIPPlanet.Size = new System.Drawing.Size(72, 17);
            this.lblIPPlanet.TabIndex = 10;
            this.lblIPPlanet.Text = "LOCAL IP";
            // 
            // lblPortPlanet
            // 
            this.lblPortPlanet.AutoSize = true;
            this.lblPortPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblPortPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPortPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblPortPlanet.Location = new System.Drawing.Point(36, 299);
            this.lblPortPlanet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortPlanet.Name = "lblPortPlanet";
            this.lblPortPlanet.Size = new System.Drawing.Size(80, 17);
            this.lblPortPlanet.TabIndex = 12;
            this.lblPortPlanet.Text = "DATA PORT";
            // 
            // lblPortPlanet1
            // 
            this.lblPortPlanet1.AutoSize = true;
            this.lblPortPlanet1.BackColor = System.Drawing.Color.Transparent;
            this.lblPortPlanet1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPortPlanet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.lblPortPlanet1.Location = new System.Drawing.Point(36, 335);
            this.lblPortPlanet1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortPlanet1.Name = "lblPortPlanet1";
            this.lblPortPlanet1.Size = new System.Drawing.Size(80, 17);
            this.lblPortPlanet1.TabIndex = 14;
            this.lblPortPlanet1.Text = "FILE PORT";
            // 
            // lblPreviewTitle
            // 
            this.lblPreviewTitle.AutoSize = true;
            this.lblPreviewTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPreviewTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(55)))));
            this.lblPreviewTitle.Location = new System.Drawing.Point(480, 120);
            this.lblPreviewTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Size = new System.Drawing.Size(120, 17);
            this.lblPreviewTitle.TabIndex = 16;
            this.lblPreviewTitle.Text = "PLANET PREVIEW";
            // 
            // txtIdPlanet
            // 
            this.txtIdPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtIdPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtIdPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtIdPlanet.Location = new System.Drawing.Point(165, 115);
            this.txtIdPlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdPlanet.Name = "txtIdPlanet";
            this.txtIdPlanet.Size = new System.Drawing.Size(136, 23);
            this.txtIdPlanet.TabIndex = 2;
            // 
            // txtCodePlanet
            // 
            this.txtCodePlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtCodePlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodePlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtCodePlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtCodePlanet.Location = new System.Drawing.Point(165, 151);
            this.txtCodePlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodePlanet.Name = "txtCodePlanet";
            this.txtCodePlanet.Size = new System.Drawing.Size(136, 23);
            this.txtCodePlanet.TabIndex = 4;
            // 
            // txtDescPlanet
            // 
            this.txtDescPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtDescPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtDescPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtDescPlanet.Location = new System.Drawing.Point(165, 187);
            this.txtDescPlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescPlanet.Name = "txtDescPlanet";
            this.txtDescPlanet.Size = new System.Drawing.Size(240, 23);
            this.txtDescPlanet.TabIndex = 6;
            // 
            // txtPlanetPicture
            // 
            this.txtPlanetPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtPlanetPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlanetPicture.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtPlanetPicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtPlanetPicture.Location = new System.Drawing.Point(165, 223);
            this.txtPlanetPicture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlanetPicture.Name = "txtPlanetPicture";
            this.txtPlanetPicture.Size = new System.Drawing.Size(240, 23);
            this.txtPlanetPicture.TabIndex = 8;
            // 
            // txtIPPlanet
            // 
            this.txtIPPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtIPPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIPPlanet.Enabled = false;
            this.txtIPPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtIPPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtIPPlanet.Location = new System.Drawing.Point(165, 258);
            this.txtIPPlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIPPlanet.Name = "txtIPPlanet";
            this.txtIPPlanet.Size = new System.Drawing.Size(136, 23);
            this.txtIPPlanet.TabIndex = 11;
            // 
            // txtPortPlanet
            // 
            this.txtPortPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtPortPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortPlanet.Enabled = false;
            this.txtPortPlanet.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtPortPlanet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtPortPlanet.Location = new System.Drawing.Point(165, 294);
            this.txtPortPlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPortPlanet.Name = "txtPortPlanet";
            this.txtPortPlanet.Size = new System.Drawing.Size(136, 23);
            this.txtPortPlanet.TabIndex = 13;
            // 
            // txtPortPlanet1
            // 
            this.txtPortPlanet1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            this.txtPortPlanet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPortPlanet1.Enabled = false;
            this.txtPortPlanet1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.txtPortPlanet1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.txtPortPlanet1.Location = new System.Drawing.Point(165, 330);
            this.txtPortPlanet1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPortPlanet1.Name = "txtPortPlanet1";
            this.txtPortPlanet1.Size = new System.Drawing.Size(136, 23);
            this.txtPortPlanet1.TabIndex = 15;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.btnBrowseImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowseImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnBrowseImage.Location = new System.Drawing.Point(411, 222);
            this.btnBrowseImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(32, 24);
            this.btnBrowseImage.TabIndex = 9;
            this.btnBrowseImage.Text = "...";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.btnSaveConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.btnSaveConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConfig.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(255)))), ((int)(((byte)(110)))));
            this.btnSaveConfig.Location = new System.Drawing.Point(476, 277);
            this.btnSaveConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(128, 28);
            this.btnSaveConfig.TabIndex = 19;
            this.btnSaveConfig.Text = "SAVE CONFIG";
            this.btnSaveConfig.UseVisualStyleBackColor = false;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // pctPlanet
            // 
            this.pctPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(7)))), ((int)(((byte)(10)))));
            this.pctPlanet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctPlanet.Location = new System.Drawing.Point(476, 146);
            this.pctPlanet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctPlanet.Name = "pctPlanet";
            this.pctPlanet.Size = new System.Drawing.Size(128, 118);
            this.pctPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPlanet.TabIndex = 17;
            this.pctPlanet.TabStop = false;
            // 
            // openFileDialogPlanetImage
            // 
            this.openFileDialogPlanetImage.Filter = "Image files|*.png;*.jpg;*.jpeg;*.bmp|All files|*.*";
            this.openFileDialogPlanetImage.Title = "Select planet image";
            // 
            // pacsCloseButton1
            // 
            this.pacsCloseButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pacsCloseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.pacsCloseButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pacsCloseButton1.DefaultClickEvent = true;
            this.pacsCloseButton1.FlatAppearance.BorderSize = 0;
            this.pacsCloseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pacsCloseButton1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.pacsCloseButton1.Location = new System.Drawing.Point(572, 4);
            this.pacsCloseButton1.Name = "pacsCloseButton1";
            this.pacsCloseButton1.Size = new System.Drawing.Size(41, 22);
            this.pacsCloseButton1.TabIndex = 22;
            this.pacsCloseButton1.Text = "X";
            this.pacsCloseButton1.UseVisualStyleBackColor = false;
            // 
            // frmPlanetConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(619, 414);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmPlanetConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PACS - Planet Configuration";
            this.Load += new System.EventHandler(this.frmPlanetConfig_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPlanet)).EndInit();
            this.ResumeLayout(false);

        }

        private PACS_InheratedControls.PacsCloseButton pacsCloseButton1;
    }
}