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
    public partial class Unlockcell : Form
    {
        public Unlockcell()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        Cell c = new Cell();
        DataTable dt = new DataTable();

        private void Unlockcell_Load(object sender, EventArgs e)
        {
            dt = da.LockedCellinfo(c);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.LockedCellinfo(c);
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
               
               

                dt = da.LockedCellsearch(c);
                dataGridView1.DataSource = dt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label3.Text == "----")
            {
                MessageBox.Show("Prease select a cellno to Unlock");
            }
            else
            {
               
              c.sl= Int32.Parse(label4.Text);



                int w = da.CellUnlockone(c);
                if (w > 0)
                {
                    MessageBox.Show("Cell Unlocked");




                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int w = da.CellUnlockAll(c);
            if (w > 0)
            {
                MessageBox.Show("All Cell Unlocked");




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
