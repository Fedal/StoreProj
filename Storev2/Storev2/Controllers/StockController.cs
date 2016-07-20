using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class StockController
  {
    internal static int FindItemByName(Store store, string name)
    {
      for (int i = 0; i < store.Stock.Items.Count; i++)
        if (store.Stock.Items[i].Name == name)
          return i;
      return -1;
    }
  }
}
