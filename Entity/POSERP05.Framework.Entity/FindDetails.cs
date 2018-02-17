using POSERP05.Framework.Entity.Argument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSERP05.Framework.Entity
{
    public class FindDetails : BaseEntity
    {
        public List<Dictionary<string, object>> FindData { get; set; }
        public FindArgument FindArg { get; set; }
    }
}
