using System;

namespace POSERP05.Framework.Entity
{
    //[DataContract]
    public class BaseEntity
    {
        public BaseEntity() { }
        //[DataMember]
        public string Code { get; set; }
        //[DataMember]
        public string Description { get; set; }
        public string Mode { get; set; }
        public string IPAddress { get; set; }
        public string MachineId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
