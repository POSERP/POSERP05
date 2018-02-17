using POSERP05.Framework.Entity;
using System;
using System.Collections.Generic;

namespace POSERP05.Material.Entity.Transaction
{
    public class MaterialRequisitionHeaderEntity : BaseTransactionHeaderEntity
    {
        public Int32 ProjectId { get; set; }
        public string ProjectDescription { get; set; }
        public Int32 SubProjectId { get; set; }
        public string SubProjectDescription { get; set; }
        public Int32 RequisitionTypeId { get; set; }
        public Int32 LedgerId { get; set; }
        public string Remarks { get; set; }
        public List<MaterialRequisitionDetailEntity> mrDetailEntity { get; set; }
    }
}
