using System;
using System.Drawing;
using System.Windows.Forms;

namespace Screenfix
{
    public partial class frmFlash : Form
    {
        int Counter = 0;
        public frmFlash(Screen S)
        {
            InitializeComponent();
            Location = S.Bounds.Location;
            Size = S.Bounds.Size;
            tUpdate.Start();
        }

        private void tUpdate_Tick(object sender, EventArgs e)
        {
            if (BackColor == Color.Black)
            {
                BackColor = Color.White;
            }
            else
            {
                BackColor = Color.Black;
            }
            if(++Counter>5)
            {
                tUpdate.Stop();
                Close();
            }
        }
    }
}
