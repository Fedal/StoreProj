using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class WarehouseControl
	{
		internal static void Set(Store store)
		{
			int num;
			Console.Write("Number of warehouses: ");
			num = Int32.Parse(Console.ReadLine());

			string name;
			for (int i = 0; i < num; i++)
			{
				Console.Write("Warehouse name: ");
				name = Console.ReadLine();
        store.WHouses.Add(new Warehouse(name));
        LayoutControl.SetLayout(store.WHouses[store.WHouses.Count + i - 1]);
			}
		}
	}
}
