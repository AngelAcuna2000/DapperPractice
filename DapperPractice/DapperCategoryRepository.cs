using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperPractice
{
    public class DapperCategoryRepository : ICategoryRepository
    {
        private readonly IDbConnection _conn;

        public DapperCategoryRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories");
        }

        public void InsertCategories(string name)
        {
            _conn.Execute("INSERT INTO categories (Name) VALUES (@name)", 
                new {name = name });
        }
    }
}
