using System.Collections.Generic;

namespace LoveHeart.Domain
{
    public class Admin : IUser
    {
        public Admin(string firstName, string lastName, string userName, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            UserName = userName;
            Password = password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccessRight { get; } = "Admin";
    }
}