using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advance__Prison_Management_System
{
    public partial class Siren : Form
    {
        public Siren()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"F:\Naima\Advance  Prison Management System\music\bell.wav");
            sp.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SoundPlayer sp = new SoundPlayer(@"F:\Naima\Advance  Prison Management System\music\bell.wav");
            sp.Stop();
        }
    }
}
