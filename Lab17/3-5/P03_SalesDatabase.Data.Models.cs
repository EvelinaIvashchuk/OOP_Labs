using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = "No description";
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }

    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

    }

    public class Sale
    {
        public int SaleId { get; set; }
        public DateTime Time { get; set; }

        public int StoreId { get; set; }
        public Store Store { get; set; }

        public int CustomerId {  get; set; }
        public Customers Customers { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }

    public class Customers
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber {  get; set; }

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }

}
