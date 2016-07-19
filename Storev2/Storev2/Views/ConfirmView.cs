using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
	class ConfirmView
	{

		internal static void Show(Store store)
		{
			Console.WriteLine("Action performed, press any key to return");
			Console.ReadKey();
			MainMenu.Show(store);
		}
	}
}
