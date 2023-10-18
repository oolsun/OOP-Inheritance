﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    class FinnishSpitz : Dogs
    {
        string _breed = "Finnspets";
        string _likesToDo = "Gräva gropar";
                
        public FinnishSpitz()
        {
            _species = "Hund";
            _food = "Hundmat (och allt som husse/matte tappar på golvet)";
            _name = "Haukkuja";
            _age = 7;
            _color = "Gul/orange";
            _petOrWild = "Husdjur";
        }
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

        public override void MakeSound()
        {
            Console.WriteLine("Hunden skäller: Woof Wooof!");
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Ras: " + _breed + "\nGillar att: " + _likesToDo);
        }
        public override void WaggingTail()
        {
            Console.WriteLine("*" + _name + " viftar på svansen*");
        }
        public void Hunting()
        {
            Console.WriteLine(_breed + "en skäller på en tjäder som sitter uppe i trädet");
        }
    }
}
