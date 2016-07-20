using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Storev2
{
  class FileLoadController
  {
    internal static void Load(Store store)
    {
      string path = Directory.GetCurrentDirectory() + "\\Data\\StoreSetings.xml";
      XDocument document = XDocument.Load(path);
      var settings = from r in document.Descendants("Layout")
                     select new 
                     {
                       Name = r.Attribute("Name").Name,
                       Shelves = r.Element("ShelveNr").Value,
                       ShelveCapacity = r.Element("ShelveCapacity").Value,
                       Rows = r.Element("Rows").Value,
                     };

      foreach (var r in settings)
	    {
		    Console.WriteLine(r.Name);
        Console.WriteLine(r.Shelves);
        Console.WriteLine(r.ShelveCapacity);
        Console.WriteLine(r.Rows);
      }
    }
  }
}
