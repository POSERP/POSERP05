using POSERP05.Common.Entity.Ledger;
using POSERP05.Common.Entity.Project;
using POSERP05.Framework.Entity;
using System;
using System.Collections.Generic;

namespace POSERP05.Material.Entity.Transaction
{
    public class PurchaseOrderHeaderEntity : BaseTransactionHeaderEntity
    {
        public ProjectEntity Project { get; set; }
        public Int32 ProjectId { get; set; }
        public string ProjectDescription { get; set; }
        public SubProjectEntity SubProject { get; set; }
        public Int32 SubProjectId { get; set; }
        public string SubProjectDescription { get; set; }
        public LedgerEntity Supplier { get; set; }
        public Int32 SupplierId { get; set; }
        public string SupplierDescription { get; set; }
        public Int32 TransactionTypeId { get; set; }
        public String Remarks { get; set; }
        public List<PurchaseOrderDetailEntity> poDetailEntity { get; set; }
    }
}
