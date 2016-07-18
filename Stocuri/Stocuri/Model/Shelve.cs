using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class Shelve
  {
    static int _capacity;

    public static int Capacity
    {
      get { return Shelve._capacity; }
      set { Shelve._capacity = value; }
    }

    int _items;

    public int Items
    {
      get { return _items; }
      set { _items = value; }
    }

    List<Item> _itemList = new List<Item>();

    internal List<Item> ItemList
    {
      get { return _itemList; }
      set { _itemList = value; }
    }
  }
}
