using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace LibraryManagement
{
    public class Libraraian
    {
        public void WriteFile()
        {
            FileStream fileStream = new FileStream(@"C:\TrainingRepo\CsharpHandson\LibraryManagement\LibraryManagement\Libraraian.txt", FileMode.Create, FileAccess.Write);
            StreamWriter streamwriter = new StreamWriter(fileStream);
            int Lid;
            string Lname;
            string Lpassword;
            Lid = Convert.ToInt32(Console.ReadLine());
            streamwriter.WriteLine("Lid: " + Lid);
            Lname = Console.ReadLine();
            streamwriter.WriteLine("Lname: " + Lname);
            Lpassword = Console.ReadLine();
            streamwriter.WriteLine("Lpassword: " + Lpassword);
            streamwriter.Close();
            fileStream.Close();
            //book class defining
        public class book
        {
            public int bookId;
            public string bookName;
            public int bookCount;
            public int x;

        }
        //borrow details class 
        class borrowDetails
        {
            public int userId;
            public string userName;
            public int borrowId;
            public DateTime borrowDate;
            public int borrowCount;
        }
        class bookList
        {
            static List<Book> booklist = new List<Book>();
            static List<borrowDetails> borrowlist = new List<borrowDetails>();
            static Book book = new Book();
            static borrowDetails Borrow = new borrowDetails();
        }
        public void PasswordVerification
        {
            Console.WriteLine("Enter the password: ");
            string Password = Console.ReadLine();
            if (Password == "123")
            {
                bool close = true;
                while (close)
                {
                    Console.WriteLine("\nMenu\n " + "1.Add book\n " +
                        "2.Delete book\n " + "3.Search book\n " + "4.Borrow book\n " + "5.Return book\n " + "6.Close\n ");
                    Console.WriteLine("chosse your option: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        Getbook();
                    }
                    else if (option == 2)
                    {
                        RemoveBook();
                    }
                    else if (option == 3)
                    {
                        SearchBook();
                    }
                    else if (option == 4)
                    {
                        BorrowBook();
                    }
                    else if (option == 5)
                    {
                        ReturnBook();
                    }
                    else if (option == 6)
                    {
                        Console.WriteLine("close");
                        close = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("invalid option..\n ");
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid password\nCheck your password ");
            }
            Console.ReadLine();
}

    public class Book
    {
    }
}
}
      
        //public class Book
        //{
        //    //defining book class
        //    int bookId;
        //    String bookName;
        //    string bookAuthor;
        //    int bookCount;
        //}
        ////defining borrow closs
        //public class BorrowDetails
        //{
        //    int UserId;
        //    string UserName;
        //    string UserAddress;
        //    int BorrowId;
        //    DateTime BarrowDate;
        //    int BorrowCount;
        //}
        //public class BookIssuing
        //{
        //    List<Book> bookList = new List<Book>();
        //    List<BorrowDetails> borrowDetails = new List<BorrowDetails>();
        //    Book book = new Book();
        //    BorrowDetails borrow = new BorrowDetails();

        //}
        //public void Login()
        //{
        //    string username = Console.ReadLine();
        //    Console.WriteLine("Enter the username " + username);
        //    string password = Console.ReadLine();
        //    Console.WriteLine("Enter the password " + password);
        //}
        //public void UserVerification()
        //{
        //    Console.WriteLine("Enter the password: ");
        //    string Password = Console.ReadLine();
        //    if (Password == "123")
        //    {
        //        bool close = true;
        //        while (close)
        //        {
        //            Console.WriteLine("\nMenu\n " + "1.Add book\n " +
        //                "2.Delete book\n " + "3.Search book\n " + "4.Borrow book\n " + "5.Return book\n " + "6.Close\n ");
        //            Console.WriteLine("chosse your option: ");
        //            int option = Convert.ToInt32(Console.ReadLine());
        //            if (option == 1)
        //            {
        //                Getbook();
        //            }
        //            else if (option == 2)
        //            {
        //                RemoveBook();
        //            }
        //            else if (option == 3)
        //            {
        //                SearchBook();
        //            }
        //            else if (option == 4)
        //            {
        //                BorrowBook();
        //            }
        //            else if (option == 5)
        //            {
        //                ReturnBook();
        //            }
        //            else if (option == 6)
        //            {
        //                Console.WriteLine("close");
        //                close = false;
        //                break;

        //            }
        //            else
        //            {
        //                Console.WriteLine("invalid option..\n ");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("invalid password\nCheck your password ");
        //    }
        //    Console.ReadLine();
        //}
        //public void Getbook()
        //{
           
        //    Console.WriteLine("Book id: {0}", bookId = bookList.Count);
        //}

            
     

    
    

