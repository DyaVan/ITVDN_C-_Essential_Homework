using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Taras Shevhenko", "KOBZAR", "Virshi velikogo poeta");
            b1.Show();
            Console.ReadKey();
        }
    }
}
