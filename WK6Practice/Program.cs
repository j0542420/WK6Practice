using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WK6Practice
{
    class Animal
    {
        //properties //Attributes //fields
        string name;
        string skinColor;
        int numberOfLegs;
        int age;
        string sound;

        //default constructor: is a method has the same name of the class to build/inmitate the object // worker to build the object
        //assign default
        public Animal()
        {
            name = "Fluffy";
            skinColor = "black";
            numberOfLegs = 4;
            age = 1;
            sound = "meouw";
        }

        //custome constructor
        public Animal(string Aname, string AskinColor, int AnumberOfLegs, int Aage, string Asound)
        { 
            name= Aname;
            skinColor = AskinColor;
            numberOfLegs = AnumberOfLegs;
            age = Aage;
            sound = Asound;
        }

        //behavior/ action/ methods
        public void MakeSound()
        {
            Console.WriteLine(name + "sounds " + sound);
        }
        public void Introduce()
        { 
            Console.WriteLine($"I am {name}, I have {numberOfLegs} legs my skin color is {skinColor}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("this is default");
            animal1.MakeSound();
            animal1.Introduce();

            Animal animal2 = new Animal("Bergie",4,1,"bark sound");
            Console.WriteLine("this is a dog");
            animal2.MakeSound();
            animal2.Introduce();

            Animal ani;
            List<Animal> animals = new List<Animal>();
            for (int i = 0; i < 10; i++)
            {
                ani = new Animal("name" + i, "Color" + i, 4, 2, "sound" + 1);//initiate object
                animals.Add(ani);
            }

            foreach (Animal a in animals)
            {
                a.Introduce();

            }
        }
    }
}
