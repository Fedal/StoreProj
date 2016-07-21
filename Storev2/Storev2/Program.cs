using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Storev2
{
	class Program
	{
    static void Main(string[] args)
    {
      Store store = new Store();

      if (!File.Exists(Directory.GetCurrentDirectory() + "\\Data\\StoreSetings.xml"))
      {
        FileGeneratorService.GenerateFiles();
        InitializeMenu.Show(store);
      }
      else
      {
        FileStoreCotroler.GetLayout(store);
        FileEmpolyeeControler.GetEmps(store);
      }

      MainMenu.Show(store);
    }
	}
}
