using System.Xml.Serialization;

namespace XmlCadocReader.Elements
{
    [XmlRoot("Op")]
    public class Op
    {
        [XmlAttribute("DetCli")]
        public string DetCli;

        [XmlAttribute("IPOC")]
        public string IPOC;

        [XmlAttribute("Contrt")]
        public string Contrt;

        [XmlAttribute("Mod")]
        public string Mod;

        [XmlAttribute("Cosif")]
        public string Cosif;

        [XmlAttribute("OrigemRec")]
        public string OrigemRec;

        [XmlAttribute("Indx")]
        public string Indx;

        [XmlAttribute("PercIndx")]
        public string PercIndx;

        [XmlAttribute("VarCamb")]
        public string VarCamb;

        [XmlAttribute("CEP")]
        public string CEP;

        [XmlAttribute("TaxEft")]
        public string TaxEft;

        [XmlAttribute("DtContr")]
        public string DtContr;

        [XmlAttribute("VlrContr")]
        public string VlrContr;

        [XmlAttribute("NatuOp")]
        public string NatuOp;

        [XmlAttribute("DtVencOp")]
        public string DtVencOp;

        [XmlAttribute("ClassOp")]
        public string ClassOp;

        [XmlAttribute("ProvConsttd")]
        public string ProvConsttd;

        [XmlAttribute("DiaAtraso")]
        public string DiaAtraso;

        [XmlAttribute("CaracEspecial")]
        public string CaracEspecial;

        [XmlAttribute("DtaProxParcela")]
        public string DtaProxParcela;

        [XmlAttribute("VlrProxParcela")]
        public string VlrProxParcela;

        [XmlAttribute("QtdParcelas")]
        public string QtdParcelas;

        [XmlElement("Venc")]
        public Venc venc = new Venc();

        [XmlElement("Gar")]
        public Gar gar = new Gar();
    }
}
