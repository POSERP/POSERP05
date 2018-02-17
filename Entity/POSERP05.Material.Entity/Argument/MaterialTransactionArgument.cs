using POSERP05.Framework.Entity.Argument;
using System;

namespace POSERP05.Material.Entity.Argument
{
    public class MaterialTransactionArgument : BaseTransactionArgument
    {
        public Int32 ProjectId { get; set; }
        public Int32 SubProjectId { get; set; }
    }
}
