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
      Console.WriteLine("asdwefdewdwwedwed");
			Store store = new Store();
			InitializeMenu.Show(store);
			MainMenu.Show(store);
		}

	}
}
