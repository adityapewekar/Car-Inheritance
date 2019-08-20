using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int mileage;

            option = Convert.ToInt32(Console.ReadLine());
            mileage = Convert.ToInt32(Console.ReadLine());

            Car obj;
            
            switch (option)
            {
                case 0:
                    Console.Write("A WagonR");
                    obj = new WagonR(false,"4");
                    Console.Write(obj.getMileage(mileage));
                    break;
                case 1:
                    Console.Write("A Honda City");
                    obj = new HondaCity(true,"4");
                    break;
                case 2:
                    Console.Write("A Innova Crysta");
                    obj = new InnovaCrysta(false,"6");
                    Console.Write(obj.getMileage(mileage));
                    break;
                default:
                    Console.WriteLine("Wrong Option");
                    break;
            }
            //Console.Write(" and has a mileage of around "+mileage+" kmpl");
            Console.ReadLine();
        }
    }
}
