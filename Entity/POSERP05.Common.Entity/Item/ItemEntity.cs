using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Common.Entity.Master
{
    public class ItemEntity : BaseMasterEntity
    {
        public String AlternateDesc { get; set; }
        public int GroupId { get; set; }
        public string RateBasis { get; set; }
        public bool Discontinue { get; set; }
        public DateTime? ActiveTill { get; set; }
        public string HsnCode { get; set; }
    }
}
