namespace LoveHeart.Domain
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string AccessRight { get; }
    }
}