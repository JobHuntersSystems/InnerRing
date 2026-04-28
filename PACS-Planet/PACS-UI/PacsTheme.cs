using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PACS_UI
{
    public static class PacsTheme
    {
        public static Color Background { get; } = Color.FromArgb(6, 10, 16);
        public static Color Panel { get; } = Color.FromArgb(20, 25, 35);
        public static Color NeonGreen { get; } = Color.Lime;
        public static Color NeonCyan { get; } = Color.Cyan;
        public static Color Warning { get; } = Color.Orange;
        public static Color Danger { get; } = Color.Red;

        public static Font TitleFont { get; } = new Font("Consolas", 14, FontStyle.Bold);
        public static Font NormalFont { get; } = new Font("Consolas", 10, FontStyle.Regular);
    }
}
