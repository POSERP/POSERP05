using System;
using POSERP05.Framework.Entity;

namespace POSERP05.Common.Entity.Ledger
{
    public class LedgerEntity : BaseMasterEntity
    {
        public Int32 LedgerTypeId { get; set; }
        public Int32 MainLedgerId { get; set; }
        public Int32 LedgerGroupId { get; set; }
        public Int32 LedgerClassificationId { get; set; }
        public String MobileNo { get; set; }
        public String EmailId { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String PANNo { get; set; }
        public String CINNo { get; set; }
        public String GSTINNo { get; set; }
        public Int32 StateId { get; set; }
        public Int32 DistrictId { get; set; }
        public Boolean IsTaxNature { get; set; }
        public decimal TaxRate { get; set; }
    }
}
