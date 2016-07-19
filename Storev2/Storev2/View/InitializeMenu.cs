using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class InitializeMenu
	{
		internal static void Show(Store store)
		{
			Console.WriteLine("\tShop Layout");
			LayoutControl.SetLayout(store.Shop);
			Console.WriteLine("\tWarehouse options");
		}
	}
}
