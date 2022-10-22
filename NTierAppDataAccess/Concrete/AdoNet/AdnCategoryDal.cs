using System.Data;
using Microsoft.Data.SqlClient;
using NTierApp.DataAccess.Abstract;
using NTierApp.Entities.Concrete;

namespace NTierApp.DataAccess.Concrete.AdoNet
{
    public class AdnCategoryDal : ICategoryDal
    {
        private SqlConnection? _connection;
        private SqlCommand? _sqlCommand;
        private SqlDataReader? _reader;


        public List<Category> GetAll()
        {
            using (_connection)
            {
                _ConnectionControl();
                List<Category> categoryList = new List<Category>();
                _sqlCommand = new SqlCommand($@"Select * From Categories", _connection);
                _reader = _sqlCommand.ExecuteReader();

                while (_reader.Read())
                {
                    Category category = new Category()
                    {
                        CategoryId = Convert.ToInt32(_reader["CategoryID"]),
                        CategoryName = _reader["CategoryName"].ToString(),
                    };

                    categoryList.Add(category);
                }
                _ConnectionClose();
                return categoryList;
            }

        }

        public Category? Get(int id)
        {
            using (_connection)
            {
                _ConnectionControl();

               Category category = new Category();
                _sqlCommand = new SqlCommand($@"Select * from Categories where CategoryID=@CategoryID", _connection);
                _reader = _sqlCommand.ExecuteReader();

                while (_reader.Read())
                {
                    category.CategoryId = Convert.ToInt32(_reader["CategoryID"]);
                    category.CategoryName = _reader["CategoryName"].ToString();
                }
                _ConnectionClose();
                return category;
            }
        }

        public void Add(Category entity)
        {
            using (_connection)
            {
                _ConnectionControl();
                _sqlCommand =
                    new SqlCommand(
                        "Insert into Categories values(@CategoryName)",
                        _connection);
                _sqlCommand.Parameters.AddWithValue("@CategoryName", entity.CategoryName);

                _sqlCommand.ExecuteNonQuery();

            }
            _ConnectionClose();
        }

        public void Update(Category entity)
        {
            using (_connection)
            {
                _ConnectionControl();
                _sqlCommand =
                    new SqlCommand(
                        "Update Categories set CategoryName=@CategoryName where CategoryID=@CategoryID",
                        _connection);
                _sqlCommand.Parameters.AddWithValue("@CategoryID", entity.CategoryId);
                _sqlCommand.Parameters.AddWithValue("@CategoryName", entity.CategoryName);

                _sqlCommand.ExecuteNonQuery();

            }
            _ConnectionClose();
        }

        public void Delete(Category entity)
        {
            using (_connection)
            {
                _ConnectionControl();
                _sqlCommand =
                    new SqlCommand(
                        "Delete from Categories where CategoryID=@CategoryID",
                        _connection);
                _sqlCommand.Parameters.AddWithValue("@CategoryID", entity.CategoryId);

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
