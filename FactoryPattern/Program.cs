using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class CarAssembler
    {
        static void Main(string[] args)
        {
            CarFactory factory = null;
            Console.WriteLine("Enter a car: ");
            string car = Console.ReadLine();

        }
    }

    abstract class CarFactory
    {
        abstract public Car GetCar();
    }

    class SuzukiFactory : CarFactory
    {
        private string model;
        private int speed;

        public SuzukiFactory(string model, int speed);

        protected SuzukiFactory()
        {
        }

        override Car GetCar()
        {
            Car c;
        }
    }


    abstract class Car
    {
        public string GetCompany()
        {
            return company;
        }
        public string GetModel()
        {
            return model;
        }
        public int GetSpeed()
        {
            return speed;
        }

        protected void SetCompany(string c)
        {
            company = c;
        }
        public void SetModel(string m)
        {
            model = m;
        }
        public void SetSpeed(int s)
        {
            speed = s;
        }

        private string company;
        private string model;
        private int speed;
    }

    class Suzuki : Car
    {
        public Suzuki()
        {
            SetModel("model");
            SetCompany("Suzuki");
            SetSpeed(0);
        }
    }
}
