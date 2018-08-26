using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Screenfix
{
    public partial class frmMain : Form
    {
        private int Mode = 0;
        private Timer T;
        public frmMain()
        {
            InitializeComponent();
            cbScreen.Items.AddRange(Screen.AllScreens.Select((m, i) => new ScreenInfo(i)).Cast<object>().ToArray());
            cbScreen.SelectedIndex = 0;

            T = new Timer();

            T.Tick += delegate
            {
                SetMode(++Mode);
            };

            SetMode(0);
            T.Start();

            pPreview.Cursor = Program.Invisible;

        }

        public void CloseAll()
        {
            var All = Application.OpenForms.OfType<frmFix>().Where(m => !m.IsDisposed).ToArray();
            foreach (var F in All)
            {
                F.Close();
                F.Dispose();
            }
        }

        private void SetMode(int ModeId)
        {
            var Mode = Program.Modes[ModeId % Program.Modes.Length];
            pPreview.BackColor = Mode.Color;
            if (T.Interval != Mode.Time)
            {
                T.Interval = Mode.Time;
            }
            foreach (var F in Application.OpenForms.OfType<frmFix>().Where(m => !m.IsDisposed))
            {
                F.SetMode(Mode.Color);
            }
        }

        private void btnFlash_Click(object sender, System.EventArgs e)
        {
            var SI = (ScreenInfo)cbScreen.SelectedItem;
            using (var F = new frmFlash(SI.Screen))
            {
                F.ShowDialog();
            }
        }

        private void btnFixOne_Click(object sender, System.EventArgs e)
        {
            var SI = (ScreenInfo)cbScreen.SelectedItem;
            using (var F = new frmFix(SI.Screen))
            {
                F.ShowDialog();
            }
        }

        private void btnFixAll_Click(object sender, System.EventArgs e)
        {
            foreach (var S in Screen.AllScreens)
            {
                (new frmFix(S)).Show();
            }
        }
    }
}
