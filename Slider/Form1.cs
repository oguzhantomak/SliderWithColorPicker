using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
        Random rnd = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = imgList.Images[rnd.Next(0, imgList.Images.Count)];
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb(trackBar2.Value,trackBar3.Value,trackBar4.Value);
            
        }

        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar4.Value);
        }

        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar2.Value, trackBar3.Value, trackBar4.Value);
        }
    }
}
