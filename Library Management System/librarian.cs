using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class librarian : User
    {
        public int EmployeeNumber { get; set; }

        public librarian(string name)
        {
            Name = name;
        }

        public void Addbook(Book newbook , library library)
        {
            library.Add(newbook);
        }

        public void Removebook(Book newbook, library library)
        {
            library.Remove(newbook);
        }
    }
}
