using System;

namespace POSERP05.Framework.Entity
{
    public class BaseTransactionHeaderEntity : BaseTransactionEntity
    {
        public new Int64 Id { get; set; }
        public String DocumentNo { get; set; }
        public DateTime DocumentDate { get; set; }
        public Int32 FinYrId { get; set; }
        public TranType TransactionType { get; set; }
        public Decimal Amount { get; set; }
        public int ApprovalLevel { get; set; }
        public bool IsApproved { get; set; }
    }
}
