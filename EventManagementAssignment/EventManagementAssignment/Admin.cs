using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EventManagementAssignment
{
    public class Admin
    {
        public static string sqlConnectionStr = "Data Source=RADHIKA;Initial Catalog=EventDb;Integrated Security=True";
        public string insertEvent()
        {
            Console.WriteLine("Enter the Event Id: ");
            int Eid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Name: ");
            string Ename = Console.ReadLine();

            Console.WriteLine("Enter the Event Type: ");
            string Etype = Console.ReadLine();

            Console.WriteLine("Enter the Venue: ");
            string Venue = Console.ReadLine();

            Console.WriteLine("Enter the Venue Cost: ");
            Double VCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Equipment: ");
            string Equipment = Console.ReadLine();

            Console.WriteLine("Enter the Equipment Cost: ");
            Double ECost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Food: ");
            string Food = Console.ReadLine();

            Console.WriteLine("Enter the Food Cost: ");
            Double FCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Lights: ");
            string Light = Console.ReadLine();

            Console.WriteLine("Enter the Lights Cost: ");
            Double LCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Flowers: ");
            string Flower = Console.ReadLine();

            Console.WriteLine("Enter the Flowers Cost: ");
            Double FloCost = Convert.ToDouble(Console.ReadLine());

            //inserting the Event values into the sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Event values(" + Eid + ",'" + Ename + "','" + Etype + "', " +
                "'" + Venue + "'," + VCost + ",'"+ Equipment +"'," + ECost + ",'" + Food + "'," + FCost + 
                ",'" + Light + "'," + LCost + ",'" + Flower + "'," + FloCost + ")", sqlConnection);
            sqlConnection.Open();
            int result=cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
                return "Not inserted";
            return "values are inserted";
        }
        public string UpdateEvent()
        {
            Console.WriteLine("Enter the Event Id: ");
            int Eid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Name: ");
            string Ename = Console.ReadLine();

            Console.WriteLine("Enter the Event Type: ");
            string Etype = Console.ReadLine();

            Console.WriteLine("Enter the Venue: ");
            string Venue = Console.ReadLine();

            Console.WriteLine("Enter the Venue Cost: ");
            Double VCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Equipment: ");
            string Equipment = Console.ReadLine();

            Console.WriteLine("Enter the Equipment Cost: ");
            Double ECost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Food: ");
            string Food = Console.ReadLine();

            Console.WriteLine("Enter the Food Cost: ");
            Double FCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Light: ");
            string Light = Console.ReadLine();

            Console.WriteLine("Enter the Light Cost: ");
            Double LCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Flower: ");
            string Flower = Console.ReadLine();

            Console.WriteLine("Enter the Flower Cost: ");
            Double FloCost = Convert.ToDouble
                (Console.ReadLine());

            
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("update Event set Ename='" + Ename + "',Etype='" + Etype + "', " +
               "Venue='" + Venue + "',VCost=" + VCost + ",Equipment='" + Equipment + "',ECost=" + ECost + ",Food='" + Food + "',FCost" + FCost +
               ",Light='" + Light + "',LCost=" + LCost + ",Flower='" + Flower + "',FloCost=" + FloCost + " where Eid=" + Eid + "", sqlConnection);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close(); 
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }
        public string DeleteEvent(int Eid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("delete from Event where Eid=" + Eid, sqlConnection);
            sqlConnection.Open();
            int result = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }
        public DataTable SelectEvent()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Event", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            sqlConnection.Close();
            return dataTable;
        }
        public DataTable SelectEventById(int Eid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Event where Eid=" + Eid, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            sqlConnection.Close();
            return dataTable;
        }
        public DataTable ShowCutomerDetails()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Customer", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public DataTable ShowBookedEvent()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from BookingData ", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            sqlConnection.Close();
            return dataTable;
        }
        public string AddApprovRejDetails()
        {
            Console.WriteLine("Enter the Event Id: ");
            int Eid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer  Id: ");
            int Cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Status: ");
            string Status = Console.ReadLine();

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into ApprovRejectDetails values(" + Eid + "," + Cid + ",'" + Status + "')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "values are Added";
        }

        public DataTable ShowApprovedAndRejectedStatus()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from ApprovRejectDetails", sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);

            sqlConnection.Close();
            return dataTable;
        }


    }
}
