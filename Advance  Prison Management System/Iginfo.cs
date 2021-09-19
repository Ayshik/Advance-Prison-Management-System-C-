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
    public partial class Iginfo : Form
    {
        public Iginfo()
        {
            InitializeComponent();
        }
        Signupuser s = new Signupuser();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void Iginfo_Load(object sender, EventArgs e)
        {
            dt = da.iginfo(s);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            label11.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label11.Text == "----")
            {
                MessageBox.Show("please select a IG from Table");

            }
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Do You Want Delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    s.username = label11.Text;
                    int i = da.DeleteIG(s);
                    if (i > 0)
                    {


                        {
                            MessageBox.Show("Succesfully Deleted");
                            dt = da.iginfo(s);
                            dataGridView1.DataSource = dt;

                        }
                    }
                    else
                    {
                        MessageBox.Show("you have no car to release");
                    }
                }
            }
           
        }
    }
}
