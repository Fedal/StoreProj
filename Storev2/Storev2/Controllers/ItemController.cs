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

		}
	}
}
