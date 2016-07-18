using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class Warehouse:IStoreHouse
  {

    List<Item> _items = new List<Item>();

    public List<Item> Items
    {
      get { return _items; }
      set { _items = value; }
    }

    string _name;

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public Warehouse(string name)
    {
      this.Name = name;
    }

    Layout _layout;

    public Layout Layout
    {
      get { return _layout; }
      set { _layout = value; }
    }
  }
}
