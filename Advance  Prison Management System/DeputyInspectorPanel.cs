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
    public partial class DeputyInspectorPanel : Form
    {
        public DeputyInspectorPanel()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            InfoSubMenu.Visible = false;
           
            WorkSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(InfoSubMenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(WorkSubMenu);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void DeputyInspectorPanel_Load(object sender, EventArgs e)
        {

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
            openChildForm(new Prisoninfo());

            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Iginfo());

            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new superviserinfo());

            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new Addwork());

            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            openChildForm(new Workstatus());

            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new AddIG());

            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new Anouncement());

            hideSubMenu();
        }
    }
}
