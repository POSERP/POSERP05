using POSERP05.Framework.Entity;

namespace POSERP05.Common.Entity.Tax
{
    public class GSTMasterEntity : BaseMasterEntity
    {
        public int TaxId { get; set; }
        public string HSN_SAC_CODE { get; set; }
        public string Type { get; set; }
    }
}
