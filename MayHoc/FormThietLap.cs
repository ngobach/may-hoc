using System;
using System.Windows.Forms;

namespace MayHoc
{
    public partial class FormThietLap : Form
    {
        public FormThietLap()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Volume = trackVolume.Value;
            Properties.Settings.Default.Rate = trackRate.Value;
            Properties.Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
