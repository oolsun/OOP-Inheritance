using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class SheepDog : Dogs
    {
        string _breed = "Vallhund";
        int _sheeps = 100;

        public SheepDog()
        {
            _species = "Hund";
            _food = "Hundmat (och fåren som inte gör som den säger)";
            _name = "Lassie";
            _age = 85;
            _color = "Brun/Vit";
            _petOrWild = "Husdjur";
        }
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

        public override void MakeSound()
        {
            Console.WriteLine("Hunden skäller: Woof Wooof!");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Ras: " + _breed + "\nAntal får " + _name + " vallar: " + _sheeps);
        }
        public override void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
        public void Herding()
        {
            Console.WriteLine(_breed + "en vallar får");
        }
    }
}
