using System.Runtime.Serialization;

namespace Contracts
{
    [DataContract]
    public class PointOfInterest
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}