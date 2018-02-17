using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSERP05.Framework.Entity.Argument
{
    public class FindArgument : BaseMasterArgument
    {
        public String SearchText { get; set; }
        public String SearchField { get; set; }
        public List<AdvanceSearch> CustomSearch { get; set; }
    }

    public class AdvanceSearch
    {
        public String SearchText { get; set; }
        public String SearchField { get; set; }
    }
}
