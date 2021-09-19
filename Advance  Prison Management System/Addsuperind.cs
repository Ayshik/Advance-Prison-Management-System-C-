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
    public partial class Addsuperind : Form
    {
        public Addsuperind()
        {
            InitializeComponent();
            label10.Visible = false;
            label11.Visible = false;

        }
       
        Signupuser s = new Signupuser();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        private void Addsuperind_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "" || textBoxPass.Text == "" || dateTimePicker1.Text == "" || textBoxMobile.Text == "" || comboBoxBlock.Text == "Gender" || comboBox1.Text == "Please select a question!"|| textBox2.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please fill all the information");
            }
            else
            {
                s.name = textBoxUname.Text;
                s.Password = textBoxPass.Text;
                s.Dob = dateTimePicker1.Text;
                s.mobileno = textBoxMobile.Text;
                s.address = textBox1.Text;
                s.gender = comboBoxBlock.Text;
                s.question = comboBox1.Text;
                s.answer = textBox2.Text;
              


                int i = da.CreateAccountsup(s);
                if (i > 0)
                {
                    MessageBox.Show("Account Created");
                }
                else
                {
                    MessageBox.Show("opss server is Busy");
                }
            }

            s.name = textBoxUname.Text;
            s.Password = textBoxPass.Text;
            s.mobileno = textBoxMobile.Text;
            s.answer = textBox2.Text;
            dt = da.supfetchid(s);

            if (dt.Rows.Count == 1)
            {


                string sl= dt.Rows[0][0].ToString();
                string user = "SUP";
                label11.Text = user + "-" + sl;
                s.username = label11.Text;
                s.Userid = sl;
                int w = da.updateuseridsup(s);
                label10.Visible = true;
                label11.Visible = true;

            }


            {
               
                textBoxPass.Text = "";
                dateTimePicker1.Text = "";
                textBoxMobile.Text = "";
                textBox1.Text = "";
                comboBoxBlock.Text = "Gender";
                comboBox1.Text = "Please select a question!";
                textBox2.Text = "";





            }


            
        }
    }
}
