using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSERP05.Framework.Entity
{
    public class BaseTransactionDetailEntity : BaseTransactionEntity
    {
        public new Int64 Id { get; set; }
        public new Int64 RefId { get; set; }
        public int SrlNo { get; set; }
    }
}
