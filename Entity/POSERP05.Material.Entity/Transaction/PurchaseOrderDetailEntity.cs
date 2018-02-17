using POSERP05.Common.Entity.Master;
using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Material.Entity.Transaction
{
    public class PurchaseOrderDetailEntity : BaseTransactionDetailEntity
    {
        public string DocumentNo { get; set; }
        public Int64 MRHeaderId { get; set; }
        public Int64 MRDetailId { get; set; }
        public ItemEntity Item { get; set; }
        public Int32 ItemId { get; set; }
        public string ItemDescription { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Rate { get; set; }
        public Decimal Amount { get; set; }
    }
}