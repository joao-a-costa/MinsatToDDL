using System.Xml.Serialization;

namespace MinsaitToDDL.Lib.Models.Minsait.Order
{
    public class OrderSummary
    {
        [XmlElement("NumberOfLines")]
        public int NumberOfLines { get; set; }

        [XmlElement("OrderTotals")]
        public OrderTotals OrderTotals { get; set; }
    }
}