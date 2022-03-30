using System;
using System.Collections;
using System.Collections.Generic;

namespace Concepts
{
    class Program
    {
        /*
            public class Person
            {

                public string Name { get; set; }
                public string LastName { get; set; }
                public byte Age { get; set; }

                public Person(string name, string lastname, byte age)
                {
                    this.Name = name;
                    this.LastName = lastname;
                    this.Age = age;
                }

            }
            */
        /*
       public class Drink
       {
            public string Name { get; set; }
            public float Cant { get; set; }
 
            public float Consumption(float consumed)
            {
                this.Cant -= consumed;
                return Cant;
            }
            public Drink(string Nombre, float Cant)
            {
                this.Name = Name;
                this.Cant = Cant;
            }

           public class Soda: Drink
            {
                public Soda():base("Coca-Cola", 100.50f)
                {

                }
               
           }
        */
        public abstract class Bird
        {
            public int _wings;
            public Bird(int wings) => _wings = wings;

        }
        public interface IRun
        {
            int Legs { get; set; }
            void Run();

        }
        public interface ISwin
        {
            void Swin()
            {
                Console.Write("I am Method");
            }
        }
        public interface IFly
        {
            void Fly();
        }
            public class Ostrich : Bird, IRun
            {
                private int legs;

                public int Legs { get => legs; set => legs = value; }
                public void Run()
                {
                    Console.WriteLine("Run run run!");
                }
                public Ostrich(int wing) : base(wing)
                {

                }


                static void Main(string[] args)
                {
                    /*
                    List<Person> ListPerson = new List<Person>();

                    ListPerson.Add(new Person("Dewry", "Peña", 24));
                    ListPerson.Add(new Person("Juan", "Díaz", 37));
                    ListPerson.Add(new Person("Fernanda", "Cerrano", 21));

                    byte count = 0;
                    foreach(var name in ListPerson)
                    {
                        count++;
                        Console.WriteLine($"Person No. {count}: Name: {name.Name} Lastname: {name.LastName} Age: {name.Age}");
                    }
                    */
                    /*
                    int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine($"Element {i}: {numbers[i]}");

                    }

                    List<int> NumbersPrimes = new List<int>() { 2, 3, 5, 7, 11, 13 };
                    NumbersPrimes.Add(17);
                    NumbersPrimes.Add(19);
                    NumbersPrimes.Add(23);
                    NumbersPrimes.Add(29);
                    NumbersPrimes.Add(31);
                    NumbersPrimes.Add(37);
                    NumbersPrimes.Add(41);
                    NumbersPrimes.Add(43);
                    NumbersPrimes.Add(53);

                    Console.WriteLine("****************************************");

                    for(int i = 0; i <NumbersPrimes.Count; i++)
                    {
                        Console.WriteLine($"No. {i+1}: {NumbersPrimes[i]}");
                    }
                    */
                    /*
                     * Builder, inheritance
                    Drink drink = new Drink("Soda ", 800.14f);
                    Console.WriteLine(drink.Name+" "+drink.Consumption(600.15f));
                    Soda cocaCola = new Soda();
                    Console.WriteLine(cocaCola.Name+" "+ " "+cocaCola.Consumption(10f));
                    */


                    /*
                     * Type of data

                    byte numberByte = 255; //one Byte
                    sbyte numberSbyte = -128; //byte negative
                    short numberShort = -510; // 2 bytes
                    ushort numberUshort = 510; // 4 bytes
                    int numberInt = -240000000; // 8 bytes
                    uint numberuInt = 240000000; // int only positive
                    long numberLong = -70000000000000; // 16 bytes
                    ulong numberuLong = 70000000000000; // long only positive
                    float numberFloat = -10.1f; // 4 byte
                    double numberDouble = -15.4d; // 8 byte
                    decimal numberDecimal = -4653135351351553.454445m; //16 byte
                    var name = "Dewry Peña";
                    var data = new { name = "Dewry Peña", age = 24 };

                    */




                    Console.ReadKey(true);



                }
            }

        }
    }




        
   
