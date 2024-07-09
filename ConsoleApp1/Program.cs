using System;
using System.ComponentModel.DataAnnotations;

namespace MyApplication
{
    /*{
        class Car
        {
            string color = "red";
            static void Main(string[] args)
            {
                Car car = new Car();
                car.color = "red";
                Console.WriteLine(car.color);
            }
        }
    }
    */
    //Two Objects
    /*{
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
    /*namespace MyApplication
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
    */

    //C# Methods
    /*namespace MyApplication
    {
        class Car
        {
            string color = "red";
            string maxSpeed = "100";

            public void fullThrottle()
            {
                Console.WriteLine("The car is going very fast with a speed of");

            }
            static void Main(string[] args)
            {
                Car car = new Car();
                car.fullThrottle();
            }
        }
    }*/

    //Constructors
    /*namespace MyApplication
    {
        class Car
        {
            public string model;
            public string name;

            public Car()
            {
                model = "Mustang";
                name = "Racing Car";
            }

            static void Main(string[] args)
            {
                Car car = new Car();
                Console.WriteLine(car.model);
            }
        }
    }*/

    //Constructor Parameters
    /*class Car
    {
        public string model;

        public Car(string modelName)
        {
            model = modelName;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang");
            Console.Write(Ford.model);
        }
    }*/

    /*  class Car
      {
          public string model;
          public string color;
          public int year;

          public Car(string modelName, string modelColor, int modelYear)
          {
              model = modelName;
              color = modelColor;
              year = modelYear;
          }

          static void Main(string[] args)
          {
              Car Ford = new Car("Mustang","Red",2022);
              Console.WriteLine(Ford.model+ " AND "+ Ford.color);
          }
      }*/

    //Using Constructor in Two Files prog2.cs

   /* class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }*/





}