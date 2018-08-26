using Screenfix.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Screenfix
{
    public struct ColorMode
    {
        public readonly Color Color;
        public readonly int Time;

        public ColorMode(Color C, int T)
        {
            Color = C;
            Time = T;
        }
    }

    public struct ScreenInfo
    {
        public Screen Screen
        {
            get
            {
                return Screen.AllScreens[ScreenId];
            }
        }

        public int ScreenId;

        public ScreenInfo(int Index)
        {
            ScreenId = Index;
        }

        public override string ToString()
        {
            var S = Screen.AllScreens[ScreenId];
            return $"Screen {ScreenId}: {S.Bounds.Width}x{S.Bounds.Height}";
        }
    }
    static class Program
    {
        public static ColorMode[] Modes
        {
            get
            {
                return M.ToArray();
            }
        }

        public static Cursor Invisible
        { get; private set; }

        private static List<ColorMode> M;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const int TIME_LONG = 500;
            const int TIME_SHORT = 100;

            using (var MS = new MemoryStream(Resources.invisible, false))
            {
                Invisible = new Cursor(MS);
            }

            M = new List<ColorMode>();
            M.Add(new ColorMode(Color.FromArgb(0xFF, 0, 0), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0, 0xFF, 0), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0, 0, 0xFF), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0xFF, 0xFF, 0), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0xFF, 0, 0xFF), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0, 0xFF, 0xFF), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0xFF, 0xFF, 0xFF), TIME_LONG));
            M.Add(new ColorMode(Color.FromArgb(0, 0, 0), TIME_LONG));

            M.Add(new ColorMode(Color.FromArgb(0xFF, 0xFF, 0xFF), TIME_SHORT));
            M.Add(new ColorMode(Color.FromArgb(0, 0, 0), TIME_SHORT));
            M.Add(new ColorMode(Color.FromArgb(0xFF, 0xFF, 0xFF), TIME_SHORT));
            M.Add(new ColorMode(Color.FromArgb(0, 0, 0), TIME_SHORT));
            M.Add(new ColorMode(Color.FromArgb(0xFF, 0xFF, 0xFF), TIME_SHORT));
            M.Add(new ColorMode(Color.FromArgb(0, 0, 0), TIME_SHORT));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
