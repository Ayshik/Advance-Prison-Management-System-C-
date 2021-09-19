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
    public partial class salaryreq : Form
    {
        public salaryreq()
        {
            InitializeComponent();
        }

        Workdetails wd = new Workdetails();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void salaryreq_Load(object sender, EventArgs e)
        {
            dt = da.salarypendinginfo(wd);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
          
            label3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            label5.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            label7.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label4.Text == "----")
            {
                MessageBox.Show("Prease select a worker to payment");
            }
            else
            {
                int bal = Convert.ToInt16(label7.Text);
                int worksalary = Convert.ToInt16(label6.Text);
                int total = bal + worksalary;
                wd.prisonerno = label5.Text;
                wd.salary = total.ToString();



               da.updatesalarystatus(wd);

                {
                    MessageBox.Show("Payment clear");




                }
            }
        }
    }
}
