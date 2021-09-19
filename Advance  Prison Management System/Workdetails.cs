using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__Prison_Management_System
{
   public class Workdetails
    {
        DataAccess da = new DataAccess();
        public string worksl { get; set; }
        public string prisonerno { get; set; }
        public string workcode { get; set; }
        public string prisonername { get; set; }
        public string worktype { get; set; }
        public string manpower { get; set; }
        public string salary { get; set; }
        public string requirement { get; set; }
        public string manbooked { get; set; }
        public string status { get; set; }
        public string balance { get; set; }
    }
}
