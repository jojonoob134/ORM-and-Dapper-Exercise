using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var departmentRepo = new DapperDepartmentRepository(conn);

            departmentRepo.InsertDepartments("jorge's new department");

            var depaetments = departmentRepo.GetAllDepartments();

            foreach (var department in depaetments)
            {
                Console.WriteLine(department.Name);
                Console.WriteLine(department.DepartmentId);
                Console.WriteLine();
            }

            var ProductRepo = new DapperProductRepository(conn);

            var products = ProductRepo.GetAllProducts();

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.ProductId);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.CategoryID);
                Console.WriteLine(product.OnSale);
                Console.WriteLine(product.StockLevel);
                Console.WriteLine();
            }
        }
    }
}
