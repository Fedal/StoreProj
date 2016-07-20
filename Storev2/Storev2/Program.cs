using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Storev2
{
	class Program
	{
		static void Main(string[] args)
		{

			FileGeneratorService.GenerateFiles();
			Store store = new Store();
			InitializeMenu.Show(store);
			MainMenu.Show(store);
		}

	}
}
