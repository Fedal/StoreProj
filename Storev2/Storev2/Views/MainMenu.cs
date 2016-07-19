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
			Console.Clear();

			Console.WriteLine("1. Employee menu");
			Console.WriteLine("2. Store menu");
			Console.WriteLine("3. Item menu");
			Console.WriteLine("4. Save");
			Console.WriteLine("0. Exit");

			ConsoleKeyInfo cki = Console.ReadKey();
			switch(cki.Key)
			{
				case ConsoleKey.D1:
				{
					EmployeeMenu.Show(store);
					break;
				}
				case ConsoleKey.D2:
				{
					StoreMenu.Show();
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
