using Library_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_system
{
    public class LibraryContext
    {
        public List<Admin> admins {  get; set; }

        public List<Author> authors { get; set; }

        public List<Books> books { get; set; }

        public List<Employee > employees { get; set; }

        public List<Library> libraries { get; set; }

        public List<Member> members { get; set; }

        public List<Publisher> publisher { get; set; }

        public List<Vendor> vendor { get; set; }
    }
}
