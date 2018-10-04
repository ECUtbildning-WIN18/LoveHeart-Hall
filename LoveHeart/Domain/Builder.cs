using System.Collections.Generic;
using LoveHeart.Domain.User;

namespace LoveHeart.Domain
{
    public class Builder
    {
        static List<IUser> Users = new List<IUser>
        {
            new Admin("Lasse", "Kongo", "LaKongo", "ballebula"),
            new Receptionist("Frasse", "Ståfräs", "SeriösaNamnet", "pw123"),
            new Veterinary("Stina", "Gräshög", "Weedsmoke", "123pw")
        };

        public static List<IUser> RtnAList()
        {
            return Users;
        } 
    }
}