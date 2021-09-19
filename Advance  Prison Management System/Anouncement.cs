using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advance__Prison_Management_System
{
    public partial class Anouncement : Form
    {
        public Anouncement()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        Anounce a = new Anounce();
        private void button1_Click(object sender, EventArgs e)
        { if (richTextBox1.Text == "")
            {
                MessageBox.Show("Please Write something");
            }
            else
            {
                a.text = richTextBox1.Text;
                int w = da.UpdateAnouncement(a);
                if (w > 0)
                {
                    MessageBox.Show("Published");




                }
            }
        }
    }
}
