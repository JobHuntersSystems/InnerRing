using System;

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
            this.pnlBackGround = new PACS_CustomControls.CustomPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.protocolConsole = new PACS_CustomControls.PacsConsole();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlControls = new PACS_CustomControls.CustomPanel();
            this.lblTarget = new System.Windows.Forms.Label();
            this.lblControlHint = new System.Windows.Forms.Label();
            this.btnPhase1 = new PACS_CustomControls.ProcessButton();
            this.btnPhase2 = new PACS_CustomControls.ProcessButton();
            this.btnPhase3 = new PACS_CustomControls.ProcessButton();
            this.btnPhase4 = new PACS_CustomControls.ProcessButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pnlTopDown = new System.Windows.Forms.Panel();
            this.pnlTopFillLeft = new System.Windows.Forms.Panel();
            this.pnlTopFillRight = new System.Windows.Forms.Panel();
            this.lblHeaderLeft = new System.Windows.Forms.Label();
            this.lblHeaderRight = new System.Windows.Forms.Label();
            this.pnlBackGround.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackGround
            // 
            this.pnlBackGround.Angulo = 90F;
            this.pnlBackGround.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackGround.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.pnlBackGround.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlBackGround.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlBackGround.Controls.Add(this.panel1);
            this.pnlBackGround.Controls.Add(this.panel2);
            this.pnlBackGround.Controls.Add(this.panelHeader);
            this.pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackGround.GrosorBorde = 1;
            this.pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this.pnlBackGround.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBackGround.Name = "pnlBackGround";
            this.pnlBackGround.Size = new System.Drawing.Size(1307, 738);
            this.pnlBackGround.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.protocolConsole);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(44, 18, 44, 30);
            this.panel1.Size = new System.Drawing.Size(1307, 172);
            this.panel1.TabIndex = 15;
            // 
            // protocolConsole
            // 
            this.protocolConsole.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.protocolConsole.BackColor = System.Drawing.Color.Transparent;
            this.protocolConsole.ConsoleTitle = "TCP/IP ORBITAL LINK PROTOCOL";
            this.protocolConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.protocolConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.protocolConsole.Location = new System.Drawing.Point(44, 18);
            this.protocolConsole.Margin = new System.Windows.Forms.Padding(5);
            this.protocolConsole.Name = "protocolConsole";
            this.protocolConsole.Size = new System.Drawing.Size(1219, 124);
            this.protocolConsole.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlControls);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(44, 28, 44, 20);
            this.panel2.Size = new System.Drawing.Size(1307, 481);
            this.panel2.TabIndex = 14;
            // 
            // pnlControls
            // 
            this.pnlControls.Angulo = 90F;
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.ColorAbajo = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.pnlControls.ColorArriba = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pnlControls.ColorBordeNeon = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlControls.Controls.Add(this.lblTarget);
            this.pnlControls.Controls.Add(this.lblControlHint);
            this.pnlControls.Controls.Add(this.btnPhase1);
            this.pnlControls.Controls.Add(this.btnPhase2);
            this.pnlControls.Controls.Add(this.btnPhase3);
            this.pnlControls.Controls.Add(this.btnPhase4);
            this.pnlControls.GrosorBorde = 1;
            this.pnlControls.Location = new System.Drawing.Point(44, 28);
            this.pnlControls.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(608, 430);
            this.pnlControls.TabIndex = 6;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Bold);
            this.lblTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.lblTarget.Location = new System.Drawing.Point(32, 24);
            this.lblTarget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(432, 26);
            this.lblTarget.TabIndex = 7;
            this.lblTarget.Text = "/// TARGET: SECTOR 4 - PLANET ORBIT";
            this.lblTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlHint
            // 
            this.lblControlHint.AutoSize = true;
            this.lblControlHint.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(228)))), ((int)(((byte)(244)))));
            this.lblControlHint.Location = new System.Drawing.Point(33, 58);
            this.lblControlHint.Name = "lblControlHint";
            this.lblControlHint.Size = new System.Drawing.Size(594, 20);
            this.lblControlHint.TabIndex = 12;
            this.lblControlHint.Text = "/// Execute each phase sequentially to complete secure validation";
            // 
            // btnPhase1
            // 
            this.btnPhase1.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase1.ButtonText = "PHASE 1: REQUEST VERIFICATION";
            this.btnPhase1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase1.Location = new System.Drawing.Point(37, 100);
            this.btnPhase1.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhase1.Name = "btnPhase1";
            this.btnPhase1.Size = new System.Drawing.Size(530, 60);
            this.btnPhase1.TabIndex = 8;
            this.btnPhase1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btnPhase1.Click += new System.EventHandler(this.btnPhase1_Click);
            // 
            // btnPhase2
            // 
            this.btnPhase2.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase2.ButtonText = "PHASE 2: VALIDATION KEY";
            this.btnPhase2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase2.Enabled = false;
            this.btnPhase2.Location = new System.Drawing.Point(37, 172);
            this.btnPhase2.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhase2.Name = "btnPhase2";
            this.btnPhase2.Size = new System.Drawing.Size(530, 60);
            this.btnPhase2.TabIndex = 9;
            this.btnPhase2.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(40)))));
            this.btnPhase2.Click += new System.EventHandler(this.btnPhase2_Click);
            // 
            // btnPhase3
            // 
            this.btnPhase3.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase3.ButtonText = "PHASE 3: ENCODED FILES";
            this.btnPhase3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase3.Enabled = false;
            this.btnPhase3.Location = new System.Drawing.Point(37, 244);
            this.btnPhase3.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhase3.Name = "btnPhase3";
            this.btnPhase3.Size = new System.Drawing.Size(530, 60);
            this.btnPhase3.TabIndex = 10;
            this.btnPhase3.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(220)))), ((int)(((byte)(105)))));
            this.btnPhase3.Click += new System.EventHandler(this.btnPhase3_Click);
            // 
            // btnPhase4
            // 
            this.btnPhase4.BackColor = System.Drawing.Color.Transparent;
            this.btnPhase4.ButtonText = "PHASE 4: CHECKSUM";
            this.btnPhase4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhase4.Enabled = false;
            this.btnPhase4.Location = new System.Drawing.Point(37, 316);
            this.btnPhase4.Margin = new System.Windows.Forms.Padding(5);
            this.btnPhase4.Name = "btnPhase4";
            this.btnPhase4.Size = new System.Drawing.Size(530, 60);
            this.btnPhase4.TabIndex = 11;
            this.btnPhase4.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPhase4.Click += new System.EventHandler(this.btnPhase4_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.pnlTopDown);
            this.panelHeader.Controls.Add(this.pnlTopFillLeft);
            this.panelHeader.Controls.Add(this.pnlTopFillRight);
            this.panelHeader.Controls.Add(this.lblHeaderLeft);
            this.panelHeader.Controls.Add(this.lblHeaderRight);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1307, 85);
            this.panelHeader.TabIndex = 1;
            // 
            // pnlTopDown
            // 
            this.pnlTopDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pnlTopDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTopDown.Location = new System.Drawing.Point(27, 83);
            this.pnlTopDown.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopDown.Name = "pnlTopDown";
            this.pnlTopDown.Size = new System.Drawing.Size(1253, 2);
            this.pnlTopDown.TabIndex = 2;
            // 
            // pnlTopFillLeft
            // 
            this.pnlTopFillLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTopFillLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlTopFillLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopFillLeft.Name = "pnlTopFillLeft";
            this.pnlTopFillLeft.Size = new System.Drawing.Size(27, 85);
            this.pnlTopFillLeft.TabIndex = 3;
            // 
            // pnlTopFillRight
            // 
            this.pnlTopFillRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopFillRight.Location = new System.Drawing.Point(1280, 0);
            this.pnlTopFillRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopFillRight.Name = "pnlTopFillRight";
            this.pnlTopFillRight.Size = new System.Drawing.Size(27, 85);
            this.pnlTopFillRight.TabIndex = 7;
            // 
            // lblHeaderLeft
            // 
            this.lblHeaderLeft.AutoSize = true;
            this.lblHeaderLeft.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeaderLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblHeaderLeft.Location = new System.Drawing.Point(27, 10);
            this.lblHeaderLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderLeft.Name = "lblHeaderLeft";
            this.lblHeaderLeft.Size = new System.Drawing.Size(431, 36);
            this.lblHeaderLeft.TabIndex = 4;
            this.lblHeaderLeft.Text = "/// ORBITAL AUTHENTICATION";
            // 
            // lblHeaderRight
            // 
            this.lblHeaderRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeaderRight.AutoSize = true;
            this.lblHeaderRight.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lblHeaderRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.lblHeaderRight.Location = new System.Drawing.Point(822, 33);
            this.lblHeaderRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderRight.Name = "lblHeaderRight";
            this.lblHeaderRight.Size = new System.Drawing.Size(351, 20);
            this.lblHeaderRight.TabIndex = 5;
            this.lblHeaderRight.Text = "/// PACS VALIDATION PROTOCOL | STANDBY";
            // 
            // frmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1307, 738);
            this.Controls.Add(this.pnlBackGround);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "frmAuthentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planet Validation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAuthentification_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAuthentification_FormClosed);
            this.pnlBackGround.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PACS_CustomControls.CustomPanel pnlBackGround;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel pnlTopDown;
        private System.Windows.Forms.Panel pnlTopFillLeft;
        private System.Windows.Forms.Panel pnlTopFillRight;
        private System.Windows.Forms.Label lblHeaderLeft;
        private System.Windows.Forms.Label lblHeaderRight;
        private PACS_CustomControls.CustomPanel pnlControls;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblControlHint;
        private PACS_CustomControls.ProcessButton btnPhase1;
        private PACS_CustomControls.ProcessButton btnPhase2;
        private PACS_CustomControls.ProcessButton btnPhase3;
        private PACS_CustomControls.ProcessButton btnPhase4;
        private PACS_CustomControls.PacsConsole protocolConsole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}