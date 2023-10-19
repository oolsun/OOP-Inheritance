using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Child class that inherit from parent class Animal.
    class Bears : Animal
    {
        // Properties specific for this class.
        string _gender = "Hane";

        // Default values.
        public Bears()
        {
            _species = "Björn";
            _food = "Myror, växter och bär";
            _name = "Baloo";
            _age = 129;
            _petOrWild = "Vilddjur";
        }
        // Constructor that can change the values.
        public Bears(string name, int age, string food, string petOrWild, string gender)
        {
            _species = "Björn";
            _food = food;
            _name = name;
            _age = age;
            _petOrWild = petOrWild;
            _gender = gender;
        }
        // Method inherited from parent class that shows how the animal sounds.
        public override void MakeSound()
        {
            Console.WriteLine("Björnen låter: GRRRROOWL!");
        }
        // Method inherited from parent class that shows how the animal is sleeping.
        public override void Sleeping()
        {
            Console.WriteLine("Björnen sover i sitt bo");
        }
        // Method inherited from parent class. With added info.
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Hona/hane: " + _gender);
        }
        // Method specific for this class.
        public void Hibernate()
        {
            Console.WriteLine("Björnen går i ide inför vintern");
        }
    }
}
