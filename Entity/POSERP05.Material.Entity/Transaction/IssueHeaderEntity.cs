using POSERP05.Framework.Entity;
using System;
using System.Collections.Generic;

namespace POSERP05.Material.Entity.Transaction
{
    public class IssueHeaderEntity : BaseTransactionHeaderEntity
    {
        public Int32 ProjectId { get; set; }
        public Int32 SubProjectId { get; set; }
        public Int32 SupplierId { get; set; }
        public String Remarks { get; set; }
        public Int32 IssueTypeId { get; set; }
        public List<IssueDetailEntity> issueDetailEntity { get; set; }
    }
}
