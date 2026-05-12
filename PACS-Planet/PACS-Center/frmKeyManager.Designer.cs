
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pacsMinimizeButton1 = new PACS_InheratedControls.PacsMinimizeButton();
            this.btnClose = new PACS_InheratedControls.PacsCloseButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKeyGenerator
            // 
            this.btnKeyGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnKeyGenerator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.btnKeyGenerator.FlatAppearance.BorderSize = 2;
            this.btnKeyGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyGenerator.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeyGenerator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(255)))), ((int)(((byte)(90)))));
            this.btnKeyGenerator.Location = new System.Drawing.Point(29, 30);
            this.btnKeyGenerator.Name = "btnKeyGenerator";
            this.btnKeyGenerator.Size = new System.Drawing.Size(400, 98);
            this.btnKeyGenerator.TabIndex = 2;
            this.btnKeyGenerator.Text = "Generate Keys";
            this.btnKeyGenerator.UseVisualStyleBackColor = false;
            this.btnKeyGenerator.Click += new System.EventHandler(this.btnKeyGenerator_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(26)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.btnKeyGenerator);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 199);
            this.panel1.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblMessage.Location = new System.Drawing.Point(25, 151);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 19);
            this.lblMessage.TabIndex = 3;
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
            this.pacsMinimizeButton1.Location = new System.Drawing.Point(388, 5);
            this.pacsMinimizeButton1.Name = "pacsMinimizeButton1";
            this.pacsMinimizeButton1.Size = new System.Drawing.Size(41, 22);
            this.pacsMinimizeButton1.TabIndex = 10;
            this.pacsMinimizeButton1.Text = "-";
            this.pacsMinimizeButton1.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DefaultClickEvent = true;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(432, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 22);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmKeyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(478, 257);
            this.Controls.Add(this.pacsMinimizeButton1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKeyManager";
            this.Text = "frmKeyManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeyGenerator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMessage;
        private PACS_InheratedControls.PacsMinimizeButton pacsMinimizeButton1;
        private PACS_InheratedControls.PacsCloseButton btnClose;
    }
}