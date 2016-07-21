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
      Item.Add(new XElement("DateofExpiration", itemx.ExpDate.ToString()));
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

    public static void GetItems(Store store)
    {
      XDocument doc = XDocument.Load(path);
      var AllItems = from r in doc.Descendants("Item")
                    select new
                    {
                      name = r.Element("Name").Value.ToString(),
                      price = int.Parse(r.Element("Price").Value),
                      quantity = int.Parse(r.Element("Quantity").Value),
                      category = r.Element("Category").Value.ToString(),
                       dateofexp = DateTime.Parse(r.Element("DateofExpiration").Value),
                      locations =  from rx in r.Element("Locations").Descendants("Location")
                               select new
                             {
                                lName = rx.Element("Name").Value.ToString(),
                                lRow = int.Parse(rx.Element("Row").Value),
                                lShelf = int.Parse(rx.Element("Shelf").Value),
                             },
                    };
      foreach (var x in AllItems)
      {
        Item AnItem = new Item(x.name, x.price, x.dateofexp , x.quantity, x.category);
        foreach (var loc in x.locations)
        {

          AnItem.Location.Add(new Location(loc.lName, loc.lRow, loc.lShelf));
        }
        store.Stock.Items.Add(AnItem);
      }

    }
  }
}
