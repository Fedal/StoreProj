using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocuri
{
  class ShopControl
  {
    internal static void MoveToExpirationShelve(Store store, Shop shop)
    {
      int days = 5;
      DateTime dt = DateTime.Now;
      dt = dt.AddDays(days);

      for (int i = 0; i < store.Stock.Items.Count; i++)
      {
        if (store.Stock.Items[i].ExpDate < dt)
        {
          store.Stock.Items[i].Location = "Shop, row" + shop.Layout.Rows.ToString() + ", shelve " + shop.Layout.Shelves.ToString();
          shop.Layout.Shelves[shop.Layout.Shelves.Length - 1].ItemList.Add(store.Stock.Items[i]);
          shop.Items.Add(store.Stock.Items[i]);
        }
      }
      Console.WriteLine("Items moved to expiration shelve");
    }
  }
}
