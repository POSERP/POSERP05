using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Material.Entity.Transaction
{
    public class MaterialReceiptNoteDetailEntity : BaseTransactionDetailEntity
    {
        public Int64 POHeaderId { get; set; }
        public Int64 PODetailId { get; set; }
        public Int32 ItemId { get; set; }
        public Decimal Quantity { get; set; }
        public Decimal Rate { get; set; }
        public Decimal Amount { get; set; }
    }
}