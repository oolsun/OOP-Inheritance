namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dogs1 = new Dogs();
            Dogs dogs2 = new Dogs("Båtsman", 70, "Det Tjorven och Skrållan bjuder på", "Vit/brun");
            Monkeys monkeys1 = new Monkeys();
            Monkeys monkeys2 = new Monkeys("Herr Nilsson", 8, 7, "Husdjur");
            Bears bears1 = new Bears();
            Bears bears2 = new Bears("Bamse", 48, "Dunderhonung", "Världens starkaste och snällaste björn", "Pappa björn");

            FinnishSpitz finnish1 = new FinnishSpitz();
            FinnishSpitz finnish2 = new FinnishSpitz("Koira", 10, "Gyllene", "Skälla på fåglar");

            SheepDog sheepDog1 = new SheepDog();
            SheepDog sheepDog2 = new SheepDog("Ozzie", 14, "Vit", 137);

            dogs1.GetInfo();            
            dogs1.WaggingTail();
            dogs1.MakeSound();
            Console.WriteLine();

            dogs2.GetInfo();            
            dogs2.WaggingTail();
            dogs2.MakeSound();
            Console.WriteLine();

            finnish1.GetInfo();            
            finnish1.WaggingTail();
            finnish1.Hunting();
            finnish1.MakeSound();
            Console.WriteLine();
            
            finnish2.GetInfo();            
            finnish2.WaggingTail();
            finnish2.Hunting();
            finnish2.MakeSound();
            Console.WriteLine();

            monkeys1.GetInfo();            
            monkeys1.HangInTail();
            monkeys1.MakeSound();
            Console.WriteLine();
            
            monkeys2.GetInfo();            
            monkeys2.HangInTail();
            monkeys2.MakeSound();
            Console.WriteLine();

            bears1.GetInfo();            
            bears1.Hibernate();
            bears1.MakeSound();
            Console.WriteLine();

            bears2.GetInfo();            
            bears2.Hibernate();
            bears2.MakeSound();
            Console.WriteLine();

            bool addAnimal;
            
            while (true)
            {
                Console.WriteLine("\nVill du lägga till ett djur? [y/n]");
                ConsoleKeyInfo addAnimalInput = Console.ReadKey();
                if (addAnimalInput.Key == ConsoleKey.Y)
                {
                    addAnimal = true;
                    break;
                }
                else
                {
                    addAnimal = false;
                    break;
                }
            }
            
            Console.Clear();

            string dogName = "";
            int dogAge = 0;
            string dogColor = "";
            string dogFood = "";

            string monkeyName = "";
            int monkeyAge = 0;
            int monkeyWeight = 0;
            string monkeyWild = "";

            string bearName = "";
            int bearAge = 0;
            string bearFood = "";
            string bearWild = "";
            string bearGender = "";
            



            if (addAnimal == true)
            {
                while (true)
                {

                    Console.WriteLine("Vilket djur vill du lägga till?");
                    Console.WriteLine("1. Hund");
                    Console.WriteLine("2. Apa");
                    Console.WriteLine("3. Björn");
                    Console.Write("Tryck 1, 2 eller 3: ");
                    ConsoleKeyInfo animalInput = Console.ReadKey();
                    Console.WriteLine();
                    if(animalInput.Key == ConsoleKey.D1 || animalInput.Key == ConsoleKey.NumPad1)
                    {
                        Console.WriteLine("\nDu har valt att lägga till en hund.");
                        Console.Write("\nNamn: ");
                        dogName = Console.ReadLine();
                        Console.Write("Ålder: ");
                        dogAge = int.Parse(Console.ReadLine());
                        Console.Write("Föda: ");
                        dogFood = Console.ReadLine();
                        Console.Write("Färg: ");
                        dogColor = Console.ReadLine();
                        Console.WriteLine();
                        Dogs userDog = new Dogs(dogName, dogAge, dogFood, dogColor);
                        userDog.GetInfo();
                        userDog.MakeSound();
                        userDog.WaggingTail();
                        break;
                    }
                    else if (animalInput.Key == ConsoleKey.D2 || animalInput.Key == ConsoleKey.NumPad2)
                    {
                        Console.WriteLine("\nDu har valt att lägga till en apa.");
                        Console.Write("\nNamn: ");
                        monkeyName = Console.ReadLine();
                        Console.Write("Ålder: ");
                        monkeyAge = int.Parse(Console.ReadLine());
                        Console.Write("Vikt: ");
                        monkeyWeight = int.Parse(Console.ReadLine());
                        Console.WriteLine("Är apan vild eller ett husdjur?");
                        monkeyWild = Console.ReadLine();
                        Console.WriteLine();
                        Monkeys userMonkey = new Monkeys(monkeyName, monkeyAge, monkeyWeight, monkeyWild);
                        userMonkey.GetInfo();
                        userMonkey.MakeSound();
                        userMonkey.HangInTail();
                        break;
                    }
                    else if (animalInput.Key == ConsoleKey.D3 || animalInput.Key == ConsoleKey.NumPad3)
                    {
                        Console.WriteLine("\nDu har valt att lägga till en björn.");
                        Console.Write("\nNamn: ");
                        bearName = Console.ReadLine();
                        Console.Write("Ålder: ");
                        bearAge = int.Parse(Console.ReadLine());
                        Console.WriteLine("Är det en vild eller en tam björn?");
                        bearWild = Console.ReadLine();
                        Console.WriteLine("Är det en hona eller hane?");
                        bearGender = Console.ReadLine();
                        Console.WriteLine();
                        Bears userBear = new Bears(bearName, bearAge, bearFood, bearWild, bearGender);
                        userBear.GetInfo();
                        userBear.Hibernate();
                        userBear.MakeSound();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nDu har gjort ett felaktigt val...");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nDu har valt att inte lägga till något djur. Hej då!");
            }



            Console.ReadKey();
        }



    }
}