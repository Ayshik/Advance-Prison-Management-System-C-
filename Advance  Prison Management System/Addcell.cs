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
    public partial class Addcell : Form
    {
        public Addcell()
        {
            InitializeComponent();
        }
        Cell c = new Cell();
        DataAccess da = new DataAccess();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUname.Text == "" || comboBoxBlock.Text == "Cell" )
            {
                MessageBox.Show("Make Sure that you enter cell no and Type");
            }
            else
            {
                c.Cellno = textBoxUname.Text;
               
                c.Celltype = comboBoxBlock.Text;


                int i = da.Createnewcell(c);
                if (i > 0)
                {
                    MessageBox.Show("Cell Created");
                }
                else
                {
                    MessageBox.Show("opss server is Busy");
                }
            }
        }

        private void Addcell_Load(object sender, EventArgs e)
        {

        }
    }
}
