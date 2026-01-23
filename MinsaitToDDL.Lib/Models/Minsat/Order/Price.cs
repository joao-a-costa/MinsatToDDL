using System.Xml.Serialization;

namespace MinsatToDDL.Lib.Models.Minsat.Order
{
    public class Price
    {

        [XmlElement(ElementName = "NetPrice")]
        public double NetPrice { get; set; }

        [XmlElement(ElementName = "GrossPrice")]
        public double GrossPrice { get; set; }

        [XmlElement(ElementName = "PVP")]
        public double PVP { get; set; }

        [XmlElement(ElementName = "PriceBasisQuantity")]
        public double PriceBasisQuantity { get; set; }
    }
}