using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Child class that inherit from class Dogs, which inherit from Animal.
    class SheepDog : Dogs
    {
        // Properties specific for this class.
        string _breed = "Vallhund";
        int _sheeps = 100;

        // Default values.
        public SheepDog()
        {
            _species = "Hund";
            _food = "Hundmat (och fåren som inte gör som den säger)";
            _name = "Lassie";
            _age = 85;
            _color = "Brun/Vit";
            _petOrWild = "Husdjur";
        }
        // Constructor that can change the values.
        public SheepDog(string name, int age, string color, int sheeps)
        {
            _species = "Hund";
            _food = "Hundmat (och allt som husse/matte tappar på golvet)";
            _name = name;
            _age = age;
            _petOrWild = "Husdjur";
            _color = color;
            _sheeps = sheeps;
        }
        // Method inherited from parent class. Show how the dog sounds.
        public override void MakeSound()
        {
            base.MakeSound();
        }
        // Method inherited from parent class Dogs and Animal. Same output as Dogs.
        public override void Sleeping()
        {
            base.Sleeping();
        }
        // Method inherited from parent class Dogs and Animal, with added info.
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Ras: " + _breed + "\nAntal får " + _name + " vallar: " + _sheeps);
        }
        // Method inherited from parent class Dogs.
        public override void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
        // Method specific for this class.
        public void Herding()
        {
            Console.WriteLine(_breed + "en vallar får");
        }
    }
}
