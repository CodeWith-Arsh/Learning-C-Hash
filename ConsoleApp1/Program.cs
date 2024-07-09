using System;
using System.ComponentModel.DataAnnotations;

/*namespace MyApplication
{
    class Car
    {
        string color = "red";
        static void Main (string[] args)
        {
            Car car = new Car();
            car.color = "red";
            Console.WriteLine(car.color);
        }
    }
}*/

//Two Objects
/*namespace MyApplication
{
    class Car
    {
        string color = "red";
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();
            car.color = "red";
            car2.color = "green";
            Console.WriteLine(car.color);
            Console.WriteLine(car2.color);
        }
    }
}*/

//Using Multiple Classes
/*namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyObj = new Car();
            Console.WriteLine(MyObj.color);
        }
    }
}*/

//Class Members
/*namespace MyApplication
{
    class Car
    {
        string color = "red";
        int maxSpeed = 5;

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 5;
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
        }
    }
}*/

//Multiple Objects of One Class
namespace MyApplication
{
    class Car
    {
        string model;
        string color;
        int year;

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 2004;

            Car Maruti = new Car();
            Maruti.model = "Maruti 800";
            Maruti.color = "Blue";
            Maruti.year = 2001;

            Console.WriteLine(Maruti.model);
            Console.WriteLine(Ford.color);
        }
    }
}

