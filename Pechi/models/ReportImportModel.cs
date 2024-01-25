using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pechi.models
{
    public class ReportImportModel
    {
        public int AgregatID { get; set; }
        public string AgregatName { get; set; }
        public string ProstoiName { get; set; }
        public string Litso {  get; set; }
        public int? ProstoiPlan { get; set; }
        public int? ProstoiFact { get; set; }
    }
}
