
namespace PACS_ChecksumCalculator
{
	partial class FrmPacsChecksumCalculator
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
			this.btnChecksum = new System.Windows.Forms.Button();
			this.Minimize = new PACS_InheratedControls.PacsMinimizeButton();
			this.Close = new PACS_InheratedControls.PacsCloseButton();
			this.lstCalculator = new PACS_CustomControls.PacsConsole();
			this.SuspendLayout();
			// 
			// btnChecksum
			// 
			this.btnChecksum.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
			this.btnChecksum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
			this.btnChecksum.Location = new System.Drawing.Point(34, 55);
			this.btnChecksum.Name = "btnChecksum";
			this.btnChecksum.Size = new System.Drawing.Size(267, 113);
			this.btnChecksum.TabIndex = 0;
			this.btnChecksum.Text = "Calculate Checksum";
			this.btnChecksum.UseVisualStyleBackColor = false;
			this.btnChecksum.Click += new System.EventHandler(this.btnChecksum_Click);
			// 
			// Minimize
			// 
			this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
			this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Minimize.DefaultClickEvent = true;
			this.Minimize.FlatAppearance.BorderSize = 0;
			this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Minimize.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
			this.Minimize.Location = new System.Drawing.Point(753, 12);
			this.Minimize.Name = "Minimize";
			this.Minimize.Size = new System.Drawing.Size(47, 22);
			this.Minimize.TabIndex = 3;
			this.Minimize.Text = "-";
			this.Minimize.UseVisualStyleBackColor = false;
			// 
			// Close
			// 
			this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
			this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Close.DefaultClickEvent = true;
			this.Close.FlatAppearance.BorderSize = 0;
			this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Close.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
			this.Close.Location = new System.Drawing.Point(806, 12);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(48, 22);
			this.Close.TabIndex = 2;
			this.Close.Text = "X";
			this.Close.UseVisualStyleBackColor = false;
			// 
			// lstCalculator
			// 
			this.lstCalculator.AccentColor = System.Drawing.Color.Empty;
			this.lstCalculator.BackColor = System.Drawing.Color.Transparent;
			this.lstCalculator.ConsoleTitle = "SYSTEM LOG CONSOLE";
			this.lstCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
			this.lstCalculator.Location = new System.Drawing.Point(308, 55);
			this.lstCalculator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.lstCalculator.Name = "lstCalculator";
			this.lstCalculator.Size = new System.Drawing.Size(527, 705);
			this.lstCalculator.TabIndex = 4;
			// 
			// FrmPacsChecksumCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(857, 760);
			this.Controls.Add(this.lstCalculator);
			this.Controls.Add(this.Minimize);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.btnChecksum);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmPacsChecksumCalculator";
			this.Text = "FrmPacsChecksumCalculator";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnChecksum;
		private PACS_CustomControls.PacsConsole lstCalculations;
		private PACS_InheratedControls.PacsCloseButton Close;
		private PACS_InheratedControls.PacsMinimizeButton Minimize;
		private PACS_CustomControls.PacsConsole lstCalculator;
	}
}