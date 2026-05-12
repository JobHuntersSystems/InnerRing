using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace PACS_InheratedControls
{
    public class PacsBaseButton : Button
    {
        protected Color BorderColor = Color.FromArgb(30, 106, 122);
        protected Color BorderHoverColor = Color.FromArgb(0, 200, 224);
        protected Color InnerBorderColor = Color.FromArgb(10, 48, 64);
        protected Color GlyphColor = Color.FromArgb(0, 200, 224);

        private bool _hovered = false;

        [Category("PACS")]
        private bool _DefaultClickEvent = true;
        public bool DefaultClickEvent
        {
            get { return _DefaultClickEvent; }
            set { _DefaultClickEvent = value; }
        }

        public PacsBaseButton()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            Size = new Size(28, 22);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.FromArgb(10, 24, 32);
            Font = new Font("Courier New", 10f, FontStyle.Bold);
            Cursor = Cursors.Hand;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = ClientRectangle;

            // Fondo
            using (var bg = new SolidBrush(BackColor))
                g.FillRectangle(bg, r);

            // Borde exterior
            Color bc = _hovered ? BorderHoverColor : BorderColor;
            using (var pen = new Pen(bc, 1))
                g.DrawRectangle(pen, 0, 0, r.Width - 1, r.Height - 1);

            // Borde interior (efecto sci-fi doble línea)
            using (var pen = new Pen(_hovered ? BorderColor : InnerBorderColor, 1))
                g.DrawRectangle(pen, 2, 2, r.Width - 5, r.Height - 5);

            // Glifo centrado
            TextRenderer.DrawText(g, Text, Font,
                new Rectangle(0, 0, r.Width, r.Height),
                GlyphColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PacsBaseButton
            // 
            this.MouseEnter += new System.EventHandler(this.PacsBaseButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PacsBaseButton_MouseLeave);
            this.ResumeLayout(false);

        }

        private void PacsBaseButton_MouseEnter(object sender, System.EventArgs e)
        {
            _hovered = true;
            Invalidate();
        }

        private void PacsBaseButton_MouseLeave(object sender, System.EventArgs e)
        {
            _hovered = false;
            Invalidate();
        }
    }
}
