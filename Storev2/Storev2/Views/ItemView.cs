using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class ItemView
  {
    internal static void ViewAllItems(Store store)
    {
      for (int i = 0; i < store.Stock.Items.Count; i++)
      {
        Console.WriteLine("\tName: {0}", store.Stock.Items[i].Name);
        Console.WriteLine("\tCategory: {0}", store.Stock.Items[i].Category);
        Console.WriteLine("\tPrice: {0}", store.Stock.Items[i].Price);
        Console.WriteLine("\tQuantity: {0}", store.Stock.Items[i].Quantity);
        Console.WriteLine("\tExpiration Date: {0}", store.Stock.Items[i].ExpDate);
        Console.WriteLine("\tLocation: ");
        for (int j = 0; j < store.Stock.Items[i].Location.Count; j++)
        {
          Console.WriteLine("\t\t{0}, row {1}, shelve {2}", store.Stock.Items[i].Location[j].Name,
           store.Stock.Items[i].Location[j].Row,
           store.Stock.Items[i].Location[j].Shelve);
        }
      }
      ConfirmView.Show(store);
    }

    internal static void ViewItemByName(Store store)
    {
      string name = "";
      int index = 0;
      do
      {

        Console.WriteLine("What item do you want to view?");
        name = Console.ReadLine();
        index = StockController.FindItemByName(store, name);
        if (index == -1)
          Console.WriteLine("We don't have that!");
      } while (index == -1);

      Console.WriteLine("\tName: {0}", store.Stock.Items[index].Name);
      Console.WriteLine("\tCategory: {0}", store.Stock.Items[index].Category);
      Console.WriteLine("\tPrice: {0}", store.Stock.Items[index].Price);
      Console.WriteLine("\tQuantity: {0}", store.Stock.Items[index].Quantity);
      Console.WriteLine("\tExpiration Date: {0}", store.Stock.Items[index].ExpDate);
      Console.WriteLine("\tLocation: ");
      for (int j = 0; j < store.Stock.Items[index].Location.Count; j++)
      {
        Console.WriteLine("\t\t{0}, row {1}, shelve {2}", store.Stock.Items[index].Location[j].Name,
         store.Stock.Items[index].Location[j].Row,
         store.Stock.Items[index].Location[j].Shelve);
      }
      ConfirmView.Show(store);
    }

    internal static void ViewExpirationShelve(Store store)
    {
      //Console.WriteLine("\tName: {0}", store.Stock.Items[i].Name);
      //Console.WriteLine("\tCategory: {0}", store.Stock.Items[i].Category);
      //Console.WriteLine("\tPrice: {0}", store.Stock.Items[i].Price);
      //Console.WriteLine("\tQuantity: {0}", store.Stock.Items[i].Quantity);
      //Console.WriteLine("\tExpiration Date: {0}", store.Stock.Items[i].ExpDate);
      //Console.WriteLine("\tLocation: ");
      //for (int j = 0; j < store.Stock.Items[i].Location.Count; j++)
      //{
      //  Console.WriteLine("\t\t{0}, row {1}, shelve {2}", store.Stock.Items[i].Location[j].Name,
      //   store.Stock.Items[i].Location[j].Row,
      //   store.Stock.Items[i].Location[j].Shelve);
      //}
      int expirationShelveIndex = store.Shop.Layout.Shelves.Length;
      Console.WriteLine("\n=== EXPIRATION SHELVE ITEMS ===");
      for (int i = 0; i < store.Stock.Items.Count; i++ )
        for (int j = 0; j < store.Stock.Items[i].Location.Count; j++)
        {
          if (store.Stock.Items[i].Location[j].Shelve == store.Shop.Layout.Shelves.Length)
          {
            Console.WriteLine("\n\tName: {0}", store.Stock.Items[i].Name);
            Console.WriteLine("\tCategory: {0}", store.Stock.Items[i].Category);
            Console.WriteLine("\tPrice: {0}", store.Stock.Items[i].Price);
            Console.WriteLine("\tQuantity: {0}", store.Stock.Items[i].Quantity);
            Console.WriteLine("\tExp. Date: {0}\n", store.Stock.Items[i].ExpDate);
          }
        }
      ConfirmView.Show(store);
    }
  }
}
