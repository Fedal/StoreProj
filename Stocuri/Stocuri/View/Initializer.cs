using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
	class Initializer
	{
		Store store = new Store();

		internal void Start()
		{
			StoreInitialize();

			Console.Clear();
			Console.WriteLine("1. Add employee");
			Console.WriteLine("2. View employees");
			Console.WriteLine("3. Warehouse options");
			Console.WriteLine("4. Shop layout");
			Console.WriteLine("5. Add item");
			Console.WriteLine("6. Organize items");
			Console.WriteLine("7. View all items");
			Console.WriteLine("8. Move to expiration shelve");
			Console.WriteLine("9. Calculate potential profit");
			Console.WriteLine("0. Exit");

			SelectOption();
		}

		private void StoreInitialize()
		{
			Console.WriteLine("\tShop Layout");
			StoreControl.SetShop(store);
			Console.WriteLine("\tWarehouse options");
			StoreControl.SetWarehouses(store);
		}

		internal void SelectOption()
		{
			ConsoleKeyInfo cki;
			do
			{
				cki = Console.ReadKey();
				switch (cki.Key)
				{
					case ConsoleKey.D0:
						{
							break;
						}
					case ConsoleKey.D1:
						{
							Employ.Hire(store);
							break;
						}
					case ConsoleKey.D2:
						{
							Employ.ViewEmployees(store);
							break;
						}
					case ConsoleKey.D3:
						{
							StoreControl.SetWarehouses(store);
							break;
						}
					case ConsoleKey.D4:
						{
							StoreControl.SetLayout(store.Shop);
							break;
						}
					case ConsoleKey.D5:
						{
							StockControl.AddItem(store, store.Stock);
							break;
						}
					case ConsoleKey.D6:
						{
							Organizer();
							break;
						}
					case ConsoleKey.D7:
						{
							StockControl.ViewItems(store.Stock);
							break;
						}
					case ConsoleKey.D8://by default, the expiration shelve is the last shelve
						{
							ShopControl.MoveToExpirationShelve(store, store.Shop);
							break;
						}
					case ConsoleKey.D9:
						{
							StoreControl.CalculatePotentialProfit(store);
							break;
						}
					default:
						{
							Console.WriteLine("Invalid Entry");
							break;
						}
				}
			} while (cki.Key != ConsoleKey.D0);
			Console.WriteLine();
		}

		private void Organizer()
		{
			Console.WriteLine("\tWhat do you want to organize?");
			Console.WriteLine("1. Shop");
			Console.WriteLine("2. Warehouse");
			Console.WriteLine("0. Exit");

			ConsoleKeyInfo cki = Console.ReadKey();

			switch (cki.Key)
			{
				case ConsoleKey.D0:
					break;
				case ConsoleKey.D1:
					{
						ItemController.SetLocation(store, store.Shop);
						break;
					}
				case ConsoleKey.D2:
					{
						Console.WriteLine("\tSelect warehouse ");
						WarehouseControl.Show(store.WHouses);
						int index = 0;
						do
						{
							Console.Write("Index: ");
							index = Int32.Parse(Console.ReadLine());
							if (index > store.WHouses.Length)
								Console.WriteLine("We don't that warehouse");
						} while (index > store.WHouses.Length);

						ItemController.SetLocation(store, store.WHouses[index - 1]);
						break;
					}
				default:
					break;
			}
		}

		internal static ConsoleKey LocationMenu()
		{
			Console.WriteLine("1. Shop");
			Console.WriteLine("2. Warehouse");
			ConsoleKeyInfo cki = Console.ReadKey();

			return cki.Key;
		}

		internal static string WarehouseMenu(Store store)
		{
			for(int i=0;i<store.WHouses.Length; i++)
				Console.WriteLine("{0}. {1}", i+1, store.WHouses[i].Name);

			int index=0;
			do
			{
				Console.Write("Index: ");
				index = Int32.Parse(Console.ReadLine());
				if(index>store.WHouses.Length)
					Console.WriteLine("Index too big, try again");
			} while (index > store.WHouses.Length);

			return store.WHouses[index - 1].Name;
		}
	}
}