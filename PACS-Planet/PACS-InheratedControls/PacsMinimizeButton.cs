using System.Drawing;
using System.Windows.Forms;
namespace PACS_InheratedControls
{
    public class PacsMinimizeButton : PacsBaseButton
    {
        public PacsMinimizeButton()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(10, 24, 32);
            BorderColor = Color.FromArgb(30, 106, 122);
            BorderHoverColor = Color.FromArgb(0, 200, 224);
            InnerBorderColor = Color.FromArgb(10, 48, 64);
            GlyphColor = Color.FromArgb(0, 200, 224);
            Text = "─";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PacsMinimizeButton
            // 
            this.FlatAppearance.BorderSize = 0;
            this.Click += new System.EventHandler(this.PacsMinimizeButton_Click);
            this.ResumeLayout(false);

        }

        private void PacsMinimizeButton_Click(object sender, System.EventArgs e)
        {
            if (DefaultClickEvent)
            {
                Form frm = this.FindForm();
                frm.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
