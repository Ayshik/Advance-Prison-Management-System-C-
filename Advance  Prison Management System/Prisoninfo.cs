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
    public partial class Prisoninfo : Form
    {
        public Prisoninfo()
        {
            InitializeComponent();
        }
        Prisoner p = new Prisoner();
        Cell c = new Cell();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void Prisoninfo_Load(object sender, EventArgs e)
        {
            dt = da.prisonerinfo(p);
            dataGridView1.DataSource = dt;
        }

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
