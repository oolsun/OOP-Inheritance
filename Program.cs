namespace OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dogs1 = new Dogs();
            Dogs dogs2 = new Dogs("Båtsman", 70, "Det Tjorven och Skrållan bjuder på", "Vit/brun");
            Monkeys monkeys1 = new Monkeys();
            Monkeys monkeys2 = new Monkeys("Herr Nilsson", 8, 7);
            Bears bears1 = new Bears();
            Bears bears2 = new Bears("Bamse", 48, "Dunderhonung", "Världens starkaste och snällaste björn");

            FinnishSpitz finnish = new FinnishSpitz("Koira", 10, "Gyllene");

            dogs1.GetInfo();
            dogs1.MakeSound();
            dogs1.WaggingTail();
            Console.WriteLine();

            dogs2.GetInfo();
            dogs2.MakeSound();
            dogs2.WaggingTail();
            Console.WriteLine();

            finnish.GetInfo();            
            finnish.WaggingTail();
            finnish.UsedFor();
            finnish.MakeSound();
            Console.WriteLine();

            monkeys1.GetInfo();
            monkeys1.MakeSound();
            monkeys1.HangInTail();
            Console.WriteLine();
            
            monkeys2.GetInfo();
            monkeys2.MakeSound();
            monkeys2.HangInTail();
            Console.WriteLine();

            bears1.GetInfo();
            bears1.MakeSound();
            bears1.Hibernate();
            Console.WriteLine();

            bears2.GetInfo();
            bears2.MakeSound();
            bears2.Hibernate();
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

            string bearName = "";
            int bearAge = 0;



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
                        Console.WriteLine();
                        Monkeys userMonkey = new Monkeys(monkeyName, monkeyAge, monkeyWeight);
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
                        Console.Write(" ");
                        // = Console.ReadLine();
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