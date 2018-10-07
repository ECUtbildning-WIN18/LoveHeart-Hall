using System;
using System.Collections.Generic;
using LoveHeart.Domain;
using LoveHeart.Domain.Menu;

namespace LoveHeart
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<IUser> userList = Users.GetUserList();

            foreach (var user in userList)
            {
                Console.WriteLine(user.FirstName);
            }

            Console.ReadKey();
            Users.AddUser();
            
            foreach (var user in userList)
            {
                Console.WriteLine(user.FirstName);
            }
            Console.ReadKey();
            
            //Menu.DrawMenu(testUsers);
            
            
        }
    }
}