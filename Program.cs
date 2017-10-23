using System;

namespace question32
{
    class Falcon
    {
        private string _Name;
        private string _Species;
        private string _Sex;
        private int _Weight;
        private string _BandNumber;

        public string Name
        {
            set
            {
                Console.WriteLine("Enter the Falcons name"); 
                _Name = Console.ReadLine();
            }
        }

        public string Species
        {
            set
            {
                Console.WriteLine("What is the Falcons Species?");
                _Species = Console.ReadLine(); 
            }
        }

        public string sex
        {
            set
            {
                Console.WriteLine("what is the falcons Sex?"); 
                _Sex = Console.ReadLine(); 
            }
        }

        public int Weight
        {
            set
            {
                Console.WriteLine("What is the Falcons Weight?");
                _Weight = int.Parse(Console.ReadLine()); 
            }
        }

        public string BandNumber
        {
            set
            {
                Console.WriteLine("What is the Falcons BandNumber?");
                _BandNumber = Console.ReadLine(); 
            }
        }

        public Falcon(string _Name, string _Species, string _Sex, int _Weight, string _BandNumber)
        {
            Name = _Name;
            Species = _Species;
            sex = _Sex;
            Weight = _Weight; 
            BandNumber = _BandNumber;
        }

        public string DisplayFalcon()
        {
            var showFalcon = "The falcon is:\n\n";
            showFalcon += $"The Name is: {_Name}\n";
            showFalcon += $"The Species is: {_Species}\n";
            showFalcon += $"The Sex is: {_Sex}\n";
            showFalcon += $"The Weight is: {_Weight}grams \n";
            showFalcon += $"The BandNumber is: {_BandNumber}\n";

            return showFalcon;
        }
    }

    class Program 
    {       
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            var input = new Falcon("", "", "", 000, "");

            Console.WriteLine(input.DisplayFalcon());
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
