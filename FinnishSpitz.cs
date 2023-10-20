using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Child class that inherit from class Dogs, which inherit from Animal..
    class FinnishSpitz : Dogs
    {
        // Properties specific for this class.
        string _breed = "Finnspets";
        string _likesToDo = "Gräva gropar";

        // Default values.
        public FinnishSpitz()
        {
            _species = "Hund";
            _food = "Hundmat (och allt som husse/matte tappar på golvet)";
            _name = "Haukkuja";
            _age = 7;
            _color = "Gul/orange";
            _petOrWild = "Husdjur";
        }
        // Constructor that can change the values.
        public FinnishSpitz(string name, int age, string color, string likesToDo)
        {
            _species = "Hund";
            _food = "Hundmat (och allt som husse/matte tappar på golvet)";
            _name = name;
            _age = age;
            _petOrWild = "Husdjur";
            _color = color;
            _likesToDo = likesToDo;
        }
        // Method inherited from parent class Dogs and Animal. Show how the dog sounds.
        public override void MakeSound()
        {
            base.MakeSound();
        }
        // Method inherited from parent class Dogs and Animal.
        public override void Sleeping()
        {
            Console.WriteLine("Vallhunden sover i hagen med fåren");
        }
        // Method inherited from parent class Dogs and Animal, with added info.
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Ras: " + _breed + "\nGillar att: " + _likesToDo);
        }
        // Method inherited from parent class Dogs.
        public override void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
        // Method specific for this class.
        public void Hunting()
        {
            Console.WriteLine(_breed + "en skäller på en tjäder som sitter uppe i trädet");
        }
    }
}
