
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
            this.btnCode = new System.Windows.Forms.Button();
            this.timerMsj = new System.Windows.Forms.Timer(this.components);
            this.lstMsj = new PACS_CustomControls.PacsConsole();
            this.SuspendLayout();
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(68, 19);
            this.btnCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(82, 39);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Generate codification";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
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
            this.lstMsj.Location = new System.Drawing.Point(188, 19);
            this.lstMsj.Name = "lstMsj";
            this.lstMsj.Size = new System.Drawing.Size(472, 427);
            this.lstMsj.TabIndex = 3;
            // 
            // frmInnerEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 505);
            this.Controls.Add(this.lstMsj);
            this.Controls.Add(this.btnCode);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInnerEncryption";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Timer timerMsj;
        private PACS_CustomControls.PacsConsole lstMsj;
    }
}

