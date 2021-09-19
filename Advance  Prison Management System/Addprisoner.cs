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
    public partial class Addprisoner : Form
    {
        public Addprisoner()
        {
            InitializeComponent();
        }
        Prisoner p = new Prisoner();
        Cell c= new Cell();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addprisoner_Load(object sender, EventArgs e)
        {
            dt = da.FreeCellinfo(c);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label9.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label16.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            label10.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox7.Text == "" || comboBoxBlock.Text == "")
            {
                MessageBox.Show("Please enter presoner Information");
            }
            else
            {
                if (label9.Text == "----" || label16.Text == "----")

                {
                    MessageBox.Show("Please select a free cell");
                }
                else
                {
                    p.Cellno = label9.Text;
                    p.Celltype = label16.Text;
                    p.CellPrisoner = textBox1.Text;
                    p.Crime = textBox7.Text;
                    p.CaseNo = textBox5.Text;
                    p.Gender = comboBoxBlock.Text;
                    p.Height = textBox2.Text;
                    p.sl = Int32.Parse(label10.Text);
                    da.Addprisoner(p);
                   
                    {
                        MessageBox.Show("Prisoner Added");
                        dt = da.FreeCellinfo(c);
                        dataGridView1.DataSource = dt;
                    }
                   
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
