
namespace PACS_ZipGenerator
{
	partial class FrmPacsZipGenerator
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
            this.btnGenerator = new System.Windows.Forms.Button();
            this.btnClose = new PACS_InheratedControls.PacsCloseButton();
            this.Minimize = new PACS_InheratedControls.PacsMinimizeButton();
            this.lstGenerator = new PACS_CustomControls.PacsConsole();
            this.SuspendLayout();
            // 
            // btnGenerator
            // 
            this.btnGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerator.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnGenerator.Location = new System.Drawing.Point(22, 40);
            this.btnGenerator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(200, 92);
            this.btnGenerator.TabIndex = 0;
            this.btnGenerator.Text = "Generate Files and ZIP";
            this.btnGenerator.UseVisualStyleBackColor = false;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DefaultClickEvent = true;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(583, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 18);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.DefaultClickEvent = true;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.Minimize.Location = new System.Drawing.Point(532, 10);
            this.Minimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(46, 18);
            this.Minimize.TabIndex = 2;
            this.Minimize.Text = "-";
            this.Minimize.UseVisualStyleBackColor = false;
            // 
            // lstGenerator
            // 
            this.lstGenerator.AccentColor = System.Drawing.Color.Empty;
            this.lstGenerator.BackColor = System.Drawing.Color.Transparent;
            this.lstGenerator.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.lstGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lstGenerator.Location = new System.Drawing.Point(237, 40);
            this.lstGenerator.Name = "lstGenerator";
            this.lstGenerator.Size = new System.Drawing.Size(395, 573);
            this.lstGenerator.TabIndex = 4;
            // 
            // FrmPacsZipGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(643, 618);
            this.ControlBox = false;
            this.Controls.Add(this.lstGenerator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.btnGenerator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPacsZipGenerator";
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGenerator;
		private PACS_CustomControls.PacsConsole lstGeneration;
		private PACS_InheratedControls.PacsMinimizeButton Minimize;
		private PACS_InheratedControls.PacsCloseButton btnClose;
		private PACS_CustomControls.PacsConsole lstGenerator;
	}
}