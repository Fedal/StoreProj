﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class ItemMenu
	{
		internal static void Show(Store store)
		{
			Console.Clear();
			Console.WriteLine("1. Add item");
			Console.WriteLine("2. Move item");
			Console.WriteLine("3. View item by name");
			Console.WriteLine("4. View all items");
			Console.WriteLine("5. Move items to expiration shelve");
			Console.WriteLine("6. Back");

			ConsoleKeyInfo cki = Console.ReadKey();

			switch (cki.Key)
			{
				case ConsoleKey.D1:
				{
					ItemController.Add(store, NewItem(store));
					break;
				}
				default:
				{
					break;
				}
			}
		}

		private static Item NewItem(Store store)
		{
			Console.Write("Name: ");
			string name = Console.ReadLine();

			Console.Write("Category: ");
			string category = Console.ReadLine();

			int price = 0;
			while (price == 0)
			{
				Console.Write("Item price: ");
				price = Int32.Parse(Console.ReadLine());
				if (price == 0)
					Console.WriteLine("Item can't be free, try again");
			}

			int quantity = 0;

			Console.WriteLine("Item location: ");
			Location loc = LocationController.SetLocation(store,ref quantity);

			DateTime expDate;
			do
			{
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
			} while (expDate < DateTime.Now);

			Item item = new Item(name, price, expDate, quantity, category);
			item.Location = loc;
			return item;
		}
	}
}
