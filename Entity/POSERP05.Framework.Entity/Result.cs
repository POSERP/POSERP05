using System.Collections.Specialized;

namespace POSERP05.Framework.Entity
{
    //[DataContract]
    public class Result
    {
        public int Id { get; set; }
        private HybridDictionary _outputList = new HybridDictionary();
        //[DataMember]
        public HybridDictionary OutputList
        {
            get { return _outputList; }
            set { this._outputList = value; }
        }

        //[DataMember]
        public bool Status { get; set; }
    }
}