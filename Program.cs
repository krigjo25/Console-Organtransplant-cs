using Organtransplant.lib;
namespace Organtransplant
{
    class CApp
    {
        
        
        static void Main(string[] args)
        {
            // Initializing the app
            var r = new Random();
            var db = new DataCollection();
            string[] arg = ["Heart", "Kidney"];
            
            // Pre made lists
            db.InitalizeOrganData();
            db.InitializeDonorData();

            // Run App
            RunApp(db);
        }
        private static void RunApp(DataCollection obj)
        {
            while (true)
            {
                // Introduce the program
                Console.Clear();
                Console.WriteLine("Welcome to Theme Hospital !");
                Console.WriteLine("Type 1 to start the operation !");
                Console.WriteLine("Type 2 to see available Donors!");
                Console.WriteLine("Type 3 to see available Organs !");
                Console.WriteLine("Type 4 to see Patient !");
                Console.WriteLine("Press Esc to exit !");
                
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.D1)
                {
                    obj.ReplayTranslpant();
                    break;
                }
                if (key.Key == ConsoleKey.D2)
                {
                    obj.PrintDonorList();
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.D3)
                {
                    obj.PrintAvailableOrgans();
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.D4)
                {
                    obj.PrintPatient();
                    Console.ReadKey();
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            
        }

    }
}