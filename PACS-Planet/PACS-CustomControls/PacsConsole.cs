using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;
using PACS_Common;

namespace PACS_CustomControls
{
    public partial class PacsConsole : UserControl
    {

        private Color borderDarkColor = Color.FromArgb(22, 24, 24);
        private Color borderMidColor = Color.FromArgb(55, 60, 58);
        private Color borderLightColor = Color.FromArgb(95, 105, 95);
        private Color accentColor = Color.FromArgb(0, 220, 255);
        private Color consoleBackground = Color.FromArgb(2, 5, 8);

        public PacsConsole()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            DoubleBuffered = true;
            UpdateStyles();

            rtbConsole.BackColor = consoleBackground;
            rtbConsole.ForeColor = Color.FromArgb(130, 220, 105);
            rtbConsole.Font = new Font("Consolas", 9F, FontStyle.Regular);
            rtbConsole.BorderStyle = BorderStyle.None;
            rtbConsole.ReadOnly = true;
        }


        private string _ConsoleTitle = "SYSTEM LOG CONSOLE";
        [Category("PACS")]
        public string ConsoleTitle
        {
            get { return _ConsoleTitle; }
            set
            {
                _ConsoleTitle = value;
                lblTitle.Text = value;
                Invalidate();
            }
        }

        private Color _AccentColor;
        [Category("PACS")]
        public Color AccentColor
        {
            get { return _AccentColor; }
            set
            {
                _AccentColor = value;
                lblTitle.ForeColor = value;
                Invalidate();
            }
        }

        private Dictionary<LogLevel, (string Label, Color Color)> _logConfig { get; } =
            new Dictionary<LogLevel, (string, Color)>
            {
                { LogLevel.Info,    ("INFO",  Color.FromArgb(166, 255,   0)) }, // Verde lima
                { LogLevel.Warn,    ("WARN",  Color.FromArgb(255, 208,   0)) }, // Amarillo fuerte
                { LogLevel.Error,   ("ERRO",  Color.FromArgb(255,  48,  48)) }, // Rojo intenso
                { LogLevel.Success, ("SUCC",  Color.FromArgb(  0, 255, 136)) }, // Verde esmeralda
                { LogLevel.Message, ("MESS",  Color.FromArgb(102, 175, 255)) }  // Azul claro
            };
        public void AddLog(LogLevel type, string message)
        {
            try
            {
                var config = _logConfig[type];
                AddLine(config.Label, message, config.Color);

            }
            catch(Exception ex)
            {

            }
         
        }

        public void ClearConsole()
        {
            rtbConsole.Clear();
        }
        public void AddData(string data)
        {
            rtbConsole.SelectionColor = Color.White;
            rtbConsole.AppendText(data);

            rtbConsole.SelectionStart = rtbConsole.TextLength;
            rtbConsole.ScrollToCaret();
        }
        private void AddLine(string level, string message, Color color)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss");

            rtbConsole.SelectionStart = rtbConsole.TextLength;
            rtbConsole.SelectionLength = 0;

            rtbConsole.SelectionColor = Color.FromArgb(130, 220, 105);
            rtbConsole.AppendText($"[{timestamp}] ");

            rtbConsole.SelectionColor = color;
            rtbConsole.AppendText($"[{level.PadRight(4)}] {message}\n");


