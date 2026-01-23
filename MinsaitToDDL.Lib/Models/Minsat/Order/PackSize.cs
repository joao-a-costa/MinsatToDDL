using System.Xml.Serialization;

namespace MinsatToDDL.Lib.Models.Minsat.Order
{
    public class PackSize
    {

        [XmlElement(ElementName = "Quantity")]
        public int Quantity { get; set; }
    }
}