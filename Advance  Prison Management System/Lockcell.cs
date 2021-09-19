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
    public partial class Lockcell : Form
    {
        public Lockcell()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        Cell c = new Cell();
        DataTable dt = new DataTable();

        private void Lockcell_Load(object sender, EventArgs e)
        {
            dt = da.UnLockedCellinfo(c);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.UnLockedCellinfo(c);
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
                c.Cellno = textBoxUname.Text;
              

                dt = da.UnLockedCellsearch(c);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "----")
            {
                MessageBox.Show("Prease select a cellno to Lock");
            }
            else
            {
                c.sl = Int32.Parse(label4.Text);


                int w = da.Celllockone(c);
                if (w > 0)
                {
                    MessageBox.Show("Cell Locked");

                    

                   
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int w = da.CelllockAll(c);
            if (w > 0)
            {
                MessageBox.Show("All Cell Locked");




            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }
    }
}
