using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    //index, country, city, street, house, apartment.
    

    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartement;

        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public int House
        {
            get
            {
                return house;
            }

            set
            {
                house = value;
            }
        }

        public int Apartement
        {
            get
            {
                return apartement;
            }

            set
            {
                apartement = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Address a = new Address();
            Address b = a;
            
            a.Apartement = 1;

            ChangeAddress(a);
                   
            
            Console.WriteLine("{0} \n {1}", a.Apartement,b.Apartement);
            Console.ReadKey();

        }

        static void ChangeAddress( Address addr)
        {
            Address c = new Address();
            c = addr;
            c.Apartement = 22;
        }
    }
}
