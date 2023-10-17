using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    public class Animal
    {
        public string _species;
        public string _food;
        public string _name;
        public int _age;
        public string _petOrWild;
    

        public virtual void MakeSound()
        {
            Console.WriteLine("Djuren gör ett ljud");
        }
        public virtual void TBA()
        {
            Console.WriteLine();
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("Namn: " + _name + "\nArt: " + _species + "\nFöda: " + _food + "\nÅlder: " + _age + "\nHusdjur/vilddjur: " + _petOrWild);
        }
    }
}
