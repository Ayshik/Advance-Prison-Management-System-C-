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
    public partial class superviserinfo : Form
    {
        public superviserinfo()
        {
            InitializeComponent();
        }
        Signupuser s = new Signupuser();
        DataAccess da = new DataAccess();
        DataTable dt = new DataTable();
        private void superviserinfo_Load(object sender, EventArgs e)
        {
            dt = da.suprviserinfo(s);
            dataGridView1.DataSource = dt;
        }
    }
}
