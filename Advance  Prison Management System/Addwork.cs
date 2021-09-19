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
    public partial class Addwork : Form
    {
        public Addwork()
        {
            InitializeComponent();
        }
        Workdetails wd = new Workdetails();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "" || textBoxPass.Text == "" || numericUpDown1.Text == "0" || textBoxMobile.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please fill all the information");
            }
            else
            {
                wd.workcode = textBoxMobile.Text;
                wd.worktype = textBoxUname.Text;
                wd.manpower = numericUpDown1.Text;
                wd.requirement = textBox1.Text;
                wd.salary = textBoxPass.Text;
              




                da.Addwork(wd);
               
                    MessageBox.Show("Work Added");
              
            }
        }
    }
}
