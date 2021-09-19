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
    public partial class Form1 : Form
    {
       
        int w;
        int x= 687, y= 85;
        public Form1()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        Anounce a = new Anounce();
        Login l = new Login();
        DataTable dt = new DataTable();
        Boolean state = false;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Forgetpass fp = new Forgetpass();
            fp.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InspectorGenaralPanel isp = new InspectorGenaralPanel();
            //isp.Visible = true;
            //this.Visible = false;





            if (Uname.Text == "" || Pass.Text == "")
            {
                MessageBox.Show("Please Enter username and password");
            }
            else
            {
                l.Userid = Uname.Text;
                l.Password = Pass.Text;



                {
                    if (state == false)
                    {
                        dt = da.Logindg(l);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            DeputyInspectorPanel c = new DeputyInspectorPanel();
                            this.Visible = false;
                            c.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                }




                {
                    if (state == false)
                    {
                        dt = da.Loginig(l);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                            InspectorGenaralPanel i = new InspectorGenaralPanel(Uname.Text);
                            this.Visible = false;
                            i.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }

                }


                

                {
                    if (state == false)
                    {
                        dt = da.Loginsup(l);

                        if (dt.Rows.Count == 1)
                        {
                            state = true;
                           Superviser s = new Superviser(Uname.Text);
                            this.Visible = false;
                            s.Visible = true;

                        }
                        else
                        {
                            state = false;
                        }
                    }


                    if (state == false)
                    {
                        MessageBox.Show("Invalid id,No ID found");
                    }



                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            dt = da.Anouncement(a);

            if (dt.Rows.Count == 1)
            {

                label4.Text = dt.Rows[0][0].ToString();

                timer1.Start();


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                w = -722;
                if (w ==label4.Left)
                {

                    label4.Left = 355;

                }
                else
                {

                    int i = -1;
                    label4.Left = label4.Left +i++;
                   
                }
              
           


                /*  label4.SetBounds(x, y,1,1);
                  x--;
                  if (x <= 1)
                  {

                      x = 1000;

                  }*/
            }

            private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
