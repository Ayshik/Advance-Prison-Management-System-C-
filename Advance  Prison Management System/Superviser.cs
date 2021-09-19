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
    public partial class Superviser : Form
    {
        public Superviser(string uid)
        {
            InitializeComponent();

            label2.Text = uid;
        }
        private void hideSubMenu()
        {
            
        }

        private void showSubMenu(Panel subMenu)
        {
          
        }
        private void Superviser_Load(object sender, EventArgs e)
        {
            openChildForm(new SUPsiren());

            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Addcell());
            
            hideSubMenu();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
           
        }
    }
}
