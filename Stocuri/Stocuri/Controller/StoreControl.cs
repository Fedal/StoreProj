using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class StoreControl
  {
    internal static void SetShop(Store store)
    {
      store.Shop = new Shop();
      SetLayout(store.Shop);
    }

    internal static void SetWarehouses(Store store)
    {
      int num;
      Console.Write("Number of warehouses: ");
      num = Int32.Parse(Console.ReadLine());

      store.WHouses = new Warehouse[num];

      string name;
      for (int i = 0; i < num; i++)
      {
        Console.Write("Warehouse name: ");
        name = Console.ReadLine();
        store.WHouses[i] = new Warehouse(name);
        SetLayout(store.WHouses[i]);
      }
    }

    internal static void CalculatePotentialProfit(Store store)
    {
      int s = 0;
      for (int i = 0; i < store.Stock.Items.Count; i++)
        s += store.Stock.Items[i].Quantity * store.Stock.Items[i].Price;

      Console.WriteLine("Potential profit: {0}", s);
    }

    internal static void SetLayout(IStoreHouse sHouse)
    {
      int shelves;
      int shelveCapacity;
      int rows;

      Console.Write("Number of shelves: ");
      shelves = Int32.Parse(Console.ReadLine());
      Console.Write("Shelve capacity: ");
      shelveCapacity = Int32.Parse(Console.ReadLine());
      Console.Write("Rows: ");
      rows = Int32.Parse(Console.ReadLine());

      sHouse.Layout = new Layout(shelves, shelveCapacity, rows);
    }
  }
}
