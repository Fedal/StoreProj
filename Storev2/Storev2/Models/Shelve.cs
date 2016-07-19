using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class Shelve
  {
    int _capacity;

    public int Capacity
    {
      get { return _capacity; }
      set { _capacity = value; }
    }

    int _items;

	public Shelve(int shelveCapacity)
	{
		// TODO: Complete member initialization
		Capacity = shelveCapacity;
	}

    public int Items
    {
      get { return _items; }
      set { _items = value; }
    }
  }
}
