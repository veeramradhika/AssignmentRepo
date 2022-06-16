using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementAssignment
{
    public class SuperAdmin
    {
        public static string sqlConnectionStr = "Data Source=RADHIKA;Initial Catalog=EventDb;Integrated Security=True";
        public string insertAdmin()
        {
            Console.WriteLine("Enter the Admin Id: ");
            int Aid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Admin Name: ");
            string Aname = Console.ReadLine();

            Console.WriteLine("Enter the Admin Roll: ");
            string Aroll = Console.ReadLine();

            
            //inserting the asdmin values into the sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Admin values(" + Aid + ",'" + Aname + "','" + Aroll + "' )", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "values are inserted";
        }
        public string UpdateAdmin()
        {
            Console.WriteLine("Enter the Admin Id: ");
            int Aid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Admin Name: ");
            string Aname = Console.ReadLine();

            Console.WriteLine("Enter the Admin Roll: ");
            string Aroll = Console.ReadLine();

            //update Admin data into sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Admin set Aname='" + Aname + "' , Aroll='" + Aroll + "'  where Aid=" + Aid + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }
        public string DeleteAdmin(int Aid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("delete from Admin where Aid=" + Aid, sqlConnection);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close(); 
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }
        public DataTable SelectAdmin()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Admin", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            sqlConnection.Close(); 
            return dataTable;
        }
        public DataTable SelectAdminById(int Aid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Admin where Aid=" + Aid, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            sqlConnection.Close();
            return dataTable;
        }

    }
}
