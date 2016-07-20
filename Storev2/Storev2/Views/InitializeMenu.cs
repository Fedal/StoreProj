using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Storev2
{
	class InitializeMenu
	{
		internal static void Show(Store store)
		{
    
			Console.WriteLine("\tShop Layout");
			LayoutControl.SetLayout(store.Shop);
      
			Console.WriteLine("\tWarehouse options");
			WarehouseControl.Set(store);
		}
	}
}
