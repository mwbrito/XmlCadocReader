using System.Xml.Serialization;

namespace XmlCadocReader.Elements
{
    [XmlRoot("Doc3040")]
    public class Doc3040
    {
        [XmlAttribute("DtBase")]
        public string DtBase;

        [XmlAttribute("CNPJ")]
        public string CNPJ;

        [XmlAttribute("Parte")]
        public string Parte;

        [XmlAttribute("Remessa")]
        public string Remessa;

        [XmlAttribute("TpArq")]
        public string TpArq;

        [XmlAttribute("NomeResp")]
        public string NomeResp;

        [XmlAttribute("EmailResp")]
        public string EmailResp;

        [XmlAttribute("TelResp")]
        public string TelResp;

        [XmlElement("Cli")]
        public Cli cli = new Cli();

        [XmlElement("Agre")]
        public Agre[] agre;
    }
}
