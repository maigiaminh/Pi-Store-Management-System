using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DTO
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }

        public Product(int iD, string name, string description, decimal price, int quantity)
        {
            ID = iD;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public Product(DataRow row) 
        {
            ID = (int)row["ID"];
            Name = (string)row["Name"];
            Description = (string)row["Description"];
            Price = (decimal)row["Price"];
            Quantity = (int)row["Quantity"];
        }
    }
}
