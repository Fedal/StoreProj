using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;


namespace Storev2
{
  class FileStoreCotroler
  {  
    static string path = Directory.GetCurrentDirectory() + "\\Data\\StoreSetings.xml";
    
    public static void AddLayout(int shelfnr, int shelfcap, int rows, string Ownername)
    {
         XDocument doc = XDocument.Load(path);
         XElement Layout = new XElement("Layout",new XAttribute("Name", Ownername));
      Layout.Add (new XElement ("ShelveNr", shelfnr));
      Layout.Add (new XElement ("ShelveCapacity", shelfcap));
      Layout.Add (new XElement ("Rows", rows) );
      doc.Root.Add(Layout);
             doc.Save(path);
    }
   
  }
}
