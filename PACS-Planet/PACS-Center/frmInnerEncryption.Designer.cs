
namespace PACS_Center
{
    partial class frmInnerEncryption
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerMsj = new System.Windows.Forms.Timer(this.components);
            this.lstMsj = new PACS_CustomControls.PacsConsole();
            this.btnCode = new System.Windows.Forms.Button();
            this.pacsMinimizeButton1 = new PACS_InheratedControls.PacsMinimizeButton();
            this.btnClose = new PACS_InheratedControls.PacsCloseButton();
            this.SuspendLayout();
            // 
            // timerMsj
            // 
            this.timerMsj.Interval = 600;
            this.timerMsj.Tick += new System.EventHandler(this.timerMsj_Tick);
            // 
            // lstMsj
            // 
            this.lstMsj.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lstMsj.BackColor = System.Drawing.Color.Transparent;
            this.lstMsj.ConsoleTitle = "SYSTEM LOG CONSOLE";
            this.lstMsj.Location = new System.Drawing.Point(251, 37);
            this.lstMsj.Name = "lstMsj";
            this.lstMsj.Size = new System.Drawing.Size(364, 456);
            this.lstMsj.TabIndex = 3;
            // 
            // btnCode
            // 
            this.btnCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.btnCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCode.FlatAppearance.BorderSize = 2;
            this.btnCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnCode.Location = new System.Drawing.Point(30, 37);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(200, 92);
            this.btnCode.TabIndex = 4;
            this.btnCode.Text = "Generate Codes";
            this.btnCode.UseVisualStyleBackColor = false;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
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
            this.pacsMinimizeButton1.Location = new System.Drawing.Point(548, 5);
            this.pacsMinimizeButton1.Name = "pacsMinimizeButton1";
            this.pacsMinimizeButton1.Size = new System.Drawing.Size(41, 22);
            this.pacsMinimizeButton1.TabIndex = 8;
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
            this.btnClose.Location = new System.Drawing.Point(592, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 22);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // frmInnerEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(638, 514);
            this.Controls.Add(this.pacsMinimizeButton1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.lstMsj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInnerEncryption";
            this.Text = "Validation Code";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMsj;
        private PACS_CustomControls.PacsConsole lstMsj;
        private System.Windows.Forms.Button btnCode;
        private PACS_InheratedControls.PacsMinimizeButton pacsMinimizeButton1;
        private PACS_InheratedControls.PacsCloseButton btnClose;
    }
}

