using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace phoneapp
{
    public class Serialization
    {
        public static string serialize(Contact c)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(Contact));
            string xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, c);
                    xml = sww.ToString();//my xml
                }
            }
            return xml;
        }

    }
}
