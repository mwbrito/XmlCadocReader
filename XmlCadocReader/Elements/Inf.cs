using System.Xml.Serialization;

namespace XmlCadocReader.Elements
{
    [XmlRoot("Inf")]
    public class Inf
    {
        [XmlAttribute("Tp")]
        public string Tp;

        [XmlAttribute("Cd")]
        public string Cd;

        [XmlAttribute("Ident")]
        public string Ident;

        [XmlAttribute("Valor")]
        public string Valor;

        [XmlAttribute("Perc")]
        public string Perc;

        [XmlAttribute("Qtd")]
        public string Qtd;
    }
}
