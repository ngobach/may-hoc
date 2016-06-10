using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayHoc
{
    public partial class FormHuongDan : Form
    {
        public FormHuongDan()
        {
            InitializeComponent();
        }

        private void FormHuongDan_Load(object sender, EventArgs e)
        {
            rtb.LoadFile("manual.rtf");
        }
    }
}
