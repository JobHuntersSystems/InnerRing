
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
            this.lstMsj = new System.Windows.Forms.ListBox();
            this.timerMsj = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(102, 30);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(123, 60);
            this.btnCode.TabIndex = 0;
            this.btnCode.Text = "Generate codification";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // lstMsj
            // 
            this.lstMsj.FormattingEnabled = true;
            this.lstMsj.ItemHeight = 20;
            this.lstMsj.Location = new System.Drawing.Point(300, 30);
            this.lstMsj.Name = "lstMsj";
            this.lstMsj.Size = new System.Drawing.Size(346, 364);
            this.lstMsj.TabIndex = 2;
            // 
            // timerMsj
            // 
            this.timerMsj.Interval = 600;
            this.timerMsj.Tick += new System.EventHandler(this.timerMsj_Tick);
            // 
            // frmInnerEncryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMsj);
            this.Controls.Add(this.btnCode);
            this.Name = "frmInnerEncryption";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.ListBox lstMsj;
        private System.Windows.Forms.Timer timerMsj;
    }
}

