namespace PACS_CustomControls
{
    partial class PacsConsole
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Button btnClear;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(160, 220, 235);
            this.lblTitle.Location = new System.Drawing.Point(22, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SYSTEM LOG CONSOLE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.BackColor = System.Drawing.Color.FromArgb(2, 5, 8);
            this.rtbConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbConsole.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbConsole.ForeColor = System.Drawing.Color.FromArgb(130, 220, 105);
            this.rtbConsole.Location = new System.Drawing.Point(22, 42);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConsole.Size = new System.Drawing.Size(556, 96);
            this.rtbConsole.TabIndex = 1;
            this.rtbConsole.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(12, 18, 28);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(255, 180, 40);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(255, 180, 40);
            this.btnClear.Location = new System.Drawing.Point(500, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PacsConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "PacsConsole";
            this.Size = new System.Drawing.Size(600, 160);
            this.ResumeLayout(false);
        }
    }
}