using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class StoreMenu
  {
    internal static void Show(Store store)
    {
      ConsoleKeyInfo input;
      do
      {
        Console.Clear();
        Console.WriteLine("\t\tSTORE MENU");
        Console.WriteLine("1. Set shop");
        Console.WriteLine("2. Set warehouse");
        Console.WriteLine("3. View current store settings");
        Console.WriteLine("0. Go back to menu");
        input = Console.ReadKey();
        switch (input.Key)
        {
          case ConsoleKey.D1:
            LayoutControl.SetLayout(store.Shop);
            break;
          case ConsoleKey.D2:
            WarehouseControl.Set(store);
            break;
          case ConsoleKey.D3:
            StoreSetupView.ShowStoreSetup(store);
            break;
          case ConsoleKey.D0:
            break;
          default:
            Console.WriteLine("[!]Invalid entry");
            break;
        }
      } while (input.Key != ConsoleKey.D0);
    }
  }
}
