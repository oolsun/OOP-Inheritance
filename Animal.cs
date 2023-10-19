using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    // Parent class
    public class Animal
    {
        // Five properties with defaults.
        public string _species = "Typ av djur";
        public string _food = "Typ av föda";
        public string _name = "Namn på djuret";
        public int _age = 0;
        public string _petOrWild = "Vilddjur eller husdjur";
    
        // Method that makes animal sound.
        public virtual void MakeSound()
        {
            Console.WriteLine("Djuren gör ett ljud");
        }
        // Method 
        public virtual void Sleeping()
        {
            Console.WriteLine("Djuren sover");
        }
        // Method that writes out information about animals.
        public virtual void GetInfo()
        {
            Console.WriteLine("Namn: " + _name + "\nArt: " + _species + "\nFöda: " + _food + "\nÅlder: " + _age + "\nHusdjur/vilddjur: " + _petOrWild);
        }
    }
}
