using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance__Prison_Management_System
{
   public class Prisoner
    {

        DataAccess da = new DataAccess();
        public string Cellno { get; set; }
        public int sl { get; set; }
        public string Celltype { get; set; }
        public string CellPrisoner { get; set; }
        public string Crime { get; set; }
        public string CaseNo { get; set; }
        public string CellStatus { get; set; }
        public string CellCondition { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
    }
}
