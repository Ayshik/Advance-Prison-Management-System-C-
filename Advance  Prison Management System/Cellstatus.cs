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
    public partial class Cellstatus : Form
    {
        public Cellstatus()
        {
            InitializeComponent();
        }
        DataAccess da = new DataAccess();
        Cell c = new Cell();
        DataTable dt = new DataTable();

        private void Cellstatus_Load(object sender, EventArgs e)
        {
            dt = da.Cellinfo(c);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "")
            {

                MessageBox.Show("Make Sure that you enter cell no Or Status Or Condition For search");

            }
            else
            {
                c.Cellno = textBoxUname.Text;
               
                dt = da.Cellsearch(c);
                dataGridView1.DataSource = dt;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = da.Cellinfo(c);
            dataGridView1.DataSource = dt;
        }
    }
}
  