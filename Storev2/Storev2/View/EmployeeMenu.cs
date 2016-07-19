using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class EmployeeMenu
	{
		internal static void Show(Store store)
		{
			Console.Clear();
			Console.WriteLine("1. Add employee");
			Console.WriteLine("2. Remove employee");
			Console.WriteLine("3. View employees");
			Console.WriteLine("4. Back");

			ConsoleKeyInfo cki = Console.ReadKey();

			switch (cki.Key)
			{
				case ConsoleKey.D1:
					{
						break;
					}
				case ConsoleKey.D2:
					{
						break;
					}
				case ConsoleKey.D3:
					{
						break;
					}
				case ConsoleKey.D4:
					{
						break;
					}
				default:
					{
						break;
					}
			}
		}
	}
}
