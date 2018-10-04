using System;
using System.Collections.Generic;
using System.Linq;

namespace LoveHeart.Domain.Menu
{
    public class Menu
    {
        
        public static void DrawMenu(List<IUser> users)
        {
            var user = LogInMenu(users);
            
            Console.Clear();
            
            Console.WriteLine($"Welcome {user.FirstName} {user.LastName}");
        }

        private static IUser LogInMenu(List<IUser> users)
        {
            

            while (true)
            {
                
                Console.WriteLine("Please sign in to the system to proceed.");
                Console.Write("User Name: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                foreach (var user in users)
                {
                    if (user.UserName == username && user.Password == password)
                    {
                        return user;
                    }
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter correct Username and Password");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}