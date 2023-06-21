using DapperPractice;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

var categoryRepo = new DapperCategoryRepository(conn);

var categories = categoryRepo.GetAllCategories();

foreach (var category in categories)
{
    Console.WriteLine(category.CategoryID);
    Console.WriteLine(category.Name);
    Console.WriteLine();
    Console.WriteLine();
}