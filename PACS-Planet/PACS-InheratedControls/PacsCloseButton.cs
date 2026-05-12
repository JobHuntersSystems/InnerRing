using System.Drawing;
using System.Windows.Forms;

namespace PACS_InheratedControls
{
    public class PacsCloseButton : PacsBaseButton
    {   
        public PacsCloseButton()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(42, 8, 8);
            BorderColor = Color.FromArgb(106, 16, 16);
            BorderHoverColor = Color.FromArgb(221, 68, 68);
            InnerBorderColor = Color.FromArgb(58, 8, 8);
            GlyphColor = Color.FromArgb(224, 64, 64);
            Text = "✕";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PacsCloseButton
            // 
            this.FlatAppearance.BorderSize = 0;
            this.Click += new System.EventHandler(this.PacsCloseButton_Click);
            this.ResumeLayout(false);

        }

        private void PacsCloseButton_Click(object sender, System.EventArgs e)
        {
            if (DefaultClickEvent)
            {
                Form frm = this.FindForm();
                frm.Close();
            }
        }
    }
}
