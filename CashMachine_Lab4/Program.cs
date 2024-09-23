namespace CashMachine_Lab4;

class Program
{
    static void Main(string[] args)
    {
        bool runApp = true;
        while (runApp)
        {
            Console.WriteLine("Välkommen till din internetbank" +
                              "[1] Logga in" +
                              "[2] Stäng ner");

            switch (Console.ReadLine())
            {
                case 1:
                    //köra programmet 
                    break;
                case 2:
                    runApp = false;
                    break;
                default:
                    Console.WriteLine("Felaktigt val! Försök igen!");
                    break;
            }

        }
    }
}