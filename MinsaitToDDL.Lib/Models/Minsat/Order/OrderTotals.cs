using System.Xml.Serialization;

namespace MinsaitToDDL.Lib.Models.Minsait.Order
{
    public class OrderTotals
    {
        [XmlElement("NetValue")]
        public decimal NetValue { get; set; }

        [XmlElement("GrossValue")]
        public decimal GrossValue { get; set; }
    }
}