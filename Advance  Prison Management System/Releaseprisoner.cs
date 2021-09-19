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
    public partial class Releaseprisoner : Form
    {
        public Releaseprisoner()
        {
            InitializeComponent();
        }
        Prisoner p = new Prisoner();
        Cell c = new Cell();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        private void Releaseprisoner_Load(object sender, EventArgs e)
        {
            dt = da.prisonerinfo(p);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "")
            {

                MessageBox.Show("Make Sure that you enter cell no For search");

            }
            else
            {
                p.CaseNo = textBoxUname.Text;


                dt = da.prisonersearch(p);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.prisonerinfo(p);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label5.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "----")
            {
                MessageBox.Show("Prease select a Prisoner to Release");
            }
            else
            {
                p.sl = Int32.Parse(label4.Text);
               
                p.Cellno = label5.Text;


                da.Releaseprisoner(p);
              
                {
                    MessageBox.Show("Prisoner Released");

                    dt = da.prisonerinfo(p);
                    dataGridView1.DataSource = dt;


                }
            }
        }
    }
}
