using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Material.Entity.Transaction
{
    public class IssueDetailEntity : BaseTransactionDetailEntity
    {
        public Int32 FromWareHouseId { get; set; }
        public Int32 ToWareHouseId { get; set; }
        public Int32 ItemId { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Rate { get; set; }
        public Decimal Amount { get; set; }
    }
}