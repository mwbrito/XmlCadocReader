using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlCadocReader
{
    public class ReadCadocs
    {
        public static Cadoc3040File ReadCadoc3040File(String urlFile)
        {
            Cadoc3040File cadoc3040File = new Cadoc3040File();

            XmlSerializer serializer = new XmlSerializer(typeof(Cadoc3040File));

            try
            {
                using (Stream reader = new FileStream(urlFile, FileMode.Open))
                {
                    cadoc3040File = (Cadoc3040File)serializer.Deserialize(reader);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro durante a importação do Doc3040: " + ex.Message);
            }

            return cadoc3040File;
        }
    }
}
