using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__Prison_Management_System
{
    public class Signupuser
    {
        DataAccess da = new DataAccess();

        public string Password { get; set; }
        public string Userid { get; set; }
        public string username { get; set; }
        public string question { get; set; }
        public string mobileno { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
        public string name { get; set; }

        public string answer { get; set; }
        public string Dob { get; set; }
       


    }
}
