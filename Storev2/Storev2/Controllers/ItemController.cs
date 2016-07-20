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
      oldHouse.Items[index].Quantity -= quantity;
			sHouse.Items.Add(oldHouse.Items[index]);
			if (oldHouse.Items[index].Quantity == 0)
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

    internal static void MoveToExpShelve(Store store)
    {
      int days = 10;
      DateTime dt = DateTime.Now;
      dt = dt.AddDays(days);

      for (int i = 0; i < store.Shop.Items.Count; i++)
      {
        if (store.Shop.Items[i].ExpDate < dt)
        {
          if (store.Shop.Layout.Shelves[0].Capacity >= store.Shop.Items[i].Quantity)
          {
            store.Shop.Items[i].Location = new List<Location>();
            store.Shop.Items[i].Location.Add(new Location(store.Shop.Name, store.Shop.Layout.Rows, store.Shop.Layout.Shelves.Length));
          }
          else
          {
            int currentCapacity = store.Shop.Layout.Shelves[store.Shop.Layout.Shelves.Length - 1].Capacity - store.Shop.Layout.Shelves[store.Shop.Layout.Shelves.Length - 1].Items;
            Item item = new Item(store.Shop.Items[i].Name, store.Shop.Items[i].Price, store.Shop.Items[i].ExpDate, currentCapacity, store.Shop.Items[i].Category);
            item.Location.Add(new Location(store.Shop.Name, store.Shop.Layout.Rows, store.Shop.Layout.Shelves.Length));
            store.Shop.Items.Add(item);
            store.Stock.Items.Add(item);
          }
        }
      }
      for(int i=0;i<store.WHouses.Length; i++)
        for(int j=0;j<store.WHouses[i].Items.Count; j++)
          if (store.WHouses[i].Items[j].ExpDate < dt)
          {
            if (store.Shop.Layout.Shelves[0].Capacity >= store.WHouses[i].Items[j].Quantity)
            {
              store.WHouses[i].Items[j].Location = new List<Location>();
              store.WHouses[i].Items[j].Location.Add(new Location(store.Shop.Name, store.Shop.Layout.Rows, store.Shop.Layout.Shelves.Length));
              store.Shop.Items.Add(store.WHouses[i].Items[j]);
              store.WHouses[i].Items.Remove(store.WHouses[i].Items[j]);
            }
            else
            {
              int currentCapacity = store.Shop.Layout.Shelves[store.Shop.Layout.Shelves.Length - 1].Capacity - store.WHouses[i].Layout.Shelves[store.WHouses[i].Layout.Shelves.Length - 1].Items;
              Item item = new Item(store.WHouses[i].Items[j].Name, store.WHouses[i].Items[j].Price, store.WHouses[i].Items[j].ExpDate, currentCapacity, store.WHouses[i].Items[j].Category);
              item.Location.Add(new Location(store.Shop.Name, store.Shop.Layout.Rows, store.Shop.Layout.Shelves.Length));
              store.Shop.Items.Add(item);
              store.WHouses[i].Items[j].Quantity -= currentCapacity;
              store.Stock.Items.Add(item);
            }
          }
      ConfirmView.Show(store);
    }
  }
}
