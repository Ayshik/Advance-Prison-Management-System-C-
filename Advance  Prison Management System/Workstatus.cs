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
    public partial class Workstatus : Form
    {
        public Workstatus()
        {
            InitializeComponent();
        }
        Workdetails wd = new Workdetails();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void textBoxUname_TextChanged(object sender, EventArgs e)
        {
            wd.worktype = textBoxUname.Text;

            dt = da.workinfosearch(wd);
            dataGridView1.DataSource = dt;
        }

        private void Workstatus_Load(object sender, EventArgs e)
        {
            dt = da.workinfo(wd);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label3.Text == "----")

            {
                MessageBox.Show("Please select a Work");
            }
            else
            {
                wd.workcode = label3.Text;
                da.updateworkstatus(wd);

                {
                    MessageBox.Show("Work Done");
                    dt = da.workinfo(wd);
                    dataGridView1.DataSource = dt;
                }

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
