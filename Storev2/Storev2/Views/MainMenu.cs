using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class MainMenu
  {
    internal static void Show(Store store)
    {
      ConsoleKeyInfo cki;
      Console.Clear();
      Console.WriteLine("MAIN MENU");
      Console.WriteLine("_______________________");
      Console.WriteLine("1. Employee menu");
      Console.WriteLine("2. Store menu");
      Console.WriteLine("3. Item menu");
      Console.WriteLine("4. Save");
      Console.WriteLine("0. Exit");

      cki = Console.ReadKey();
      switch (cki.Key)
      {
        case ConsoleKey.D1:
          {
            EmployeeMenu.Show(store);
            break;
          }
        case ConsoleKey.D2:
          {
            StoreMenu.Show(store);
            break;
          }
        case ConsoleKey.D3:
          {
            ItemMenu.Show(store);
            break;
          }
        case ConsoleKey.D4:
          {
            break;
          }
        case ConsoleKey.D0:
          {
            break;
          }
        default:
          break;
      }
    }
  }
}
