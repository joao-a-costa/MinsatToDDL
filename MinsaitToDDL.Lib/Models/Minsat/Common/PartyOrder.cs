using System.Xml.Serialization;

namespace MinsaitToDDL.Lib.Models.Minsat.Common
{
    public class PartyOrder
    {
        [XmlElement("EANCode")]
        public string EANCode { get; set; }

        [XmlElement("Department")]
        public string Department { get; set; }

        [XmlElement("InternalCode")]
        public string InternalCode { get; set; }
    }
}