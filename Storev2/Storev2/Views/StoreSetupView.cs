using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class StoreSetupView
  {
    internal static void ShowStoreSetup(Store store)
    {
      //store.Shop.Layout.Shelves.Length
      //store.Shop.Layout.Shelves.Capacity
      //store.Shop.Layout.Rows
      Console.Clear();
      Console.WriteLine("Current store setup");
      Console.WriteLine("__________________________");
      Console.WriteLine("Current number of shelves: {0}", store.Shop.Layout.Shelves.Length);
      Console.WriteLine("Current capacity for the shelves: {0}", store.Shop.Layout.Shelves[0].Capacity);
      Console.WriteLine("Current number of rows: {0}",store.Shop.Layout.Rows);
      Console.WriteLine("\nWarehouses: ");
      foreach(Warehouse w in store.WHouses)
      {
        Console.WriteLine("\n\tName: {0}",w.Name);
        Console.WriteLine("\tShelve number: {0}",w.Layout.Shelves.Length);
        Console.WriteLine("\tShelve capacity: {0}",w.Layout.Shelves[0].Capacity);
        Console.WriteLine("\tNumber of rows: {0}",w.Layout.Rows);
      }
      Console.WriteLine("\nPress any key to continue...");
      Console.ReadKey();
    }
  }
}
