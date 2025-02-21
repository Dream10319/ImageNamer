using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImageNamer
{
    public class AttributeManager
    {
        public List<string> attribute1Options = new List<string> { "FrontBody", "SideBody", "Rear", "Front", "Side", "Back", "Detail1", "Detail2", "Detail3" };
        public List<string> attribute2Options = new List<string> { "Zoom", "Full", "NA" };
        private const string settingsFile = "attributes.xml";

        public void LoadAttributeSettings()
        {
            if (File.Exists(settingsFile))
            {
                XDocument doc = XDocument.Load(settingsFile);
                attribute1Options = doc.Root.Element("Attribute1").Elements("Option").Select(x => x.Value).ToList();
                attribute2Options = doc.Root.Element("Attribute2").Elements("Option").Select(x => x.Value).ToList();
            }
        }

        public void SaveAttributeSettings()
        {
            XDocument doc = new XDocument(
                new XElement("Settings",
                    new XElement("Attribute1", attribute1Options.Select(opt => new XElement("Option", opt))),
                    new XElement("Attribute2", attribute2Options.Select(opt => new XElement("Option", opt)))
                )
            );
            doc.Save(settingsFile);
        }
    }
}
