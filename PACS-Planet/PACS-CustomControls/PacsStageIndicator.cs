using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PACS_CustomControls
{
    public partial class PacsStageIndicator : UserControl
    {
        private Color borderDarkColor = Color.FromArgb(22, 24, 24);
        private Color borderMidColor = Color.FromArgb(55, 60, 58);
        private Color borderLightColor = Color.FromArgb(95, 105, 95);

        private Color panelTopColor = Color.FromArgb(25, 29, 30);
        private Color panelBottomColor = Color.FromArgb(8, 12, 16);
        private Color innerBackgroundColor = Color.FromArgb(2, 5, 8);

        private Color offColor = Color.FromArgb(20, 25, 20);
        private Color greenColor = Color.FromArgb(166, 255, 0);
        private Color redColor = Color.FromArgb(255, 48, 48);
        private Color amberColor = Color.FromArgb(255, 208, 0);

        private bool stage1Completed = false;
        private bool stage2Completed = false;
        private bool stage3Completed = false;

        private int failStage = 0;
        private int failBlinkCounter = 0;
        private bool failBlinkState = false;

        public PacsStageIndicator()
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

            ResetStages();
        }

        public void CompleteStage(int stage)
        {
            if (stage == 1)
                stage1Completed = true;

            if (stage == 2)
                stage2Completed = true;

            if (stage == 3)
                stage3Completed = true;

            RefreshBulbs();
            Invalidate();
        }

        public void FailStage(int stage)
        {
            failStage = stage;
            failBlinkCounter = 0;
            failBlinkState = false;

            tmrFailAnimation.Stop();
            tmrFailAnimation.Start();
        }

        public void ResetStages()
        {
            stage1Completed = false;
            stage2Completed = false;
            stage3Completed = false;

            failStage = 0;
            failBlinkCounter = 0;
            failBlinkState = false;

            tmrFailAnimation.Stop();

            RefreshBulbs();
            Invalidate();
        }

        private void RefreshBulbs()
        {
            bulbStage1.BackColor = stage1Completed ? greenColor : offColor;
            bulbStage2.BackColor = stage2Completed ? greenColor : offColor;
            bulbStage3.BackColor = stage3Completed ? greenColor : offColor;

            bulbStage1.Invalidate();
            bulbStage2.Invalidate();
            bulbStage3.Invalidate();
        }

        private void tmrFailAnimation_Tick(object sender, EventArgs e)
        {
            failBlinkCounter++;
            failBlinkState = !failBlinkState;

            Panel targetBulb = GetBulbByStage(failStage);

            if (targetBulb != null)
            {
                if (failBlinkState)
                    targetBulb.BackColor = redColor;
                else
                    targetBulb.BackColor = offColor;

                targetBulb.Invalidate();
            }

            if (failBlinkCounter >= 8)
            {
                tmrFailAnimation.Stop();
                failBlinkCounter = 0;
                failBlinkState = false;
                failStage = 0;

                RefreshBulbs();
            }
        }

        private Panel GetBulbByStage(int stage)
        {
            if (stage == 1)
                return bulbStage1;

            if (stage == 2)
                return bulbStage2;

            if (stage == 3)
                return bulbStage3;

            return null;
        }

        private void bulbStage_Paint(object sender, PaintEventArgs e)
        {
            Panel bulb = (Panel)sender;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Color bulbColor = bulb.BackColor;

            Rectangle outer = new Rectangle(1, 1, bulb.Width - 3, bulb.Height - 3);
            Rectangle inner = new Rectangle(5, 5, bulb.Width - 11, bulb.Height - 11);

            using (SolidBrush background = new SolidBrush(Color.FromArgb(5, 8, 8)))
            {
                e.Graphics.FillRectangle(background, bulb.ClientRectangle);
            }

            using (Pen shadow = new Pen(Color.FromArgb(0, 0, 0), 3))
            using (Pen border = new Pen(Color.FromArgb(55, 65, 55), 1))
            {
                e.Graphics.DrawEllipse(shadow, outer);
                e.Graphics.DrawEllipse(border, outer);
            }

            using (SolidBrush brush = new SolidBrush(bulbColor))
            {
                e.Graphics.FillEllipse(brush, inner);
            }

            if (bulbColor == greenColor || bulbColor == redColor)
            {
                using (Pen glow = new Pen(Color.FromArgb(180, bulbColor), 3))
                {
                    e.Graphics.DrawEllipse(glow, new Rectangle(2, 2, bulb.Width - 5, bulb.Height - 5));
                }

                using (SolidBrush shine = new SolidBrush(Color.FromArgb(190, Color.White)))
                {
                    e.Graphics.FillEllipse(shine, inner.X + 4, inner.Y + 3, 4, 4);
                }
            }
            else
            {
                using (Pen dim = new Pen(Color.FromArgb(55, 75, 55), 1))
                {
                    e.Graphics.DrawEllipse(dim, inner);
                }
            }
        }

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
            Rectangle innerRect = new Rectangle(16, 16, Width - 32, Height - 32);

            DrawMainBackground(g, outerRect);
            DrawOuterFrame(g, outerRect);
            DrawInnerBox(g, innerRect);
            DrawVerticalConnector(g);
            DrawHorizontalDecorations(g);
            DrawCornerDamage(g, outerRect);
        }

        private void DrawMainBackground(Graphics g, Rectangle rect)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                panelTopColor,
                panelBottomColor,
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

        private void DrawInnerBox(Graphics g, Rectangle rect)
        {
            using (Brush b = new SolidBrush(innerBackgroundColor))
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

            using (Pen p = new Pen(Color.FromArgb(10, 20, 12), 1))
            {
                for (int y = rect.Y + 8; y < rect.Bottom - 8; y += 6)
                {
                    g.DrawLine(p, rect.X + 8, y, rect.Right - 8, y);
                }
            }
        }

        private void DrawVerticalConnector(Graphics g)
        {
            int x = 49;

            using (Pen offPen = new Pen(Color.FromArgb(55, 70, 55), 2))
            {
                g.DrawLine(offPen, x, 67, x, 92);
                g.DrawLine(offPen, x, 114, x, 139);
            }

            using (Pen glowPen = new Pen(Color.FromArgb(120, greenColor), 1))
            {
                if (stage1Completed)
                    g.DrawLine(glowPen, x + 3, 67, x + 3, 92);

                if (stage2Completed)
                    g.DrawLine(glowPen, x + 3, 114, x + 3, 139);
            }

            using (Pen amberPen = new Pen(Color.FromArgb(70, amberColor), 1))
            {
                g.DrawLine(amberPen, x - 7, 50, x - 7, 161);
            }
        }

        private void DrawHorizontalDecorations(Graphics g)
        {
            using (Pen p = new Pen(Color.FromArgb(40, 55, 55), 1))
            {
                g.DrawLine(p, 210, 54, Width - 38, 54);
                g.DrawLine(p, 210, 101, Width - 38, 101);
                g.DrawLine(p, 210, 148, Width - 38, 148);
            }

            using (Pen p = new Pen(Color.FromArgb(25, 35, 35), 1))
            {
                g.DrawLine(p, 235, 65, Width - 60, 65);
                g.DrawLine(p, 235, 112, Width - 60, 112);
                g.DrawLine(p, 235, 159, Width - 60, 159);
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
    }
}