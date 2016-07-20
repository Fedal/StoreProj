using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;


namespace Storev2
{
  class FileInventoryControl
  {
    static string path = Directory.GetCurrentDirectory() + "\\Data\\Inventory.xml";
    public static void Add(Item itemx)
    {
      XDocument doc = XDocument.Load(path);
      XElement Item = new XElement("Item");

      Item.Add(new XElement("Name", itemx.Name));
      Item.Add(new XElement("Price", itemx.Price.ToString()));
      Item.Add(new XElement("Quantity", itemx.Quantity.ToString()));
      Item.Add(new XElement("Category", itemx.Category));
      XElement Locations = new XElement("Locations");
      foreach (Location x in itemx.Location)
      {
        XElement Location = new XElement("Location",
          new XElement("Name", x.Name),
             new XElement("Row", x.Row),
                new XElement("Shelf", x.Shelve));
              Locations.Add(Location);
      }

      Item.Add(Locations);
      doc.Root.Add(Item);
      doc.Save(path);
    }
  }
}
