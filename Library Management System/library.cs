using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class library
    {
        private Book[] books = new Book[100]; //Max Capacity
        private int currentbookcount =0;
        private Book[] borrowedbooks = new Book[50];
        private int currentborrowedbooks = 0;


        public void Add(Book book)
        {
            if(currentbookcount< books.Length)
            {
                books[currentbookcount] = book;
                currentbookcount++;
                Console.WriteLine("Book Added Sucessfuly");
            }
            else
            {
                Console.WriteLine("Library Is Full");
            }
        }

        public void Remove(Book book)
        {
           int index=  Array.IndexOf(books, book);
            books[index] = null;
            currentbookcount--;
            Console.WriteLine("Book Removed");
        }

        public void display()
        {
            for(int i=0; i<currentbookcount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }

        public void borrowbook(Book book)
        {

            if (currentborrowedbooks < borrowedbooks.Length)
            {
                borrowedbooks[currentborrowedbooks] = book;
                currentborrowedbooks++;
                Console.WriteLine("Book borrowed Sucessfuly");
            }
            else
            {
                Console.WriteLine("Sorry can't borrow more books");
            }
        }
    }
}
