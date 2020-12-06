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
            if (mileage < 5 || mileage > 30)
            {
                Console.WriteLine("Invalid Mileage: " + mileage);
                Console.ReadKey();
            }
            else
            {
                Car obj;
                switch (option)
                {
                    case 0:
                        Console.Write("A WagonR");
                        obj = new WagonR(false, "4", mileage);
                        Console.Write(obj.getMileage());
                        break;
                    case 1:
                        Console.Write("A Honda City");
                        obj = new HondaCity(true, "4", mileage);
                        Console.Write(obj.getMileage());
                        break;
                    case 2:
                        Console.Write("A Innova Crysta");
                        obj = new InnovaCrysta(false, "6", mileage);
                        Console.Write(obj.getMileage());
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
}
