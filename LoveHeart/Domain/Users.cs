using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using LoveHeart.Domain.User;

namespace LoveHeart.Domain
{
    public class Users
    {
        private static List<IUser> UserList = new List<IUser>
        {
            new Admin("Lasse", "Kongo", "LaKongo", "ballebula"),
            new Receptionist("Frasse", "Ståfräs", "SeriösaNamnet", "pw123"),
            new Veterinary("Stina", "Gräshög", "Weedsmoke", "123pw")
        };

        public static List<IUser> GetUserList()
        {
            return UserList;
        }

        public static void AddUser()
        {
            while (true)
            {
                
                string firstName, lastName, userName, password, secPassword;
                
                Console.Clear();
                Utils.RedAlert("Add a new user!");

                Console.WriteLine("What type of User do you want to create?");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Receptionist");
                Console.WriteLine("3. Veterinary");
                var choice = Utils.ReadInputMinMax(1, 3);
                
                Console.Write("First Name: ");
                firstName = Console.ReadLine();
                
                Console.Write("Last Name: ");
                lastName = Console.ReadLine();
                
                Console.Write("Username: ");
                userName = Console.ReadLine();
                
                do
                {
                    Console.Write("Password:");
                    password = Console.ReadLine();
                    Console.Write("Confirm Password:");
                    secPassword = Console.ReadLine();
                    if (password != secPassword)
                    {
                        Console.Clear();
                        Utils.RedAlert("Please enter the same password twice");
                    }
                } while (password != secPassword);

                while (true)
                {
                    Console.Clear();
                    Utils.RedAlert("Do you want to add the following user?");
                    if (choice == 1)
                    {
                        Utils.RedAlert("Administrator");
                    } else if (choice == 2)
                    {
                        Utils.RedAlert("Receptionist");
                    }
                    else if (choice == 3)
                    {
                        Utils.RedAlert("Veterinary");
                    }
                    
                    Console.WriteLine($"{firstName} {lastName}, with Username: {userName}");
                    Console.WriteLine("(y)es / no");
                    string input = Console.ReadLine().ToLower();
                    
                    if (input == "y" || input == "yes")
                    {
                        if (choice == 1)
                        {
                            UserList.Add(new Admin(firstName,lastName,userName,password));
                        } else if (choice == 2)
                        {
                            UserList.Add(new Receptionist(firstName,lastName,userName,password));
                        } else if (choice == 3)
                        {
                            UserList.Add(new Veterinary(firstName,lastName,userName,password));
                        }
                    }
                    
                    Console.Clear();
                    Utils.RedAlert("The new user has been added to the system!");
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                    return;
                }
            }
        }
    }
}