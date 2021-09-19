using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__Prison_Management_System
{
   public class Login
    {
        DataAccess da = new DataAccess();
        public string Password { get; set; }
        public string Userid { get; set; }
        public int id { get; set; }
    }
}
