using POSERP05.Framework.Entity;
using System;
using System.Collections.Generic;

namespace POSERP05.Material.Entity.Transaction
{
    public class MaterialReceiptNoteHeaderEntity : BaseTransactionHeaderEntity
    {
        public Int32 ProjectId { get; set; }
        public Int32 SubProjectId { get; set; }
        public Int32 SupplierId { get; set; }
        public String Remarks { get; set; }
        public Int32 WareHouseId { get; set; }
        public List<MaterialReceiptNoteDetailEntity> mrnDetailEntity { get; set; }
    }
}
