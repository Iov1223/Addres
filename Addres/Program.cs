using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addres
{
    class Address
    {
        public string Street, Number;
        public Address()
        {
            Street = "Lenina";
            Number = "1a";
        }

    }
    class House
    {
        public Address myAddress = new Address();
        public int FloorCount = 0,
            Floor = 0, 
            FlatCount = 0, 
            Flat = 0; 
        public void Build()
        {
            Console.WriteLine("Дом построен");
        }
        public void Destroy()
        {
            Console.WriteLine("Дом снесён");
        }
    }
    class Flat
    {
        public int Floor = 0,
            NimberInHouse = 0,
            NumberOfRooms = 0;
        public decimal Square = 0;
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
