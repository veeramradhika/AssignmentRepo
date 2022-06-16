using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace EventManagementAssignment
{
    public class Customer
    {
        public static string sqlConnectionStr = "Data Source=RADHIKA;Initial Catalog=EventDb;Integrated Security=True";
       public string AddCustomerDetails()
        {
            Console.WriteLine("Enter the Customer Id: ");
            int Cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name: ");
            string Cname = Console.ReadLine();

            Console.WriteLine("Enter the  address: ");
            string Caddress = Console.ReadLine();

            Console.WriteLine("Enter the Mobile Number: ");
            double CMobile = Convert.ToDouble(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into Customer values(" + Cid + ",'" + Cname + "', " +
            "'" + Caddress + "'," + CMobile + ")", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Details Added...";
        }
        public string UpdateCustomerDetails()
        {
            Console.WriteLine("Enter the Customer Id to update: ");
            int Cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Name to update: ");
            string Cname = Console.ReadLine();

            Console.WriteLine("Enter the  address to update: ");
            string Caddress = Console.ReadLine();

            Console.WriteLine("Enter the Mobile Number to update: ");
            double CMobile = Convert.ToDouble(Console.ReadLine());

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("update Customer set Cname='" + Cname + "' , Caddress='" + Caddress + "'" +
                ",CMobile=" + CMobile + "  where Cid=" + Cid + "", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Details Updated...";
        }

        public DataTable ShowEvent()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Event", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public string BookEvent()
        {
            Console.WriteLine("Enter the Booking Id: ");
            int Bid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Event Id: ");
            int Eid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer Id: ");
            int Cid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Booking Name: ");
            string Bname = Console.ReadLine();

            Console.WriteLine("Enter the Booking address: ");
            string Badd = Console.ReadLine();

            Console.WriteLine("Enter the Venue: ");
            string BVenue = Console.ReadLine();

            Console.WriteLine("Enter the Equipment: ");
            string BFood = Console.ReadLine();

            Console.WriteLine("Enter the Food: ");
            string BEquipment = Console.ReadLine();

            Console.WriteLine("Enter the Light: ");
            string BLight = Console.ReadLine();

            Console.WriteLine("Enter the Flower: ");
            string BFlower = Console.ReadLine();

            Console.WriteLine("Enter the Cost: ");
            Double Cost = Convert.ToDouble(Console.ReadLine());

            //inserting the Event values into the sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("insert into BookingData values(" + Bid + "," + Eid + "," + Cid + ",'" + Bname + "','" + Badd + "', " +
            "'" + BVenue + "','" + BFood + "','" + BEquipment + "','" + BLight + "','" + BFlower + "'," + Cost + ")", sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Booking is completed..";
        }
        public DataTable ShowBookedEvent(int Cid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from BookingData where Cid=" + Cid, sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }
        public string CancelEvent(int Cid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlDataAdapter adp = new SqlDataAdapter("delete from BookingData where Cid=" + Cid, sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return "Cancelled Event...";
        }
        public DataTable BookedEventStatus(int Cid)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlDataAdapter adp = new SqlDataAdapter("select * from ApprovRejectDetails where Cid=" + Cid, sqlConnection);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            return dataTable;
        }

    }
}
