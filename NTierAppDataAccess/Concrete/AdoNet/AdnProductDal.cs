using System.Data;
using Microsoft.Data.SqlClient;
using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Concrete;

namespace NTierApp.DataAccess.Concrete.AdoNet
{
    public class AdnProductDal : IProductDal
    {
        private SqlConnection? _connection;
        private SqlCommand? _sqlCommand;
        private SqlDataReader? _reader;


        public List<Product> GetAll()
        {
            using (_connection)
            {
                _ConnectionControl();
                List<Product> productList = new List<Product>();
                _sqlCommand = new SqlCommand($@"Select * From Products", _connection);
                _reader = _sqlCommand.ExecuteReader();

                while (_reader.Read())
                {
                    Product product = new Product()
                    {
                        ProductId = Convert.ToInt32(_reader["ProductID"]),
                        CategoryId = Convert.ToInt32(_reader["CategoryId"]),
                        ProductName = _reader["ProductName"].ToString(),
                        QuantityPerUnit = _reader["QuantityPerUnit"].ToString(),
                        UnitPrice = Convert.ToDecimal(_reader["UnitPrice"]),
                        UnitsInStock = Convert.ToInt16(_reader["UnitsInStock"])
                    };

                    productList.Add(product);
                }
                _ConnectionClose();
                return productList;
            }

        }

        public Product? Get(int id)
        {
            using (_connection)
            {
                _ConnectionControl();

                Product product = new Product();
                _sqlCommand = new SqlCommand($@"Select * from Products where ProductID=@ProductID", _connection);
                _reader = _sqlCommand.ExecuteReader();

                while (_reader.Read())
                {
                    product.ProductId = Convert.ToInt32(_reader["ProductID"]);
                    product.CategoryId = Convert.ToInt32(_reader["CategoryId"]);
                    product.ProductName = _reader["ProductName"].ToString();
                    product.QuantityPerUnit = _reader["QuantityPerUnit"].ToString();
                    product.UnitPrice = Convert.ToDecimal(_reader["UnitPrice"]);
                    product.UnitsInStock = Convert.ToInt16(_reader["UnitsInStock"]);
                }
                _ConnectionClose();
                return product;
            }
        }

        public void Add(Product entity)
        {
            using (_connection)
            {
                _ConnectionControl();
                _sqlCommand =
                    new SqlCommand(
                        "Insert into Products values(@ProductName, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock)",
                        _connection);
                _sqlCommand.Parameters.AddWithValue("@ProductName", entity.ProductName);
                _sqlCommand.Parameters.AddWithValue("@CategoryID", entity.CategoryId);
                _sqlCommand.Parameters.AddWithValue("@QuantityPerUnit", entity.QuantityPerUnit);
                _sqlCommand.Parameters.AddWithValue("@UnitPrice", entity.UnitPrice);
                _sqlCommand.Parameters.AddWithValue("@UnitsInStock", entity.UnitsInStock);

                _sqlCommand.ExecuteNonQuery();

            }
            _ConnectionClose();
        }

        public void Update(Product entity)
        {
            using (_connection)
            {
                _ConnectionControl();
                _sqlCommand =
                    new SqlCommand(
                        "Update Products set ProductName=@ProductName, CategoryID=@CategoryID, QuantityPerUnit=@QuantityPerUnit, UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock where ProductID=@ProductID",
                        _connection);
                _sqlCommand.Parameters.AddWithValue("@ProductID", entity.ProductId);
                _sqlCommand.Parameters.AddWithValue("@ProductName", entity.ProductName);
                _sqlCommand.Parameters.AddWithValue("@CategoryID", entity.CategoryId);
                _sqlCommand.Parameters.AddWithValue("@QuantityPerUnit", entity.QuantityPerUnit);
                _sqlCommand.Parameters.AddWithValue("@UnitPrice", entity.UnitPrice);
                _sqlCommand.Parameters.AddWithValue("@UnitsInStock", entity.UnitsInStock);

                _sqlCommand.ExecuteNonQuery();

            }
            _ConnectionClose();
        }

        public void Delete(Product entity)
        {
            using (_connection)
            {
                _ConnectionControl();
                _sqlCommand =
                    new SqlCommand(
                        "Delete from Products where ProductID=@ProductID",
                        _connection);
                _sqlCommand.Parameters.AddWithValue("@ProductID", entity.ProductId);

                _sqlCommand.ExecuteNonQuery();

            }
            _ConnectionClose();
        }

        private void _ConnectionControl()
        {
            _connection = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=True;MultipleActiveResultSets=true");
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        private void _ConnectionClose()
        {
            _connection?.Close();
            _reader?.Close();
        }
    }
}
