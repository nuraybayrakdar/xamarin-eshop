using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Navigation2.Models
{
    public class CartItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public float Total { get; set; }

        public CartItem(Product product, int amount)
        {
            Product = product;
            Amount = amount;
            Total = 0;
        }

        public CartItem()
        {

        }
    }
}
