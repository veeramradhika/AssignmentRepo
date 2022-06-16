using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace EventManagementAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperAdmin superAdmin = new SuperAdmin();
            Admin admin= new Admin();
            Customer customer= new Customer();

            
            Console.WriteLine("**************** Welcome to Event Management Portal ************** ");
            Console.WriteLine("Choose the roll:");
            Console.WriteLine("1. Super Admin");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Customer");
            int option=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter the password:");
            string password = Console.ReadLine();

            switch (option)
            {
                

                case 1:
                Label1:
                    Console.WriteLine("Welcome to Super Admin portal:");
                    Console.WriteLine("Menu\n 1. Add admin\n 2. Update admin\n " +
                   "3. Delete admin\n 4. Select admin\n 5. Select admin by Aid\n 6.logout");
                    int option1=Convert.ToInt32(Console.ReadLine());
                    switch (option1)
                    {
                        case 1:
                            string insert = superAdmin.insertAdmin();
                            Console.WriteLine(insert);
                            goto Label1;

                        case 2:
                            string update = superAdmin.UpdateAdmin();
                            Console.WriteLine(update);
                            goto Label1;

                        case 3:
                            Console.WriteLine("Enter the Admin Id to Delete the Admin: ");
                            int Aid=Convert.ToInt32(Console.ReadLine());
                            string Delete = superAdmin.DeleteAdmin(Aid);
                            Console.WriteLine(Delete);
                            goto Label1;

                        case 4:
                            DataTable dt = superAdmin.SelectAdmin(); 
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++) 
                            {
                                for (int j = 0; j < dt.Columns.Count; j++) 
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label1;

                        case 5:
                            Console.WriteLine("Enter the Admin id to Select Admin: "); 
                            int AId = Convert.ToInt32(Console.ReadLine());
                            DataTable dt1 = superAdmin.SelectAdminById(AId);
                            if (dt1.Rows.Equals(AId))
                            {
                                Console.WriteLine( "details found..");
                            }
                            for (int i = 0; i < dt1.Rows.Count; i++) 
                            {
                                for (int j = 0; j < dt1.Columns.Count; j++) 
                                {
                                    Console.Write(dt1.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label1;
                        case 6:
                            Console.WriteLine("log out completed.."); break;
                        default:
                            Console.WriteLine("enter a valid option");
                            break;
                    }
                    break;
                    
                   
                    
                case 2:
                     Label2:
                           Console.WriteLine("***************** Welcome to Admin Portal *****************");
                           Console.WriteLine("Menu\n 1. Add Event\n 2. Update Event\n " +
                           "3. Delete Event\n 4. Select Event\n 5. Select Event by Eid\n 6. Select customer Details\n " +
                           "7. Booked Event Details\n 8. Add Booked Event Status\n 9. Booked Event Status Details\n 10. LogOut");
                    int option2 = Convert.ToInt32(Console.ReadLine());
                    switch (option2)
                    {
                        case 1:
                            string insert = admin.insertEvent();
                            Console.WriteLine(insert);
                            goto Label2;

                        case 2:
                            string update = admin.UpdateEvent();
                            Console.WriteLine(update);
                            goto Label2; 

                        case 3:
                            Console.WriteLine("Enter the Event ID to Delete the Event:");
                            int Eid = Convert.ToInt32(Console.ReadLine());
                            string Delete = admin.DeleteEvent(Eid);
                            Console.WriteLine(Delete);
                            goto Label2;

                        case 4:
                            DataTable dt = admin.SelectEvent();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label2;

                        case 5:

                            Console.WriteLine("Enter the Event id to Select Event: ");
                            int EId = Convert.ToInt32(Console.ReadLine());
                            DataTable dt1 = admin.SelectEventById(EId);
                            if (dt1.Rows.Equals(EId))
                            {
                                Console.WriteLine("details found..");
                            }
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt1.Columns.Count; j++)
                                {
                                    Console.Write(dt1.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label2;
                        
                        case 6:
                            DataTable dt2 = admin.ShowCutomerDetails();
                            if (dt2.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt2.Columns.Count; j++)
                                {
                                    Console.Write(dt2.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label2;

                        case 7:
                            DataTable dt3 = admin.ShowBookedEvent();
                            if (dt3.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt3.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt3.Columns.Count; j++)
                                {
                                    Console.Write(dt3.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label2;

                        case 8:
                            string add = admin.AddApprovRejDetails();
                            Console.WriteLine(add);
                            goto Label2;

                        case 9:
                            DataTable dt4 = admin.ShowApprovedAndRejectedStatus();
                            if (dt4.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt4.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt4.Columns.Count; j++)
                                {
                                    Console.Write(dt4.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label2;
                        case 10:
                            Console.WriteLine("log out completed.."); break;
                        default:
                            Console.WriteLine("enter a valid option");
                            break;


                    }
                    break;

                case 3:
                     Label3:
                    Console.WriteLine("***************** Welcome to User Portal *****************");
                    Console.WriteLine("Menu\n 1. Add details\n 2. Update Details\n  3. Show Event\n " +
                        "4. Book Event\n 5. Booked Event Details\n 6. Cancel Event\n 7. Booked Event Status\n 8. LogOut");
                    int option3 = Convert.ToInt32(Console.ReadLine());
                    switch (option3)
                    {
                        case 1:
                            
                            string Added = customer.AddCustomerDetails();
                            Console.WriteLine(Added);
                            goto Label3;

                        case 2:
                          
                            string updated = customer.UpdateCustomerDetails();
                            Console.WriteLine(updated);
                            goto Label3;

                        case 3:
                            DataTable dt = customer.ShowEvent();
                            if (dt.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    Console.Write(dt.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label3;

                        case 4:
                            Console.WriteLine("");
                            string Booked = customer.BookEvent();
                            Console.WriteLine(Booked);
                            goto Label3;


                        case 5:
                            Console.WriteLine("Enter the customer Id to get the booked event: ");
                            int Cid=Convert.ToInt32(Console.ReadLine());
                            DataTable dt1 = customer.ShowBookedEvent(Cid);
                            if (dt1.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt1.Columns.Count; j++)
                                {
                                    Console.Write(dt1.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label3;


                        case 6:
                            Console.WriteLine("Enter the Customer id to Cancel the BookedEvent: ");
                            int CId = Convert.ToInt32(Console.ReadLine());
                            string Cancel = customer.CancelEvent(CId);
                            Console.WriteLine(Cancel);
                            goto Label3;

                        case 7:
                            Console.WriteLine("Enter the Customer id to Get Status of the BookedEvent: ");
                            int CId1 = Convert.ToInt32(Console.ReadLine());
                            DataTable dt2 = customer.BookedEventStatus(CId1);
                            if (dt2.Rows.Count == 0)
                            {
                                Console.WriteLine("Table is empty");
                            }
                            for (int i = 0; i < dt2.Rows.Count; i++)
                            {
                                for (int j = 0; j < dt2.Columns.Count; j++)
                                {
                                    Console.Write(dt2.Rows[i][j] + "\t\t");
                                }
                                Console.WriteLine();
                            }
                            goto Label3;

                        case 8:
                            Console.WriteLine("log out completed.."); break;
                        default:
                            Console.WriteLine("enter a valid option");
                            break;

                    }
                    break;

            }

            Console.ReadLine();
        }
    }
}
