using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storev2
{
  class Item
  {
    string _name;

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }
    int _price;

    public int Price
    {
      get { return _price; }
      set { _price = value; }
    }
    DateTime _expDate;

    public DateTime ExpDate
    {
      get { return _expDate; }
      set { _expDate = value; }
    }

    int _quantity;

    public int Quantity
    {
      get { return _quantity; }
      set { _quantity = value; }
    }

    string _category = "Warehouse";

    public string Category
    {
      get { return _category; }
      set { _category = value; }
    }

	Location _location;

    public Location Location
    {
      get { return _location; }
      set { _location = value; }
    }

    public Item(string name, int price, DateTime expDate, int quantity, string category)
    {
      this.Name = name;
      this.Price = price;
      this.ExpDate = expDate;
      this.Quantity = quantity;
      this.Category = category;
    }
  }
}
