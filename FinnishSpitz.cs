using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class FinnishSpitz : Dogs
    {
        string _breed = "Finsk spets";
                
        public FinnishSpitz()
        {
            _species = "Hund";
            _food = "Hundmat (och allt som husse/matte tappar på golvet)";
            _name = "";
            _age = 4;
            _color = "Gul/orange";
            _petOrWild = "Husdjur";
        }
        public FinnishSpitz(string name, int age, string color)
        {
            _species = "Hund";
            _food = "Hundmat (och allt som husse/matte tappar på golvet)";
            _name = name;
            _age = age;
            _petOrWild = "Husdjur";
            _color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hunden skäller: Woof Wooof!");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Ras: " + _breed + "\nFärg: " + _color);
        }
        public override void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
        public void UsedFor()
        {
            Console.WriteLine(_breed + " används främst till fågeljakt");
        }
    }
}
