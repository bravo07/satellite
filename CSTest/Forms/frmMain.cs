using System;
using System.Windows.Forms;

using Satellite;

namespace CSTest
{
    public partial class frmMain : Form
    {
        private SatelliteConsole _sat;

        public frmMain()
        {
            InitializeComponent();

            _sat = new SatelliteConsole(true);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            if (btnToggle.Text == "Attach")
            {
                _sat.Attach();
                btnToggle.Text = "Detach";
            }
            else
            {
                _sat.Detatch();
                btnToggle.Text = "Attach";
            }
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            _sat.Dispose();
            btnToggle.Enabled = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
           _sat.Write(txtOutput.Text);
        }

        private void btnWriteLine_Click(object sender, EventArgs e)
        {
            _sat.WriteLine(txtOutput.Text);
        }

        private void btnReadLine_Click(object sender, EventArgs e)
        {
            txtInput.Text = _sat.ReadLine();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            _sat.Title = txtTitle.Text;
        }
    }
}
