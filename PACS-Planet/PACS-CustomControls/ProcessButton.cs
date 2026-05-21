using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PACS_CustomControls
{
    public partial class ProcessButton : UserControl
    {
        private bool isHovered = false;
        private bool isPressed = false;

        private string _ButtonText = "EXECUTE PROCESS";
        [Category("PACS")]
        [Description("Texto que indica la acción del proceso.")]
        public string ButtonText
        {
            get { return _ButtonText; }
            set { _ButtonText = value; Invalidate(); }
        }

        private Color _ThemeColor = Color.FromArgb(255, 140, 0); // Naranja alerta por defecto
        [Category("PACS")]
        [Description("El color de luz neón cuando el botón está activado (Enabled = true).")]
        public Color ThemeColor
        {
            get { return _ThemeColor; }
            set { _ThemeColor = value; Invalidate(); }
        }

        public ProcessButton()
        {
            InitializeComponent();

            this.MouseEnter += new EventHandler(ProcessButton_MouseEnter);
            this.MouseLeave += new EventHandler(ProcessButton_MouseLeave);
            this.MouseDown += new MouseEventHandler(ProcessButton_MouseDown);
            this.MouseUp += new MouseEventHandler(ProcessButton_MouseUp);

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );
            UpdateStyles();

            this.Cursor = Cursors.Hand;
        }

        // Sobrescribimos el evento nativo para forzar un repintado cuando cambia la "energía"
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            // Si se desactiva, quitamos el hover para evitar bugs visuales
            if (!this.Enabled) isHovered = false;
            Invalidate();
        }

        #region Eventos de Ratón
        private void ProcessButton_MouseEnter(object sender, EventArgs e)
        {
            if (!this.Enabled) return;
            isHovered = true;
            this.Invalidate();
        }

        private void ProcessButton_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            isPressed = false;
            this.Invalidate();
        }

        private void ProcessButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!this.Enabled) return;
            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                this.Invalidate();
            }
        }

        private void ProcessButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!this.Enabled) return;
            isPressed = false;
            this.Invalidate();
        }
        #endregion

        #region Renderizado GDI+ (El núcleo holográfico)
        protected override void OnPaintBackground(PaintEventArgs e) { /* Fondo transparente manejado manualmente */ }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Bordes más suaves para cortes diagonales

            // Cálculo del estado de energía (Apagado vs Encendido)
            Color neonColor = this.Enabled ? _ThemeColor : Color.FromArgb(40, 45, 50);
            Color bgColor1 = this.Enabled ? Color.FromArgb(35, 40, 45) : Color.FromArgb(20, 22, 24);
            Color bgColor2 = this.Enabled
                ? (isPressed ? Color.FromArgb(15, 20, 25) : Color.FromArgb(20, 25, 30))
                : Color.FromArgb(15, 17, 19);
            Color textColor = this.Enabled
                ? (isHovered ? Color.White : Color.FromArgb(220, 230, 240))
                : Color.FromArgb(80, 85, 90);
            Color borderColor = this.Enabled ? _ThemeColor : Color.FromArgb(50, 55, 60);

            // Geometría del botón: Un rectángulo con la esquina superior derecha cortada (estilo nave espacial)
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            int cutSize = 15;

            Point[] buttonShape = {
                new Point(0, 0),
                new Point(rect.Width - cutSize, 0),
                new Point(rect.Width, cutSize),
                new Point(rect.Width, rect.Height),
                new Point(0, rect.Height)
            };

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(buttonShape);

                // 1. Dibujar el chasis metálico (Fondo)
                using (LinearGradientBrush bgBrush = new LinearGradientBrush(rect, bgColor1, bgColor2, LinearGradientMode.Vertical))
                {
                    g.FillPath(bgBrush, path);
                }

                // Si está enabled y hovered, damos un sutil resplandor de fondo
                if (this.Enabled && isHovered)
                {
                    using (SolidBrush glowBrush = new SolidBrush(Color.FromArgb(20, _ThemeColor.R, _ThemeColor.G, _ThemeColor.B)))
                    {
                        g.FillPath(glowBrush, path);
                    }
                }

                // 2. Dibujar borde exterior
                using (Pen borderPen = new Pen(borderColor, isHovered ? 2 : 1))
                {
                    g.DrawPath(borderPen, path);
                }
            }

            // 3. Dibujar Indicador LED de Energía (Izquierda)
            DrawPowerLED(g, neonColor);

            // 4. Dibujar texturas de "agarre" / scanlines sutiles (Derecha)
            DrawGripLines(g, this.Enabled);

            // 5. Dibujar el Texto
            DrawText(g, textColor);
        }

        private void DrawPowerLED(Graphics g, Color ledColor)
        {
            Rectangle ledRect = new Rectangle(6, 6, 8, Height - 12);

            using (SolidBrush ledBrush = new SolidBrush(ledColor))
            {
                g.FillRectangle(ledBrush, ledRect);
            }

            // Brillo interior del LED para dar volumen
            using (Pen highlight = new Pen(Color.FromArgb(100, 255, 255, 255), 1))
            using (Pen shadow = new Pen(Color.FromArgb(100, 0, 0, 0), 1))
            {
                g.DrawLine(highlight, ledRect.Left, ledRect.Top, ledRect.Right, ledRect.Top);
                g.DrawLine(highlight, ledRect.Left, ledRect.Top, ledRect.Left, ledRect.Bottom);
                g.DrawLine(shadow, ledRect.Right, ledRect.Top, ledRect.Right, ledRect.Bottom);
                g.DrawLine(shadow, ledRect.Left, ledRect.Bottom, ledRect.Right, ledRect.Bottom);
            }
        }

        private void DrawGripLines(Graphics g, bool isPowered)
        {
            Color lineCol = isPowered ? Color.FromArgb(60, 70, 75) : Color.FromArgb(30, 35, 40);
            using (Pen linePen = new Pen(lineCol, 2))
            {
                int startX = Width - 30;
                int startY = Height / 2 - 10;
                for (int i = 0; i < 4; i++)
                {
                    g.DrawLine(linePen, startX + (i * 5), startY, startX + (i * 5), startY + 20);
                }
            }
        }

        private void DrawText(Graphics g, Color textColor)
        {
            Rectangle textRect = new Rectangle(24, 0, Width - 60, Height);
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (Font font = new Font("Consolas", 11F, FontStyle.Bold))
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(_ButtonText, font, textBrush, textRect, sf);
            }
        }
        #endregion
    }
}