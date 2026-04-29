using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace PACS_CustomControls
{
    public partial class OptionButton : UserControl
    {
        private bool isHovered = false;
        private bool isPressed = false;
        private bool isSelected = false;

        private string _OptionText = "PLACE HOLDER";

        [Category("PACS")]
        [Description("Text displayed inside the option button. You can use line breaks with \\n.")]
        public string OptionText
        {
            get { return _OptionText; }
            set
            {
                _OptionText = value;
                Invalidate();
            }
        }

        private Image _OptionIcon;

        [Category("PACS")]
        [Description("Icon displayed on the left side of the option button.")]
        public Image OptionIcon
        {
            get { return _OptionIcon; }
            set
            {
                _OptionIcon = value;
                Invalidate();
            }
        }

        [Category("PACS")]
        [Description("Indicates whether the option button is currently selected.")]
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                Invalidate();
            }
        }

        private Color _AccentColor = Color.FromArgb(120, 230, 120);

        [Category("PACS")]
        [Description("Main accent color used for borders and normal visual highlights.")]
        public Color AccentColor
        {
            get { return _AccentColor; }
            set
            {
                _AccentColor = value;
                Invalidate();
            }
        }

        private Color _AccentHoverColor = Color.FromArgb(0, 220, 255);

        [Category("PACS")]
        [Description("Accent color used when the mouse is over the option button or when it is selected.")]
        public Color AccentHoverColor
        {
            get { return _AccentHoverColor; }
            set
            {
                _AccentHoverColor = value;
                Invalidate();
            }
        }

        private Color _BackgroundPanelColor = Color.FromArgb(24, 28, 30);

        [Category("PACS")]
        [Description("Background color of the option button body.")]
        public Color BackgroundPanelColor
        {
            get { return _BackgroundPanelColor; }
            set
            {
                _BackgroundPanelColor = value;
                Invalidate();
            }
        }

        private Color _TextColor = Color.FromArgb(160, 240, 150);

        [Category("PACS")]
        [Description("Text color used when the option button is not hovered or selected.")]
        public Color TextColor
        {
            get { return _TextColor; }
            set
            {
                _TextColor = value;
                Invalidate();
            }
        }

        private Color _BorderDarkColor = Color.FromArgb(35, 38, 38);

        [Category("PACS")]
        [Description("Dark metallic color used in the outer frame.")]
        public Color BorderDarkColor
        {
            get { return _BorderDarkColor; }
            set
            {
                _BorderDarkColor = value;
                Invalidate();
            }
        }

        private Color _BorderLightColor = Color.FromArgb(95, 105, 95);

        [Category("PACS")]
        [Description("Light metallic color used for highlights in the outer frame.")]
        public Color BorderLightColor
        {
            get { return _BorderLightColor; }
            set
            {
                _BorderLightColor = value;
                Invalidate();
            }
        }

        private string _ClassName;
        [Category("PACS")]
        [Description("")]   
        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }

        private string _FormName;
        [Category("PACS")]
        [Description("")]
        public string FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }
        
        public OptionButton()
        {
            InitializeComponent();

            this.MouseEnter += new EventHandler(OptionButton_MouseEnter);
            this.MouseLeave += new EventHandler(OptionButton_MouseLeave);
            this.MouseDown += new MouseEventHandler(OptionButton_MouseDown);
            this.MouseUp += new MouseEventHandler(OptionButton_MouseLeave);
            this.Click += Control_Click;

            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true
            );

            UpdateStyles();
        }

        #region Event "Control_Click"
        //formTypes guarda el tipo del formulario cogido del .dll para poder instanciarlo
        private Type formType;
        private Form getDllForm()
        {
            Object dllForm = null;
         
            Assembly assembly;
            assembly = Assembly.LoadFrom(_ClassName);

            formType = assembly.GetType(_FormName);
            if (formType == null)
                throw new Exception($"Form type not found: {_FormName}");

            dllForm = Activator.CreateInstance(formType);

            return (Form)dllForm;
        }
        //Este método habre un formulario dentro de un panel especifico que esté creado en el form pasado como Argumento "parentForm"
        private void openFormByDll(Form dllForm , Form parentForm)
        {
            foreach (Control ctrl in parentForm.Controls)
            {
                if (ctrl is Panel && ((Panel)ctrl).Name == "pnlMain")
                {
                    dllForm.TopLevel = false;

                    dllForm.FormBorderStyle = FormBorderStyle.None;

                    ctrl.Controls.Add(dllForm);
                    dllForm.Dock = DockStyle.Fill;
                    dllForm.BringToFront();
                    dllForm.Show();
                    break;
                }
            }
        }

        private void Control_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_ClassName) || string.IsNullOrWhiteSpace(_FormName))
                    throw new Exception("OptionButton properties FormName and ClassName are not set.");

                Form dllForm = getDllForm();

                if (dllForm != null)
                {
                    bool formLoaded = false;
                    Form parentForm = this.FindForm();

                    //Buscamos si ya hay algún formulario abierto del mismo tipo de la ddl. Si se encuentra, se trae al frente.
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm.GetType() == formType)
                        {
                            formLoaded = true;
                            frm.BringToFront();
                        }
                    }
                    // en caso de no se encontrado, se abre.
                    if (!formLoaded)
                    {
                        openFormByDll(dllForm, parentForm);
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Events UI
        private void OptionButton_MouseEnter(object sender, EventArgs e)
        {
            isHovered = true;
            this.Invalidate();
        }

        private void OptionButton_MouseLeave(object sender, EventArgs e)
        {
            isHovered = false;
            isPressed = false;
            this.Invalidate();
        }

        private void OptionButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isPressed = true;
                this.Invalidate();
            }
        }

        private void OptionButton_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            this.Invalidate();
        }
        #endregion
        #region UI_Designe
        protected override void OnPaintBackground(PaintEventArgs e)
        {
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.None;
            g.PixelOffsetMode = PixelOffsetMode.Half;

            Rectangle fullRect = new Rectangle(0, 0, Width - 1, Height - 1);

            Color currentAccent = isHovered || isSelected
                ? _AccentHoverColor
                : _AccentColor;

            Color currentBackground = isPressed
                ? Color.FromArgb(15, 22, 25)
                : _BackgroundPanelColor;

            DrawMetalBackground(g, fullRect, currentBackground);
            DrawOuterMetalFrame(g, fullRect);
            DrawInnerTechFrame(g, fullRect, currentAccent);
            DrawCornerDamage(g, fullRect);
            DrawButtonContent(g, fullRect, currentAccent);
        }

        private void DrawMetalBackground(Graphics g, Rectangle rect, Color baseColor)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(34, 38, 40),
                baseColor,
                LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, rect);
            }

            using (Pen p = new Pen(Color.FromArgb(10, 10, 10), 2))
            {
                g.DrawLine(p, 8, 8, rect.Width - 8, 8);
            }

            using (Pen p = new Pen(Color.FromArgb(45, 50, 50), 1))
            {
                for (int y = 12; y < rect.Height - 10; y += 9)
                {
                    g.DrawLine(p, 16, y, rect.Width - 16, y);
                }
            }
        }

        private void DrawOuterMetalFrame(Graphics g, Rectangle rect)
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

                using (Pen darkPen = new Pen(Color.FromArgb(18, 20, 20), 4))
                using (Pen metalPen = new Pen(_BorderDarkColor, 2))
                using (Pen highlightPen = new Pen(_BorderLightColor, 1))
                {
                    g.DrawPath(darkPen, path);
                    g.DrawPath(metalPen, path);
                    g.DrawPath(highlightPen, path);
                }
            }
        }

        private void DrawInnerTechFrame(Graphics g, Rectangle rect, Color accent)
        {
            Rectangle inner = new Rectangle(7, 7, rect.Width - 14, rect.Height - 14);

            using (Pen shadow = new Pen(Color.FromArgb(5, 5, 5), 2))
            using (Pen metal = new Pen(Color.FromArgb(70, 75, 72), 1))
            using (Pen glow = new Pen(Color.FromArgb(90, accent.R, accent.G, accent.B), 1))
            {
                g.DrawRectangle(shadow, inner);
                g.DrawRectangle(metal, inner.X + 2, inner.Y + 2, inner.Width - 4, inner.Height - 4);

                int corner = 22;

                g.DrawLine(glow, inner.Left + 4, inner.Top + 4, inner.Left + corner, inner.Top + 4);
                g.DrawLine(glow, inner.Left + 4, inner.Top + 4, inner.Left + 4, inner.Top + corner);

                g.DrawLine(glow, inner.Right - corner, inner.Top + 4, inner.Right - 4, inner.Top + 4);
                g.DrawLine(glow, inner.Right - 4, inner.Top + 4, inner.Right - 4, inner.Top + corner);

                g.DrawLine(glow, inner.Left + 4, inner.Bottom - 4, inner.Left + corner, inner.Bottom - 4);
                g.DrawLine(glow, inner.Left + 4, inner.Bottom - corner, inner.Left + 4, inner.Bottom - 4);

                g.DrawLine(glow, inner.Right - corner, inner.Bottom - 4, inner.Right - 4, inner.Bottom - 4);
                g.DrawLine(glow, inner.Right - 4, inner.Bottom - corner, inner.Right - 4, inner.Bottom - 4);
            }
        }

        private void DrawCornerDamage(Graphics g, Rectangle rect)
        {
            DrawDamageCluster(g, 4, 4, 2);
            DrawDamageCluster(g, rect.Width - 24, 4, 2);
            DrawDamageCluster(g, 4, rect.Height - 22, 2);
            DrawDamageCluster(g, rect.Width - 24, rect.Height - 22, 2);
        }

        private void DrawDamageCluster(Graphics g, int startX, int startY, int size)
        {
            int[,] pixels =
            {
                {0, 0}, {3, 0}, {6, 0},
                {0, 3}, {2, 3}, {5, 3}, {9, 3},
                {0, 6}, {4, 6}, {8, 6},
                {2, 9}, {6, 9},
                {0, 12}, {4, 12}
            };

            Color[] colors =
            {
                Color.FromArgb(90, 100, 90),
                Color.FromArgb(40, 45, 40),
                Color.FromArgb(120, 140, 110),
                Color.FromArgb(15, 18, 15)
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

        private void DrawButtonContent(Graphics g, Rectangle rect, Color accent)
        {
            Rectangle iconRect = new Rectangle(22, 15, 34, 34);
            Rectangle textRect = new Rectangle(72, 8, rect.Width - 82, rect.Height - 16);

            if (_OptionIcon != null)
            {
                g.DrawImage(_OptionIcon, iconRect);
            }

            using (Brush textBrush = new SolidBrush(isHovered || isSelected ? accent : _TextColor))
            using (Font font = new Font("Consolas", 16F, FontStyle.Bold, GraphicsUnit.Pixel))
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Near;
                sf.LineAlignment = StringAlignment.Center;

                g.DrawString(_OptionText, font, textBrush, textRect, sf);
            }
        }
        #endregion
    }

}