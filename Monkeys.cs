using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Child class that inherit from parent class Animal.
    class Monkeys : Animal
    {
        // Properties specific for this class.
        public int _weight = 42;

        // Default values.
        public Monkeys()
        {
            _species = "Apa";
            _food = "Bananer";
            _name = "Santino";
            _age = 45;
            _weight = 50;
            _petOrWild = "Inlåst på zoo";
        }
        // Constructor that can change the values.
        public Monkeys(string name, int age, int weight, string petOrWild)
        {
            _species = "Apa";
            _food = "Bananer";
            _name = name;
            _age = age;
            _weight = weight;
            _petOrWild = petOrWild;
        }
        // Method inherited from parent class that shows how the animal sounds.
        public override void MakeSound()
        {
            Console.WriteLine("Apan låter: OO-OOO-OOOO-AA-AAA-AAA!");
        }
        // Method inherited from parent class that shows how the animal is sleeping.
        public override void Sleeping()
        {
            Console.WriteLine("Apan sover i trädet");
        }
        // Method inherited from parent class. With added info.
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Vikt: " + _weight + "kg");
        }
        // Method specific for this class.
        public void HangInTail()
        {
            Console.WriteLine("Apan hänger i svansen");
        }
    }
}
