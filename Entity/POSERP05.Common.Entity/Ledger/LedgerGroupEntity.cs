using System;
using POSERP05.Framework.Entity;

namespace POSERP05.Common.Entity.Ledger
{
    public class LedgerGroupEntity : BaseMasterEntity
    {
        public Int32 BelongsTo { get; set; }
        public Int32 SystemGenBelongsTo { get; set; }
        public bool IsSysGen { get; set; }
    }
}