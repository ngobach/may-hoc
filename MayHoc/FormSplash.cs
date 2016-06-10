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
    public partial class FormSplash : Form
    {
        private int _counter;
        public FormSplash()
        {
            InitializeComponent();
            _counter = 0;
        }

        private void timerFade_Tick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter >= 40*3)
            {
                timerFade.Enabled = false;
                Hide();
                var main = new FormMain();
                main.FormClosed += (o, args) => Close();
                main.Show();
            }
            else
            {
                if (_counter < 40)
                {
                    Opacity = _counter*0.025;
                }
                else if (_counter > 80)
                {
                    Opacity = (120 - _counter)*0.025;
                }
                else
                {
                    Opacity = 1;
                }
            }
        }
    }

}
