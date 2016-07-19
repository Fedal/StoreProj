using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class Layout
  {
    Shelve[] _shelves;

    internal Shelve[] Shelves
    {
      get { return _shelves; }
      set { _shelves = value; }
    }

    int _rows;

    public int Rows
    {
      get { return _rows; }
      set { _rows = value; }
    }

    public Layout(int shelves, int shelveCapacity, int rows)
    {
      this.Shelves = new Shelve[shelves];
      for (int i = 0; i < shelves; i++)
        Shelves[i] = new Shelve(shelveCapacity);
      this.Rows = rows;
    }
  }
}
