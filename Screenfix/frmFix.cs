using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Screenfix
{
    public partial class frmFix : Form
    {
        public frmFix(Screen S)
        {
            InitializeComponent();

            Location = S.Bounds.Location;
            Size = S.Bounds.Size;
            Cursor = Program.Invisible;
        }

        public void SetMode(Color C)
        {
            BackColor = C;
        }

        private void frmFix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var F = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                if (F != null)
                {
                    F.CloseAll();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
