namespace PACS_Spaceship
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnWeapons = new PACS_CustomControls.OptionButton();
            this.btnAutentification = new PACS_CustomControls.OptionButton();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.pnlSidebar.Controls.Add(this.btnWeapons);
            this.pnlSidebar.Controls.Add(this.btnAutentification);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(27, 25);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(13, 37, 13, 12);
            this.pnlSidebar.Size = new System.Drawing.Size(427, 836);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Location = new System.Drawing.Point(454, 25);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlMain.Size = new System.Drawing.Size(1226, 836);
            this.pnlMain.TabIndex = 1;
            // 
            // btnWeapons
            // 
            this.btnWeapons.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnWeapons.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnWeapons.BackColor = System.Drawing.Color.Transparent;
            this.btnWeapons.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnWeapons.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnWeapons.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.btnWeapons.ClassName = "WpnSystems.dll";
            this.btnWeapons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeapons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWeapons.FormName = "WpnSystems.FrmWeapons";
            this.btnWeapons.IsSelected = false;
            this.btnWeapons.Location = new System.Drawing.Point(13, 123);
            this.btnWeapons.Margin = new System.Windows.Forms.Padding(5);
            this.btnWeapons.Name = "btnWeapons";
            this.btnWeapons.OptionIcon = null;
            this.btnWeapons.OptionText = "SUMMARY";
            this.btnWeapons.Size = new System.Drawing.Size(401, 86);
            this.btnWeapons.TabIndex = 2;
            this.btnWeapons.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            // 
            // btnAutentification
            // 
            this.btnAutentification.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(230)))), ((int)(((byte)(120)))));
            this.btnAutentification.AccentHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnAutentification.BackColor = System.Drawing.Color.Transparent;
            this.btnAutentification.BackgroundPanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.btnAutentification.BorderDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnAutentification.BorderLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(105)))), ((int)(((byte)(95)))));
            this.btnAutentification.ClassName = "PACS-ProcessForms.dll";
            this.btnAutentification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutentification.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAutentification.FormName = "PACS_ProcessForms.frmAuthentification";
            this.btnAutentification.IsSelected = false;
            this.btnAutentification.Location = new System.Drawing.Point(13, 37);
            this.btnAutentification.Margin = new System.Windows.Forms.Padding(5);
            this.btnAutentification.Name = "btnAutentification";
            this.btnAutentification.OptionIcon = null;
            this.btnAutentification.OptionText = "AUTHENTIFICATION";
            this.btnAutentification.Size = new System.Drawing.Size(401, 86);
            this.btnAutentification.TabIndex = 0;
            this.btnAutentification.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(240)))), ((int)(((byte)(150)))));
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1707, 886);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceship Cockpit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMain; // OBLIGATORIO LLAMARSE ASÍ

        private PACS_CustomControls.OptionButton btnAutentification;
        private PACS_CustomControls.OptionButton btnWeapons;
    }
}