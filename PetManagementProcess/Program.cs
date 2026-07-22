using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetManagementProcess
{ //Class
    class Pet
    {
        //Attributes
        public string name;
        public string breed;
        public int age;

        //Method
        public void Eat()
        {
            Console.WriteLine("The dog is eating its food.");
        }
        public void Sleep()
        {
            Console.WriteLine("The dog is sleeping.");
        }
        public void Play()
        {
            Console.WriteLine("The dog like to play catch.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        { //Object
            Pet mypet = new Pet();
            mypet.name = "Rex";
            mypet.breed = "Jack Russell Terrier";
            mypet.age = 10;
            Console.WriteLine("Name: " + mypet.name);
            Console.WriteLine("Breed: " + mypet.breed);
            Console.WriteLine("Age: " + mypet.age);

            mypet.Eat();
            mypet.Sleep();
            mypet.Play();

        }
    }
}
