using System.Threading.Channels;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Library System");
            Console.WriteLine("---------------------------------------");
            library library = new library();
            Console.WriteLine("Are You Librarian (L) Or Regular User (R)");
            var usertype = Console.ReadLine().ToUpper()[0];

            if (usertype == 'L')
            {
                Console.WriteLine("Welcome librarian, Enter Your Name");
                string librarianname = Console.ReadLine();
                librarian l1 = new librarian(librarianname);
                Console.WriteLine($"Welcome {l1.Name}");

                while (true)
                {
                    Console.WriteLine("Please choose to add book (A) / Remove book (R) / Display ALl books(D)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("enter book details");
                            string bookname = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookname,
                                Author = bookAuthor,
                                Years = bookYear
                            };
                            l1.Addbook(book, library);

                            break;

                        case 'R':
                            Console.WriteLine("enter book details to remove");
                            bookname = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookname,
                                Author = bookAuthor,
                                Years = bookYear
                            };
                            l1.Removebook(book, library);

                            break;

                        case 'D':
                            Console.WriteLine("The Bool List:");
                            l1.DisplayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;
                    }

                }
            }
            else if (usertype == 'R')
            {

                Console.WriteLine("Welcome User, Enter Your Name");
                string usernname = Console.ReadLine();
                libraryUser U1 = new libraryUser(usernname);
                Console.WriteLine($"Welcome {U1.Name}");

                while (true)
                {
                    Console.WriteLine("Please choose to Display ALl books(D) / Borrowbook (B)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("The Bool List:");
                            U1.DisplayBooks(library);
                            break;

                          
                        case 'B':
                            Console.WriteLine("enter book details to Borrow");
                          string  bookname = Console.ReadLine();
                           string bookAuthor = Console.ReadLine();
                           int bookYear = Convert.ToInt32(Console.ReadLine());
                           Book book = new Book()
                            {
                                Title = bookname,
                                Author = bookAuthor,
                                Years = bookYear
                            };
                            U1.BorrowBooks(book, library);

                            break;

                       
                        default:
                            Environment.Exit(0);
                            break;
                    }

                }

            }
            else { Console.WriteLine("Please Enter Correct Value"); }

            }
      

        }
    }

