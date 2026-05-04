
namespace PACS_Center
{
    partial class frmKeyManager
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
            this.btnKeyGenerator = new System.Windows.Forms.Button();
            this.tbx_container = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKeyGenerator
            // 
            this.btnKeyGenerator.Location = new System.Drawing.Point(114, 101);
            this.btnKeyGenerator.Name = "btnKeyGenerator";
            this.btnKeyGenerator.Size = new System.Drawing.Size(303, 102);
            this.btnKeyGenerator.TabIndex = 0;
            this.btnKeyGenerator.Text = "Key Generator";
            this.btnKeyGenerator.UseVisualStyleBackColor = true;
            this.btnKeyGenerator.Click += new System.EventHandler(this.btnKeyGenerator_Click);
            // 
            // tbx_container
            // 
            this.tbx_container.Location = new System.Drawing.Point(114, 261);
            this.tbx_container.Name = "tbx_container";
            this.tbx_container.Size = new System.Drawing.Size(318, 26);
            this.tbx_container.TabIndex = 1;
            // 
            // frmKeyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 624);
            this.Controls.Add(this.tbx_container);
            this.Controls.Add(this.btnKeyGenerator);
            this.Name = "frmKeyManager";
            this.Text = "frmKeyManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKeyGenerator;
        private System.Windows.Forms.TextBox tbx_container;
    }
}