using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class Store
  {
    List<IEmployee> _employees = new List<IEmployee>();

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

    Shop _shop = new Shop();

    internal Shop Shop
    {
      get { return _shop; }
      set { _shop = value; }
    }
  }
}
