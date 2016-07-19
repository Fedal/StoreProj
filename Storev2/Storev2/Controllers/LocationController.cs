using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class LocationController
	{

		internal static Location SetLocation(IStoreHouse sHouse,ref int quantity)
		{
			Location loc;

			loc = LocationDetalis(sHouse,ref quantity);
			return loc;
		}

		private static Location LocationDetalis(IStoreHouse sHouse, ref int quantity)
		{
			int row = 0;
			int shelve = 0;
			do
			{
				Console.Write("Quantity: ");
				quantity = Int32.Parse(Console.ReadLine());
				do
				{
					Console.Write("Select row: ");
					row = Int32.Parse(Console.ReadLine());
					if (row == 0 || row > sHouse.Layout.Rows)
						Console.WriteLine("There is no row {0}", row);
				} while (row == 0 || row > sHouse.Layout.Rows);
				do
				{
					Console.Write("Select shelve: ");
					shelve = Int32.Parse(Console.ReadLine());
					if (shelve == 0 || shelve > sHouse.Layout.Shelves.Length)
						Console.WriteLine("There is no shelve {0}", shelve);
				} while (shelve == 0 || shelve > sHouse.Layout.Shelves.Length);
				if (quantity > sHouse.Layout.Shelves[shelve - 1].Capacity - sHouse.Layout.Shelves[shelve - 1].Items)
					Console.WriteLine("Shelve not available");
			} while (quantity > sHouse.Layout.Shelves[shelve - 1].Capacity - sHouse.Layout.Shelves[shelve - 1].Items);

			return new Location(sHouse.Name, row, shelve);
		}
	}
}
