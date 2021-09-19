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
    public partial class IGprofile : Form
    {
        public IGprofile(string uid)
        {
            InitializeComponent();
            label11.Text = uid;
        }
        Signupuser s = new Signupuser();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void IGprofile_Load(object sender, EventArgs e)
        {
            s.username = label11.Text;

            dt = da.igprofile(s);

            if (dt.Rows.Count == 1)
            {

                textBoxUname.Text = dt.Rows[0][1].ToString();
                textBoxPass.Text = dt.Rows[0][7].ToString();
                textBox1.Text = dt.Rows[0][5].ToString();
                textBoxMobile.Text = dt.Rows[0][4].ToString();
              



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text ==""|| textBoxPass.Text==""|| textBox1.Text==""|| textBoxMobile.Text=="")
            {
                MessageBox.Show("please Fill information for update");
            }
            else
            {
               
                    s.username = label11.Text;
                    s.mobileno = textBoxMobile.Text;
                    s.Password = textBoxPass.Text;
                s.address =textBox1.Text;


                int w = da.igupdate(s);
                    if (w > 0)
                    {
                        MessageBox.Show("Profile updated");
                    }
                
                else { MessageBox.Show("Server busy try again"); }
            }
        }
    }
}
