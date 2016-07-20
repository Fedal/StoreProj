using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
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
    public static void GetLayout(Store store)
    {
      XDocument doc = XDocument.Load(path);
      var Layouts = from r in doc.Descendants("Layout")
                  select new
                  {
                    OwnerName = r.Attribute("Name").ToString(),
                    shelveNr = int.Parse(r.Element("ShelveNr").Value),
                    shelveCapacity = int.Parse(r.Element("ShelveCapacity").Value),
                    rows = int.Parse(r.Element("Rows").Value),
                  };
     
     
      foreach (var x in Layouts)
      { 
         Layout forStore = new Layout(x.shelveNr, x.shelveCapacity, x.rows);
         store.Shop.Layout = forStore;
         break;
      }
      int i = -1;
      foreach (var x in Layouts)
      {
        if (i >= 0)
        {
          
          store.WHouses[i] = new Warehouse(x.OwnerName);
          store.WHouses[i].Layout = new Layout(x.shelveNr, x.shelveCapacity, x.rows);;
        }
        i++;
      }
      
    }
   
  }
}
