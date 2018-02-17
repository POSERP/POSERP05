using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Common.Entity.Tax
{
    public class TaxRateEntity : BaseMasterEntity
    {
        public int TaxId { get; set; }
        public int TaxSubTypeId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal Rate { get; set; }
        public decimal ReverseChargePer { get; set; }
    }
}
