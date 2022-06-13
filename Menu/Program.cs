using System.Data.SqlClient;
using System.Collections;
namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            static int MenuAction()
            {
                Console.WriteLine("====== Actions  =====");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Edit product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. View all product");
                Console.WriteLine("5. Search product by id");
                Console.WriteLine(" 6. Search product by name");
                Console.WriteLine(" 7. End");

                int choice = int.Parse(Console.ReadLine());
                return choice;

            }
        }
        public void start()
        {
            while (true)
            {
                int choice = MenuAction();
                switch (choice)
                {
                    case 0:
                        break;
                    case 1:
                        AddProduct();
                        break;
                    case 2:EditProduct();
                            break;
                    case 3:DeleteProduct();
                        break;
                    case 4:ViewAllProduct();
                        break;
                    case 5: SeachByID();
                        break;
                    case 6: SeachByName();
                        break;
                        default:Console.Write("nhap lai");
                            break;
                }
            }
        }

        private int MenuAction()
        {
            throw new NotImplementedException();
        }

        static void AddProduct()
        {
            ConnectionDB connectionDB = new ConnectionDB();
            SqlConnection connection = connectionDB.GetConnection();
            string query = "insert into product values('APTX 4869','2000-12-12','Thuốc Teo Nhỏ','A469','Haibara Ai','1412')";
           ArrayList ar = new ArrayList();
            ar.Add(1);
            connection.Open();

            connection.Close();


        }


        static void EditProduct()
        {

            string connectionString = "Data source = localhost;Initial Catalog =product;User=sa;password = sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Update product set nguoi_chiu_trach_nhiem = 'Joker' where id = 1";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + " desc: " + sqlDataReader[2]);
            }
            connection.Close();
        }

        static void DeleteProduct()
        {

            string connectionString = "Data source = localhost;Initial Catalog =product;User=sa;password = sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Delete product where id = '2'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + " desc: " + sqlDataReader[2]);
            }
            connection.Close();
        }

        static void ViewAllProduct() {
            string connectionString = "Data source = localhost;Initial Catalog =product;User=sa;Password = sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "select * from product";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + " desc: " + sqlDataReader[2] + "Price: " + sqlDataReader[3]);
            }
            connection.Close();
        }

        static void SeachByID() {
            string connectionString = "Data source = localhost;Initial Catalog =product;User=sa;password = sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * from product where pid = '1'";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + " desc: " + sqlDataReader[2] + "Price: " + sqlDataReader[3]);
            }
            connection.Close();
        }

        static void SeachByName()
        {
            string connectionString = "Data source = localhost;Initial Catalog =product;User=sa;password = sa";
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "Select * From product where ten_loai_san_pham = 'Máy Tính Xách Tay Z37' ";
            SqlCommand sqlCommand = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Console.WriteLine("Product name: " + sqlDataReader[1] + " desc: " + sqlDataReader[2] + "Price: " + sqlDataReader[3]);
            }
            connection.Close();
        }
    }
 

}
    