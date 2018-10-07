namespace LoveHeart.Domain
{
    public class Receptionist : IUser
    {
        public Receptionist(string firstName, string lastName, string userName, string password)
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
        public string AccessRight { get; } = "recep";
    }
}