using Microsoft.Data.SqlClient;
using PiStoreManagementSytem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiStoreManagementSytem.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;

        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }

        private ProductDAO() { }

        public List<Product> LoadProductList()
        {
            List<Product> products = new List<Product>();

            string query = "SELECT * FROM dbo.Product";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Product p = new Product(item);
                products.Add(p);
            }

            return products;
        }

        public DataTable LoadProductTable()
        {
            string query = "SELECT * FROM dbo.Product";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool AddProduct(string name, string description, decimal price, int quantity)
        {
            string query = "INSERT INTO Product (Name, Description, Price, Quantity) VALUES (@Name, @Description, @Price, @Quantity)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
                new SqlParameter("@Price", price),
                new SqlParameter("@Quantity", quantity),
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteProduct(int id)
        {
            string query = "DELETE FROM Product WHERE ID = @ID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id)
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateProduct(int id, string name, string description, decimal price, int quantity)
        {
            string query = "UPDATE Product " +
                           "SET Name = @Name, Description = @Description, Price = @Price, Quantity = @Quantity " +
                           "WHERE ID = @ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
                new SqlParameter("@Price", price),
                new SqlParameter("@Quantity", quantity),
            };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public Product GetProductById(int id)
        {
            string query = "SELECT * FROM Product WHERE ID = @id";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new SqlParameter[] { new SqlParameter("@id", id) });

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                Product product = new Product(row);
                return product;
            }

            return null; 
        }

        public bool CanDeleteProduct(int prodID)
        {
            bool hasOrders = false;

            string query = "SELECT COUNT(*) FROM OrderItem WHERE ProductID = @ProductID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ProductID", prodID)
            };

            int orderCount = (int)DataProvider.Instance.ExecuteScalar(query, parameters);

            if (orderCount > 0)
            {
                hasOrders = true;
            }
            return !hasOrders;
        }
    }
}
