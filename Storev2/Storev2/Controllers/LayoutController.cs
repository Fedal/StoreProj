using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class LayoutControl
	{
		internal static void SetLayout(IStoreHouse sHouse)
		{
			int shelves;
			int shelveCapacity;
			int rows;

			Console.Write("Number of shelves: ");
			shelves = Int32.Parse(Console.ReadLine());
			Console.Write("Shelve capacity: ");
			shelveCapacity = Int32.Parse(Console.ReadLine());
			Console.Write("Rows: ");
			rows = Int32.Parse(Console.ReadLine());

			sHouse.Layout = new Layout(shelves, shelveCapacity, rows);
		}
	}
}
