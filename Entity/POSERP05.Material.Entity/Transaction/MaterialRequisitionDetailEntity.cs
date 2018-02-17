using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Material.Entity.Transaction
{
    public class MaterialRequisitionDetailEntity : BaseTransactionDetailEntity
    {
        public Int32 ItemId { get; set; }
        public string ItemDescription { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Rate { get; set; }
        public Decimal Amount { get; set; }
    }
}
