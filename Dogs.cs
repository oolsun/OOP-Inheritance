using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Child class that inherit from parent class Animal.
    class Dogs : Animal
    {
        // Properties specific for this class.
        public string _color = "Gul/orange";

        // Default values.
        public Dogs()
        {
            _species = "Hund";
            _food = "Korv och hundben";
            _name = "Pluto";
            _age = 93;
            _petOrWild = "Husdjur";
        }
        // Constructor that can change the values.
        public Dogs(string name, int age, string food, string color)
        {
            _species = "Hund";
            _food = food;
            _name = name;
            _age = age;
            _color = color;
            _petOrWild = "Husdjur";
        }
        // Method inherited from parent class that shows how the animal sounds.
        public override void MakeSound()
        {
            Console.WriteLine("Hunden skäller: Woof Wooof!");
        }
        // Method inherited from parent class that shows how the dogs are sleeping.
        public override void Sleeping()
        {
            Console.WriteLine("Hunden sover i hundbädden");
        }
        // Method inherited from parent class. With added info.
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Färg: " + _color);
        }
        // Method specific for this class and child classes to this.
        public virtual void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
    }
}
