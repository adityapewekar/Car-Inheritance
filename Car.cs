using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInheritance
{
    public abstract class Car
    {
        public bool isSedan;
        public string seats;
        public string carName;

        public Car(bool isSedan,string seats)
        {
            Console.Write(" is "+(isSedan?"":"not")+" Sedan, is " + seats + " - seater,");
        }

        public bool getIsSedan() {
            return isSedan;
        }

        public string getSeats()
        {
            return seats;
        }

        public abstract string getMileage(int mileage);
    }

    public class WagonR : Car
    {
        public WagonR(bool isSedan,string seats):base(isSedan,seats)
        {
            base.carName = "WagonR";
            //Console.WriteLine("A WagonR is not Sedan, is" + seats + "-seater, and has a mileage of around 22 kmpl");
        }

        public override string getMileage(int mileage)
        {
            return "and has a mileage of around " + mileage.ToString() + " kmpl";
        }
    }

    public class HondaCity : Car
    {
        public HondaCity(bool isSedan, string seats) : base(isSedan, seats)
        {
            base.carName = "Honda City";
            //Console.WriteLine("A Honda City is a Sedan, is" + seats + "-seater, and has a mileage of around 22 kmpl");
        }

        public override string getMileage(int mileage)
        {
            return "and has a mileage of around " + mileage.ToString() + " kmpl";
        }
    }

    public class InnovaCrysta : Car
    {
        public InnovaCrysta(bool isSedan, string seats) : base(isSedan, seats)
        {
            base.carName = "Innova Crysta";
            //Console.WriteLine("A Innova Crysta is not Sedan, is" + seats + "-seater, and has a mileage of around 22 kmpl");
        }

        public override string getMileage(int mileage)
        {
            return "and has a mileage of around "+mileage.ToString()+" kmpl";
        }
    }
}
