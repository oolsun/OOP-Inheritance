using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class Bears : Animal
    {
        public string _TBD;
        public Bears()
        {
            _species = "Björn";
            _food = "Myror, växter och bär";
            _name = "Baloo";
            _age = 129;
            _petOrWild = "Vilddjur";
        }
        public Bears(string name, int age, string food, string petOrWild)
        {
            _species = "Björn";
            _food = food;
            _name = name;
            _age = age;
            _petOrWild = petOrWild;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Björnen låter: GRRRR!");
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }
        public void Hibernate()
        {
            Console.WriteLine("Björnen går i ide inför vintern");
        }
    }
}
