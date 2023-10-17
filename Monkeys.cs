using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Monkeys : Animal
    {
        public int _weight;
        public Monkeys()
        {
            _species = "Apa";
            _food = "Bananer";
            _name = "Santino";
            _age = 45;
            _weight = 50;
            _petOrWild = "Vilddjur";
        }
        public Monkeys(string name, int age, int weight)
        {
            _species = "Apa";
            _food = "Bananer";
            _name = name;
            _age = age;
            _weight = weight;
            _petOrWild = "Vilddjur";
        }
        public override void MakeSound()
        {
            Console.WriteLine("Apan låter: OO-OOO-OOOO-AA-AAA-AAA!");
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Vikt: " + _weight + "kg");
        }
        public void HangInTail()
        {
            Console.WriteLine("Apan hänger i svansen");
        }
    }
}