            rtbConsole.SelectionStart = rtbConsole.TextLength;
            rtbConsole.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearConsole();
        }

        #region UI_Design
        protected override void OnPaintBackground(PaintEventArgs e)
        {          
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.None;
            g.PixelOffsetMode = PixelOffsetMode.Half;

            Rectangle outerRect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle titleRect = new Rectangle(12, 8, Width - 24, 26);
            Rectangle consoleRect = new Rectangle(16, 38, Width - 32, Height - 50);

            DrawMainBackground(g, outerRect);
            DrawOuterFrame(g, outerRect);
            DrawTitleSeparator(g, titleRect);
            DrawConsoleBox(g, consoleRect);
            DrawCornerDamage(g, outerRect);
        }

        private void DrawMainBackground(Graphics g, Rectangle rect)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(25, 29, 30),
                Color.FromArgb(8, 12, 16),
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect);
            }
        }

        private void DrawOuterFrame(Graphics g, Rectangle rect)
        {
            Point[] outer =
            {
                new Point(10, 0),
                new Point(rect.Width - 10, 0),
                new Point(rect.Width, 10),
                new Point(rect.Width, rect.Height - 10),
                new Point(rect.Width - 10, rect.Height),
                new Point(10, rect.Height),
                new Point(0, rect.Height - 10),
                new Point(0, 10)
            };

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(outer);

                using (Pen shadow = new Pen(Color.FromArgb(5, 5, 5), 4))
                using (Pen dark = new Pen(borderDarkColor, 2))
                using (Pen mid = new Pen(borderMidColor, 1))
                using (Pen light = new Pen(borderLightColor, 1))
                {
                    g.DrawPath(shadow, path);
                    g.DrawPath(dark, path);

                    Rectangle inner1 = new Rectangle(4, 4, rect.Width - 8, rect.Height - 8);
                    Rectangle inner2 = new Rectangle(8, 8, rect.Width - 16, rect.Height - 16);

                    g.DrawRectangle(mid, inner1);
                    g.DrawRectangle(light, inner2);
                }
            }

            using (Pen topHighlight = new Pen(Color.FromArgb(85, 90, 85), 1))
            using (Pen bottomShadow = new Pen(Color.FromArgb(5, 5, 5), 2))
            {
                g.DrawLine(topHighlight, 22, 6, rect.Width - 22, 6);
                g.DrawLine(bottomShadow, 22, rect.Height - 7, rect.Width - 22, rect.Height - 7);
            }
        }

        private void DrawTitleSeparator(Graphics g, Rectangle titleRect)
        {
            int y = titleRect.Bottom + 2;

            using (Pen dark = new Pen(Color.FromArgb(5, 5, 5), 2))
            using (Pen mid = new Pen(Color.FromArgb(55, 60, 58), 1))
            {
                g.DrawLine(dark, 12, y, Width - 12, y);
                g.DrawLine(mid, 14, y + 2, Width - 14, y + 2);
            }
        }

        private void DrawConsoleBox(Graphics g, Rectangle rect)
        {
            using (Brush b = new SolidBrush(consoleBackground))
            {
                g.FillRectangle(b, rect);
            }

            using (Pen shadow = new Pen(Color.FromArgb(0, 0, 0), 3))
            using (Pen mid = new Pen(Color.FromArgb(35, 42, 42), 1))
            using (Pen greenDark = new Pen(Color.FromArgb(45, 70, 45), 1))
            {
                g.DrawRectangle(shadow, rect);
                g.DrawRectangle(mid, rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);
                g.DrawRectangle(greenDark, rect.X + 4, rect.Y + 4, rect.Width - 8, rect.Height - 8);
            }

            // Textura interior muy sutil
            using (Pen p = new Pen(Color.FromArgb(10, 20, 12), 1))
            {
                for (int y = rect.Y + 8; y < rect.Bottom - 8; y += 6)
                {
                    g.DrawLine(p, rect.X + 8, y, rect.Right - 8, y);
                }
            }
        }

        private void DrawCornerDamage(Graphics g, Rectangle rect)
        {
            Color[] damageColors =
            {
                Color.FromArgb(110, 120, 105),
                Color.FromArgb(50, 55, 50),
                Color.FromArgb(20, 22, 20),
                Color.FromArgb(140, 150, 120)
            };

            DrawDamageCluster(g, 8, 8, damageColors, 2);
            DrawDamageCluster(g, rect.Width - 28, 8, damageColors, 2);
            DrawDamageCluster(g, 8, rect.Height - 26, damageColors, 2);
            DrawDamageCluster(g, rect.Width - 28, rect.Height - 26, damageColors, 2);
        }

        private void DrawDamageCluster(Graphics g, int startX, int startY, Color[] colors, int size)
        {
            int[,] pixels =
            {
                {0, 0}, {3, 0}, {6, 0}, {10, 0},
                {0, 3}, {2, 3}, {5, 3}, {9, 3},
                {0, 6}, {4, 6}, {8, 6},
                {2, 9}, {6, 9}, {11, 9},
                {0, 12}, {4, 12}, {8, 12}
            };

            for (int i = 0; i < pixels.GetLength(0); i++)
            {
                using (Brush b = new SolidBrush(colors[i % colors.Length]))
                {
                    g.FillRectangle(
                        b,
                        startX + pixels[i, 0],
                        startY + pixels[i, 1],
                        size,
                        size
                    );
                }
            }
        }
        #endregion
    }
}