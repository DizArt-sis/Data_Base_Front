using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Air
    {
        public void Start()
        {
            RunAutoMenu();
        }
        private void RunAutoMenu()
        {
            string prompt = @"
   ▄████████  ▄█       ▄██   ▄        ▄████████ ███▄▄▄▄   ████████▄    ████████▄   ▄██████▄  ███▄▄▄▄       ███       ████████▄   ▄█     ▄████████ 
  ███    ███ ███       ███   ██▄     ███    ███ ███▀▀▀██▄ ███   ▀███   ███   ▀███ ███    ███ ███▀▀▀██▄ ▀█████████▄   ███   ▀███ ███    ███    ███ 
  ███    █▀  ███       ███▄▄▄███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███    ▀███▀▀██   ███    ███ ███▌   ███    █▀  
 ▄███▄▄▄     ███       ▀▀▀▀▀▀███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███   ▀   ███    ███ ███▌  ▄███▄▄▄     
▀▀███▀▀▀     ███       ▄██   ███   ▀███████████ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███▌ ▀▀███▀▀▀     
  ███        ███       ███   ███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███    ███    █▄  
  ███        ███▌    ▄ ███   ███     ███    ███ ███   ███ ███   ▄███   ███   ▄███ ███    ███ ███   ███     ███       ███   ▄███ ███    ███    ███ 
  ███        █████▄▄██  ▀█████▀      ███    █▀   ▀█   █▀  ████████▀    ████████▀   ▀██████▀   ▀█   █▀     ▄████▀     ████████▀  █▀     ██████████ 
             ▀                                                                                                                                             
";
            string[] options = { @"---------------------------
 |      Registrationt      |
 ---------------------------", @"---------------------------
 |      Authotization      |
 ---------------------------", @"---------------------------
 |          Exit           |
 ---------------------------" };
            Menu autoMenu = new Menu(prompt, options);
            int selectedIndex = autoMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Registrationt();
                    break;
                case 1:
                    Authorization();
                    break;
                case 2:
                    Exit();
                    break;
            }
        }

        private void RunMainMenu()
        {
            string prompt = @"
   ▄████████  ▄█       ▄██   ▄        ▄████████ ███▄▄▄▄   ████████▄    ████████▄   ▄██████▄  ███▄▄▄▄       ███       ████████▄   ▄█     ▄████████ 
  ███    ███ ███       ███   ██▄     ███    ███ ███▀▀▀██▄ ███   ▀███   ███   ▀███ ███    ███ ███▀▀▀██▄ ▀█████████▄   ███   ▀███ ███    ███    ███ 
  ███    █▀  ███       ███▄▄▄███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███    ▀███▀▀██   ███    ███ ███▌   ███    █▀  
 ▄███▄▄▄     ███       ▀▀▀▀▀▀███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███   ▀   ███    ███ ███▌  ▄███▄▄▄     
▀▀███▀▀▀     ███       ▄██   ███   ▀███████████ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███▌ ▀▀███▀▀▀     
  ███        ███       ███   ███     ███    ███ ███   ███ ███    ███   ███    ███ ███    ███ ███   ███     ███       ███    ███ ███    ███    █▄  
  ███        ███▌    ▄ ███   ███     ███    ███ ███   ███ ███   ▄███   ███   ▄███ ███    ███ ███   ███     ███       ███   ▄███ ███    ███    ███ 
  ███        █████▄▄██  ▀█████▀      ███    █▀   ▀█   █▀  ████████▀    ████████▀   ▀██████▀   ▀█   █▀     ▄████▀     ████████▀  █▀     ██████████ 
             ▀                                                                                                                                             
";
            string[] options = { @" ---------------------------
 |      Buy a ticket       |
 ---------------------------", @"---------------------------
 |        My tickets       |
 ---------------------------", @"---------------------------
 |          Exit           |
 ---------------------------" };
            Menu allMenu = new Menu(prompt, options);
            int selectedIndex = allMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Registrationt();
                    break;
                case 1:
                    Authorization();
                    break;
                case 2:
                    Exit();
                    break;
            }
        }

        private void BuyTicket()
        {
            
        }

        private void Exit()
        {
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);

        }

        private void Authorization()
        {
            Console.Clear();
            FileManager fileManager = new FileManager("users.txt");
            Console.Write(@"################################################################################
#                  _    _                   _             _    _               #
#     /\          | |  | |                 (_)           | |  (_)              #
#    /  \   _   _ | |_ | |__    ___   _ __  _  ____ __ _ | |_  _   ___   _ __  #
#   / /\ \ | | | || __|| '_ \  / _ \ | '__|| ||_  // _` || __|| | / _ \ | '_ \ #
#  / ____ \| |_| || |_ | | | || (_) || |   | | / /| (_| || |_ | || (_) || | | |#
# /_/    \_\\__,_| \__||_| |_| \___/ |_|   |_|/___|\__,_| \__||_| \___/ |_| |_ #
#                                                                              #
#                                                                              #
#                 ________________                     _______________         #
#        Login : |                |       Password :  |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
#                                                                              #
#                                                                              #
#                                                                              #
################################################################################");
            Console.SetCursorPosition(18, 10);
            string username = Console.ReadLine();
            Console.SetCursorPosition(55, 10);
            string password = Console.ReadLine();
            

            if (fileManager.UserExists(username, password))
            {
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("Login successful!");
                Console.ReadKey();
                RunMainMenu();
            }
            else
            {
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("Invalid username or password.");
                Console.ReadKey();
                RunAutoMenu();
            }
            
        }
        private void Registrationt()
        {
            Console.Clear();
            Console.Write(@"################################################################################
#            _____            _     _             _   _                        #
#           |  __ \          (_)   | |           | | (_)                       #
#           | |__) |___  __ _ _ ___| |_ _ __ __ _| |_ _  ___  _ __             #
#           |  _  // _ \/ _` | / __| __| '__/ _` | __| |/ _ \| '_ \            #
#           | | \ \  __/ (_| | \__ \ |_| | | (_| | |_| | (_) | | | |           #
#           |_|  \_\___|\__, |_|___/\__|_|  \__,_|\__|_|\___/|_| |_|           #
#                        __/ |                                                 #
#                       |___/                                                  #
#                 ________________                     _______________         #
#        Login : |                |       Password :  |               |        #
#                 ''''''''''''''''                     '''''''''''''''         #
#                                                                              #
#                                                                              #
#                                                                              #
################################################################################");
            FileManager fileManager = new FileManager("users.txt");
            User newUser = new User("Artem", "12345", "johndoe@example.com");
            Console.SetCursorPosition(18, 10);
            string name = Console.ReadLine();
            newUser.Username = name;
            Console.SetCursorPosition(55, 10);
            string pass = Console.ReadLine();
            newUser.Password = pass;
            fileManager.SaveUser(newUser);
            RunAutoMenu();
        }
    }
}
