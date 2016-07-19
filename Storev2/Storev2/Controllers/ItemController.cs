using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class ItemController
	{
		internal static void Add(Store store, Item item)
		{
			store.Stock.Items.Add(item);
			ConfirmView.Show(store);
		}

		internal static void Move(Store store)
		{
			Console.WriteLine("From where do you want to move?");
			IStoreHouse oldHouse = LocationView.Show(store);
			Console.WriteLine("What do you want to move? ");
			string item = "";
			int index = 0;
			do
			{
				Console.Write("Select item: ");
				item = Console.ReadLine();
				index = FindItem(oldHouse, item);
				if (index == -1)
					Console.WriteLine("We don't have that!");
			} while (index == -1);

			int quantity = 0;
			Console.WriteLine("\tWhere do you want to place your item?");
			IStoreHouse sHouse = LocationView.Show(store);
			Location loc = LocationController.SetLocation(sHouse, ref quantity);
			oldHouse.Items[index].Location.Add(loc);
			sHouse.Items.Add(oldHouse.Items[index]);
			if (quantity == oldHouse.Items[index].Quantity)
			{
				oldHouse.Items[index].Location.RemoveAt(0);
				oldHouse.Items.RemoveAt(index);
			}

			ConfirmView.Show(store);
		}

		internal static int FindItem(IStoreHouse sHouse, string item)
		{
			for (int i = 0; i<sHouse.Items.Count; i++)
				if (sHouse.Items[i].Name == item)
					return i;
			return -1;
		}

		internal static void ViewAllItems(Store store)
		{
			for(int i=0;i<store.Stock.Items.Count; i++)
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
					Console.WriteLine();
				}
			}
			ConfirmView.Show(store);
		}
	}
}
