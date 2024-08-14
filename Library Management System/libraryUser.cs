using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class libraryUser : User
    {
        public libraryUser(string name)
        {
            Name = name;   
        }
        public libraryCard Card { get; set; }
        

        public void BorrowBooks(Book book, library library)
        {
            library.borrowbook(book);
        }



    }
}
