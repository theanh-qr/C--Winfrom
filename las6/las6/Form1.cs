using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace las6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String s = "Hôm nay là" + DateTime.Now.ToString("dd/MM/yy");
            s = s + "Bây giờ là " +DateTime.Now.ToString("hh:mm:ss tt");
            label1.Text = s;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog motep = new OpenFileDialog();
            motep.Filter = "AVI file|*.avi|MPEG file|*.mpeg|WAR file|*.war|MIDI file|*.midi|MP4 file|*.mp4";
            if (motep.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = motep.FileName;
                axWindowsMediaPlayer1.Visible = true;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
        } 
    }
}
