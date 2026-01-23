using System.Xml.Serialization;

namespace MinsaitToDDL.Lib.Models.Minsait.Order
{
    public class PaymentInstructions
    {
        [XmlElement("PaymentTerm")]
        public string PaymentTerm { get; set; }
    }
}