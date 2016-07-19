using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class Stock
  {
    List<Item> _items = new List<Item>();

    internal List<Item> Items
    {
      get { return _items; }
      set { _items = value; }
    }
  }
}

