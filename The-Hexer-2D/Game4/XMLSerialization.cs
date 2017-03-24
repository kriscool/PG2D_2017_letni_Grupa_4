using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Xna.Framework;

namespace Game4
{
    public static class XMLSerialization
    {
       

        public static bool LoadXml<T>(out T theobject,string path)
        {
            theobject = default(T);
            try
            {
                using (var stream = TitleContainer.OpenStream(path))
                {
                    var serializer = new XmlSerializer(typeof (T));
                    theobject = (T) serializer.Deserialize(stream);
                    return true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return false;

        }
    }
}
