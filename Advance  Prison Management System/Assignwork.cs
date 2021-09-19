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
    public partial class Assignwork : Form
    {
        public Assignwork()
        {
            InitializeComponent();
        }
        Prisoner p = new Prisoner();
        Workdetails wd = new Workdetails();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Assignwork_Load(object sender, EventArgs e)
        {
            dt = da.prisonerworkinfo(p);
            dataGridView1.DataSource = dt;


            dt = da.workinfo(wd);
            dataGridView2.DataSource = dt;


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label16.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label12.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
                return;

            label9.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            label3.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            label4.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            label5.Text = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
            label7.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();//manpower
            label11.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();//new
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label9.Text == "----")
            {
                MessageBox.Show("Please select a Work");
            }
            else
            {
                if (label16.Text == "----")

                {
                    MessageBox.Show("Please select a Prisoner");
                }
                else
                {
                    int slot = Convert.ToInt16(label7.Text);
                    int newno = Convert.ToInt16(label11.Text) + (1);

                    if (slot < newno)
                    {

                        MessageBox.Show("This work has maximum limit of workers");

                    }
                    else
                    {
                        wd.worksl = label3.Text;
                        wd.workcode = label9.Text;
                        wd.worktype = label4.Text;
                        wd.salary = label5.Text;
                        wd.prisonerno = label10.Text;
                        wd.prisonername = label16.Text;
                        wd.manbooked = newno.ToString();
                        wd.balance = label12.Text;
                        da.Addworker(wd);


                        {
                            MessageBox.Show("Worker Added");
                            dt = da.workinfo(wd);
                            dataGridView2.DataSource = dt;
                        }

                    }
                }
            }
        }
    }
}
