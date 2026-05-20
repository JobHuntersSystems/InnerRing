namespace PACS_CustomControls
{
    partial class PacsStageIndicator
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel bulbStage1;
        private System.Windows.Forms.Panel bulbStage2;
        private System.Windows.Forms.Panel bulbStage3;

        private System.Windows.Forms.Label lblStage1;
        private System.Windows.Forms.Label lblStage2;
        private System.Windows.Forms.Label lblStage3;

        private System.Windows.Forms.Label lblStage1Text;
        private System.Windows.Forms.Label lblStage2Text;
        private System.Windows.Forms.Label lblStage3Text;

        private System.Windows.Forms.Timer tmrFailAnimation;

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
            this.components = new System.ComponentModel.Container();

            this.bulbStage1 = new System.Windows.Forms.Panel();
            this.bulbStage2 = new System.Windows.Forms.Panel();
            this.bulbStage3 = new System.Windows.Forms.Panel();

            this.lblStage1 = new System.Windows.Forms.Label();
            this.lblStage2 = new System.Windows.Forms.Label();
            this.lblStage3 = new System.Windows.Forms.Label();

            this.lblStage1Text = new System.Windows.Forms.Label();
            this.lblStage2Text = new System.Windows.Forms.Label();
            this.lblStage3Text = new System.Windows.Forms.Label();

            this.tmrFailAnimation = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // 
            // PacsStageIndicator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(8, 12, 16);
            this.Controls.Add(this.bulbStage1);
            this.Controls.Add(this.bulbStage2);
            this.Controls.Add(this.bulbStage3);
            this.Controls.Add(this.lblStage1);
            this.Controls.Add(this.lblStage2);
            this.Controls.Add(this.lblStage3);
            this.Controls.Add(this.lblStage1Text);
            this.Controls.Add(this.lblStage2Text);
            this.Controls.Add(this.lblStage3Text);
            this.Name = "PacsStageIndicator";
            this.Size = new System.Drawing.Size(1118, 200);

            // 
            // bulbStage1
            // 
            this.bulbStage1.BackColor = System.Drawing.Color.FromArgb(20, 25, 20);
            this.bulbStage1.Location = new System.Drawing.Point(38, 45);
            this.bulbStage1.Name = "bulbStage1";
            this.bulbStage1.Size = new System.Drawing.Size(22, 22);
            this.bulbStage1.TabIndex = 0;
            this.bulbStage1.Paint += new System.Windows.Forms.PaintEventHandler(this.bulbStage_Paint);

            // 
            // bulbStage2
            // 
            this.bulbStage2.BackColor = System.Drawing.Color.FromArgb(20, 25, 20);
            this.bulbStage2.Location = new System.Drawing.Point(38, 92);
            this.bulbStage2.Name = "bulbStage2";
            this.bulbStage2.Size = new System.Drawing.Size(22, 22);
            this.bulbStage2.TabIndex = 1;
            this.bulbStage2.Paint += new System.Windows.Forms.PaintEventHandler(this.bulbStage_Paint);

            // 
            // bulbStage3
            // 
            this.bulbStage3.BackColor = System.Drawing.Color.FromArgb(20, 25, 20);
            this.bulbStage3.Location = new System.Drawing.Point(38, 139);
            this.bulbStage3.Name = "bulbStage3";
            this.bulbStage3.Size = new System.Drawing.Size(22, 22);
            this.bulbStage3.TabIndex = 2;
            this.bulbStage3.Paint += new System.Windows.Forms.PaintEventHandler(this.bulbStage_Paint);

            // 
            // lblStage1
            // 
            this.lblStage1.AutoSize = true;
            this.lblStage1.BackColor = System.Drawing.Color.Transparent;
            this.lblStage1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblStage1.ForeColor = System.Drawing.Color.FromArgb(220, 230, 235);
            this.lblStage1.Location = new System.Drawing.Point(82, 39);
            this.lblStage1.Name = "lblStage1";
            this.lblStage1.Size = new System.Drawing.Size(64, 18);
            this.lblStage1.TabIndex = 3;
            this.lblStage1.Text = "STAGE 1";

            // 
            // lblStage1Text
            // 
            this.lblStage1Text.AutoSize = true;
            this.lblStage1Text.BackColor = System.Drawing.Color.Transparent;
            this.lblStage1Text.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.lblStage1Text.ForeColor = System.Drawing.Color.FromArgb(255, 190, 55);
            this.lblStage1Text.Location = new System.Drawing.Point(82, 58);
            this.lblStage1Text.Name = "lblStage1Text";
            this.lblStage1Text.Size = new System.Drawing.Size(88, 17);
            this.lblStage1Text.TabIndex = 4;
            this.lblStage1Text.Text = "ENTRY REQ.";

            // 
            // lblStage2
            // 
            this.lblStage2.AutoSize = true;
            this.lblStage2.BackColor = System.Drawing.Color.Transparent;
            this.lblStage2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblStage2.ForeColor = System.Drawing.Color.FromArgb(220, 230, 235);
            this.lblStage2.Location = new System.Drawing.Point(82, 86);
            this.lblStage2.Name = "lblStage2";
            this.lblStage2.Size = new System.Drawing.Size(64, 18);
            this.lblStage2.TabIndex = 5;
            this.lblStage2.Text = "STAGE 2";

            // 
            // lblStage2Text
            // 
            this.lblStage2Text.AutoSize = true;
            this.lblStage2Text.BackColor = System.Drawing.Color.Transparent;
            this.lblStage2Text.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.lblStage2Text.ForeColor = System.Drawing.Color.FromArgb(255, 190, 55);
            this.lblStage2Text.Location = new System.Drawing.Point(82, 105);
            this.lblStage2Text.Name = "lblStage2Text";
            this.lblStage2Text.Size = new System.Drawing.Size(88, 17);
            this.lblStage2Text.TabIndex = 6;
            this.lblStage2Text.Text = "VALID. KEY";

            // 
            // lblStage3
            // 
            this.lblStage3.AutoSize = true;
            this.lblStage3.BackColor = System.Drawing.Color.Transparent;
            this.lblStage3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lblStage3.ForeColor = System.Drawing.Color.FromArgb(220, 230, 235);
            this.lblStage3.Location = new System.Drawing.Point(82, 133);
            this.lblStage3.Name = "lblStage3";
            this.lblStage3.Size = new System.Drawing.Size(64, 18);
            this.lblStage3.TabIndex = 7;
            this.lblStage3.Text = "STAGE 3";

            // 
            // lblStage3Text
            // 
            this.lblStage3Text.AutoSize = true;
            this.lblStage3Text.BackColor = System.Drawing.Color.Transparent;
            this.lblStage3Text.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.lblStage3Text.ForeColor = System.Drawing.Color.FromArgb(255, 190, 55);
            this.lblStage3Text.Location = new System.Drawing.Point(82, 152);
            this.lblStage3Text.Name = "lblStage3Text";
            this.lblStage3Text.Size = new System.Drawing.Size(88, 17);
            this.lblStage3Text.TabIndex = 8;
            this.lblStage3Text.Text = "FINAL RES.";

            // 
            // tmrFailAnimation
            // 
            this.tmrFailAnimation.Interval = 120;
            this.tmrFailAnimation.Tick += new System.EventHandler(this.tmrFailAnimation_Tick);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}