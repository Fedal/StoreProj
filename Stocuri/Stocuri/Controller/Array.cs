using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class Array<T>
  {
    Dictionary<string, T> keys = new Dictionary<string, T>();

    internal int Add(string s, T val)
    {
      if (!keys.ContainsKey(s)){
        keys.Add(s, val);
        return 1;
      }
      else
        return 0;
    }

    internal T this[string key]
    {
      get
      {
        if (keys.ContainsKey(key))
          return keys[key];
        else
          throw new Exception("Item not found");
      }
    }

    internal int Count
    { get { return keys.Count; } }

    internal bool Contains(string item)
    {
      try
      {
        if (keys[item] is T)
          return true;
      }
      catch(Exception)
      {
        //Console.WriteLine("Item not found");
      }
      return false;
    }

  }
}
