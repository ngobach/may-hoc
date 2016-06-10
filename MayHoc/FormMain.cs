using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using MayHoc.Core;

namespace MayHoc
{
    public partial class FormMain : Form
    {
        private ITextToSpeech _current;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuIntroduce_Click(object sender, EventArgs e)
        {
            new FormGioiThieu().ShowDialog();
        }

        private void mnuHuongDan_Click(object sender, EventArgs e)
        {
            new FormHuongDan().ShowDialog();
        }

        private void mnuPreference_Click(object sender, EventArgs e)
        {
            new FormThietLap().ShowDialog();
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog {Filter = "File text (*.txt)|*.txt"};
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dlg.FileName, txtContent.Text);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog { Filter = "File text (*.txt)|*.txt|Mọi định dạng (*.*)|*.*" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtContent.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_current != null && !_current.IsStopped())
            {
                MessageBox.Show("Trình phát giọng nói vẫn đang chạy!", "Lỗi", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (_current != null) _current.Stop();
            _current = chkVietnamese.Checked ? new Factory().MakeVNSpeech(txtContent.Text) : new Factory().MakeLocal(txtContent.Text);
            _current.Speak();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (_current == null) return;
            _current.PauseResume();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_current == null) return;
            _current.Stop();
            _current = null;
        }

        private void btnExportWav_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog {Filter = "Audio file (*.wav)|*.wav"};
            if (dlg.ShowDialog() != DialogResult.OK) return;

            // First, stop current playing voice
            if (_current == null) return;
            _current.Stop();
            _current = null;

            var tmp = chkVietnamese.Checked ?  new Factory().MakeVNSpeech(txtContent.Text) : new Factory().MakeLocal(txtContent.Text);
            tmp.Export(dlg.FileName);
        }

    }
}
