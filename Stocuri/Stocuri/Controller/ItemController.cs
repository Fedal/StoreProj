using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
	class ItemController
	{
		internal static void SetLocation(Store store, IStoreHouse sHouse)
		{
			string item = "";
			int index = 0;
			do
			{
				Console.Write("Select item: ");
				item = Console.ReadLine();
				index = StockControl.FindItem(store.Stock, item);
				if (index == -1)
					Console.WriteLine("We don't have that!");
			} while (index == -1);

			int row = 0;

			do
			{
				Console.Write("Select row: ");
				row = Int32.Parse(Console.ReadLine());
				if (row == 0 || row > sHouse.Layout.Rows)
					Console.WriteLine("There is no row {0}", row);
			} while (row == 0 || row > sHouse.Layout.Rows);

			int shelve = 0;
			int quantity = 0;

			do
			{
				do
				{
					Console.Write("Quantity: ");
					quantity = Int32.Parse(Console.ReadLine());
					if (quantity == 0 || quantity > store.Stock.Items[index].Quantity)
						Console.WriteLine("Invalid quantity");
				} while (quantity == 0 || quantity > store.Stock.Items[index].Quantity);

				do
				{
					Console.Write("Select shelve: ");
					shelve = Int32.Parse(Console.ReadLine());
					if (shelve == 0 || shelve > sHouse.Layout.Shelves.Length)
						Console.WriteLine("There is no shelve {0}", shelve);
				} while (shelve == 0 || shelve > sHouse.Layout.Shelves.Length);
				if (quantity > Shelve.Capacity - sHouse.Layout.Shelves[shelve].Items)
					Console.WriteLine("Shelve not available");
			} while (quantity > Shelve.Capacity - sHouse.Layout.Shelves[shelve].Items);
			store.Stock.Items[index].Quantity -= quantity;

			if (store.Stock.Items[index].Location == "Not assigned yet")
				store.Stock.Items[index].Location = sHouse.Name + ", row " + row.ToString() + ", shelve " + shelve.ToString();
			else
				store.Stock.Items[index].Location += "\n\t\t  " + sHouse.Name + ", row " + row.ToString() + ", shelve " + shelve.ToString();

			Item i = new Item(item, store.Stock.Items[index].Price, store.Stock.Items[index].ExpDate, quantity, store.Stock.Items[index].Category);

			sHouse.Layout.Shelves[shelve].ItemList.Add(i);
			sHouse.Items.Add(i);
		}
	}
}
