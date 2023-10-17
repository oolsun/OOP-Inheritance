using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Dogs : Animal
    {
        public string _color = "Gul/orange";
 
        public Dogs()
        {
            _species = "Hund";
            _food = "Korv och hundben";
            _name = "Pluto";
            _age = 93;
            _petOrWild = "Husdjur";
        }
        public Dogs(string name, int age, string food, string color)
        {
            _species = "Hund";
            _food = food;
            _name = name;
            _age = age;
            _color = color;
            _petOrWild = "Husdjur";
        }
        public override void MakeSound()
        {
            Console.WriteLine("Hunden skäller: Woof Wooof!");
        }
        public override void TBA()
        {
            Console.WriteLine();
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Färg: " + _color);
        }
        public virtual void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
    }
}
