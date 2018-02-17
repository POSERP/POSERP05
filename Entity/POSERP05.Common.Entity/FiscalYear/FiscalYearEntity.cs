using POSERP05.Framework.Entity;
using System;

namespace POSERP05.Common.Entity.FiscalYear
{
    public class FiscalYearEntity : BaseMasterEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Boolean IsOpening { get; set; }
    }
}
