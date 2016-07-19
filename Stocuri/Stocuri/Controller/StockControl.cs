using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
	class StockControl
	{
		internal static void AddItem(Store store, Stock stock)
		{
			string name;
			int price = 0;
			DateTime expDate;
			int quantity;
			string category;
			string location;
			int row;

			Console.Write("Item name: ");
			name = Console.ReadLine();
			while (price == 0)
			{
				Console.Write("Item price: ");
				price = Int32.Parse(Console.ReadLine());
				if (price == 0)
					Console.WriteLine("Item can't be free, try again");
			}

			Console.Write("Quantity: ");
			quantity = Int32.Parse(Console.ReadLine());

			Console.Write("Category: ");
			category = Console.ReadLine();

			Console.WriteLine("Item location: ");
			switch (Initializer.LocationMenu())
			{
				case ConsoleKey.D1:
					{
						location = store.Shop.Name;
						break;
					}
				case ConsoleKey.D2:
					{
						location = Initializer.WarehouseMenu(store);
						break;
					}
				default:
					break;
			}

			int year = 0, month = 0, day = 0;
			Console.WriteLine("Expiration date: ");
			Console.Write("\tYear: ");
			year = Int32.Parse(Console.ReadLine());
			Console.Write("\tMonth: ");
			month = Int32.Parse(Console.ReadLine());
			Console.Write("\tDay: ");
			day = Int32.Parse(Console.ReadLine());
			expDate = new DateTime(year, month, day);
			if (expDate < DateTime.Now)
				Console.WriteLine("Item already expired");
			/*else
				if (FindItem(stock, name) >= 0)
				{
					int i = FindItem(stock, name);
					if (stock.Items[i].Price == price)
						stock.Items[i].Quantity += quantity;
					else
						Console.WriteLine("You can't have the same product with different prices !");
				}*/
			else
			{
				Item item = new Item(name, price, expDate, quantity, category, location);
				stock.Items.Add(item);
			}

		}
		internal static int FindItem(Stock stock, string name)
		{
			for (int i = 0; i < stock.Items.Count; i++)
				if (stock.Items[i].Name == name)
					return i;
			return -1;
		}

		internal static void ViewItems(Stock stock)
		{
			Console.WriteLine("Item list");
			for (int i = 0; i < stock.Items.Count; i++)
			{
				Console.WriteLine("\tName: {0}", stock.Items[i].Name);
				Console.WriteLine("\tPrice: {0}", stock.Items[i].Price);
				Console.WriteLine("\tQuantity: {0}", stock.Items[i].Quantity);
				Console.WriteLine("\tCategory: {0}", stock.Items[i].Category);
				Console.WriteLine("\tExpiration date: {0}", stock.Items[i].ExpDate);
				Console.WriteLine("\tLocation: {0}", stock.Items[i].Location);
				Console.WriteLine();
			}
		}
	}
}
