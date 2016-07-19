using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class LocationView
	{

		internal static IStoreHouse Show(Store store)
		{
			Console.WriteLine("\tWhere do you want to place your item?");
			Console.WriteLine("1. {0}", store.Shop.Name);
			for(int i=0;i<store.WHouses.Length;i++)
				Console.WriteLine("{0}. {1}", i+2, store.WHouses[i].Name);
			Console.Write("Index: ");
			int index;
			do
			{
				index = Int32.Parse(Console.ReadLine());
				if (index > store.WHouses.Length + 1)
					Console.WriteLine("Invalid index");
			} while (index > store.WHouses.Length + 1);

			if (index == 1)
				return store.Shop;
			return store.WHouses[index - 1];
		}
	}
}
