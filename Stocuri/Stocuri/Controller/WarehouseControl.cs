using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class WarehouseControl
  {
    internal static void Show(Warehouse[] warehouse)
    {
      for (int i = 0; i < warehouse.Length; i++)
        Console.WriteLine("{0}. {1}", i + 1, warehouse[i].Name);
    }
  }
}
