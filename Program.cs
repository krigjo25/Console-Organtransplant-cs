using System.Diagnostics;
using Organtransplant.lib;
namespace Organtransplant
{
    class ConsoleApp
    {
        
        
        static void Main(string[] args)
        {
            // Initializing the app
            var db = new DataCollection();
            
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
                Console.WriteLine("Welcome to Theme Hospital !");
                Console.WriteLine("Press 1 to start the operation !");
                Console.WriteLine("Press 2 to see available Donors!");
                Console.WriteLine("Press 3 to see available Organs !");
                Console.WriteLine("Press 4 to see Patients !");
                Console.WriteLine("Press Esc or Q to exit !");
                
                var key = Console.ReadKey();
                Console.Clear();
                
                switch(key.Key)
                {
                    case ConsoleKey.D1:
                        obj.ReplayTranslpant();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("Press Esc to exit");
                        obj.PrintDonorList();
                        break;
                    
                    case ConsoleKey.D3:
                        obj.PrintAvailableOrgans();
                        break;
                    
                    case ConsoleKey.D4:
                        Console.WriteLine("Press Esc to exit");
                        obj.PrintPatient();
                        break;
                    
                    case ConsoleKey.Escape or ConsoleKey.Q:
                        return;
                }

                Console.WriteLine("Press a Key to continue, Esc or Q to exit.");
                Console.ReadKey();
            }
        }
    }
}