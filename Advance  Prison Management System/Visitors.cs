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
    public partial class Visitors : Form
    {
        public Visitors()
        {
            InitializeComponent();
        }
        Addvisitors av = new Addvisitors();
        Prisoner p = new Prisoner();
        Cell c = new Cell();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "")
            {

                MessageBox.Show("Make Sure that you enter name For search");

            }
            else
            {
                p.CellPrisoner = textBoxUname.Text;


                dt = da.prisonernamesearch(p);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.prisonerinfo(p);
            dataGridView1.DataSource = dt;
        }

        private void Visitors_Load(object sender, EventArgs e)
        {
            dt = da.prisonerinfo(p);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Please enter Visiter Name");
            }
            else
            {
                if (label4.Text == "----" || label5.Text == "----")

                {
                    MessageBox.Show("Please select a Prisoner");
                }
                else
                {
                    av.Cellno = label4.Text;
                    av.Celltype = label5.Text;
                    av.CellPrisoner = label6.Text;
                    av.Crime = label7.Text;
                    av.CaseNo = label9.Text;
                    av.visitorname = textBox1.Text;

                    da.Addvisiters(av);
                    {
                       
                        MessageBox.Show("Visiter Added");
                      
                    }

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            label6.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            label7.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            label9.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
