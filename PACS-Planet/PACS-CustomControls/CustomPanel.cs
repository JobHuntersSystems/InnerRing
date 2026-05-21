using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PACS_CustomControls
{
    public partial class CustomPanel : Panel
    {
        [Category("PACS - Apariencia")]
        public Color ColorArriba { get; set; } = Color.FromArgb(128, 255, 255, 255);

        [Category("PACS - Apariencia")]
        public Color ColorAbajo { get; set; } = Color.FromArgb(50, 255, 255, 255);

        [Category("PACS - Apariencia")]
        public float Angulo { get; set; } = 90f;

        [Category("PACS - Bordes")]
        public Color ColorBordeNeon { get; set; } = Color.FromArgb(150, 0, 240, 255);

        [Category("PACS - Bordes")]
        public int GrosorBorde { get; set; } = 1;

        public CustomPanel()
        {
            // Esto inicializa los componentes del archivo designer
            InitializeComponent();

            // Configuramos el panel para evitar parpadeos y permitir transparencias
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);

            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.Width > 0 && this.Height > 0)
            {
                // 1. Dibuja el degradado
                using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, ColorArriba, ColorAbajo, Angulo))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }

                // 2. Dibuja el borde de neón
                if (GrosorBorde > 0)
                {
                    using (Pen neonBorder = new Pen(ColorBordeNeon, GrosorBorde))
                    {
                        int ajuste = GrosorBorde / 2;
                        Rectangle rectBorde = new Rectangle(
                            ajuste,
                            ajuste,
                            this.Width - GrosorBorde,
                            this.Height - GrosorBorde
                        );

                        e.Graphics.DrawRectangle(neonBorder, rectBorde);
                    }
                }
            }
        }
    }
}