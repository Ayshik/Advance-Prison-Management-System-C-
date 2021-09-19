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
    public partial class InspectorGenaralPanel : Form
    {
        public InspectorGenaralPanel(string uid)
        {
            InitializeComponent();
            hideSubMenu();
            label2.Text = uid;
        }

        private void hideSubMenu()
        {
            SecuritySubMenu.Visible = false;
            PrisonerSubMenu.Visible = false;
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

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(SecuritySubMenu);
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            showSubMenu(PrisonerSubMenu);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(WorkSubMenu);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new IGprofile(label2.Text));

            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           openChildForm(new Cellstatus());
           
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

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Unlockcell());

            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Lockcell());

            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Siren());

            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new Addprisoner());

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new Releaseprisoner());

            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openChildForm(new Prisoninfo());

            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new Visitors());

            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openChildForm(new Assignwork());

            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openChildForm(new Addsuperind());

            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openChildForm(new salaryreq());

            hideSubMenu();
        }
    }
}
