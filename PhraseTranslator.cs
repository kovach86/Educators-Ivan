using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextHandlers
{
        public class PhraseTranslator
        {
            public string GetTranslation(string phrase_id, string language, string for_phrase)
            {
                XElement root = XElement.Load(@"C:\Users\Kovach\Desktop\test.xml");
                return root.Elements(phrase_id).First()
                    .Nodes().Cast<XElement>()
                    .First(x => x.FirstAttribute.Value == language).Value;
            }
        }
    }
 