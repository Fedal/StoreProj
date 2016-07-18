using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class Store
  {
    List<IEmployee> _employees = new List<IEmployee>();
    Layout _layout;

    internal Layout Layout
    {
      get { return _layout; }
      set { _layout = value; }
    }
    Warehouse[] _wHouses;

    internal Warehouse[] WHouses
    {
      get { return _wHouses; }
      set { _wHouses = value; }
    }
    Stock _stock = new Stock();

    internal Stock Stock
    {
      get { return _stock; }
      set { _stock = value; }
    }

    internal List<IEmployee> Employees
    {
      get { return _employees; }
    }

    Shop _shop;

    internal Shop Shop
    {
      get { return _shop; }
      set { _shop = value; }
    }
  }
}
