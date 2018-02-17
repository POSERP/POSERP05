using POSERP05.Framework.Entity;

namespace POSERP05.Common.Entity.Tax
{
    public class StateWiseLedgerGSTINEntity : BaseMasterEntity
    {
        public int LedgerId { get; set; }
        public int StateId { get; set; }
        public string GSTIN { get; set; }
    }
}
