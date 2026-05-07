
namespace PACS_ProcessForms
{
    partial class frmAuthentification
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnPhase4 = new PACS_CustomControls.ProcessButton();
            this.lblTarget = new System.Windows.Forms.Label();
            this.btnPhase1 = new PACS_CustomControls.ProcessButton();
            this.btnPhase2 = new PACS_CustomControls.ProcessButton();
            this.btnPhase3 = new PACS_CustomControls.ProcessButton();
            this.protocolConsole = new PACS_CustomControls.PacsConsole();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.btnPhase4);
            this.pnlControls.Controls.Add(this.lblTarget);
            this.pnlControls.Controls.Add(this.btnPhase1);
            this.pnlControls.Controls.Add(this.btnPhase2);
            this.pnlControls.Controls.Add(this.btnPhase3);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(1320, 434);
            this.pnlControls.TabIndex = 0;
            // 
            // btnPhase4
            // 
            this.btnPhase4.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase4.ButtonText = "PHASE 4: CHECKSUM";
            this.btnPhase4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase4.Enabled = false;
            this.btnPhase4.Location = new System.Drawing.Point(45, 319);
            this.btnPhase4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnPhase4.Name = "btnPhase4";
            this.btnPhase4.Size = new System.Drawing.Size(373, 62);
            this.btnPhase4.TabIndex = 4;
            this.btnPhase4.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.lblTarget.Location = new System.Drawing.Point(40, 25);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(415, 28);
            this.lblTarget.TabIndex = 3;
            this.lblTarget.Text = "TARGET: SECTOR 4 - PLANET ORBIT";
            // 
            // btnPhase1
            // 
            this.btnPhase1.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase1.ButtonText = "PHASE 1: REQUEST VERIFICATION";
            this.btnPhase1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase1.Location = new System.Drawing.Point(45, 86);
            this.btnPhase1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnPhase1.Name = "btnPhase1";
            this.btnPhase1.Size = new System.Drawing.Size(373, 62);
            this.btnPhase1.TabIndex = 0;
            this.btnPhase1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnPhase1.Click += new System.EventHandler(this.btnPhase1_Click);
            // 
            // btnPhase2
            // 
            this.btnPhase2.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase2.ButtonText = "PHASE 2: DELIVERY DOCUMENT";
            this.btnPhase2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase2.Enabled = false;
            this.btnPhase2.Location = new System.Drawing.Point(45, 164);
            this.btnPhase2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnPhase2.Name = "btnPhase2";
            this.btnPhase2.Size = new System.Drawing.Size(373, 62);
            this.btnPhase2.TabIndex = 1;
            this.btnPhase2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.btnPhase2.Click += new System.EventHandler(this.btnPhase2_Click);
            // 
            // btnPhase3
            // 
            this.btnPhase3.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase3.ButtonText = "PHASE 3: ENCODED FILES";
            this.btnPhase3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase3.Enabled = false;
            this.btnPhase3.Location = new System.Drawing.Point(45, 241);
            this.btnPhase3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 12);
            this.btnPhase3.Name = "btnPhase3";
            this.btnPhase3.Size = new System.Drawing.Size(373, 62);
            this.btnPhase3.TabIndex = 2;
            this.btnPhase3.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(220)))), ((int)(((byte)(105)))));
            this.btnPhase3.Click += new System.EventHandler(this.btnPhase3_Click);
            // 
            // protocolConsole
            // 
            this.protocolConsole.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.protocolConsole.BackColor = System.Drawing.Color.Transparent;
            this.protocolConsole.ConsoleTitle = "TCP/IP ORBITAL LINK PROTOCOL";
            this.protocolConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protocolConsole.Location = new System.Drawing.Point(0, 434);
            this.protocolConsole.Margin = new System.Windows.Forms.Padding(5);
            this.protocolConsole.Name = "protocolConsole";
            this.protocolConsole.Padding = new System.Windows.Forms.Padding(40, 0, 40, 37);
            this.protocolConsole.Size = new System.Drawing.Size(1320, 157);
            this.protocolConsole.TabIndex = 1;
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(12)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1320, 591);
            this.Controls.Add(this.protocolConsole);
            this.Controls.Add(this.pnlControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAuthentification";
            this.Text = "Planet Validation";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblTarget;
        private PACS_CustomControls.ProcessButton btnPhase1;
        private PACS_CustomControls.ProcessButton btnPhase2;
        private PACS_CustomControls.ProcessButton btnPhase3;
        private PACS_CustomControls.PacsConsole protocolConsole;
        private PACS_CustomControls.ProcessButton btnPhase4;
    }
}

