using LinkedOut.Contracts;
using LinkedOut.Entites.Identity;

namespace LinkedOut.Entites
{
    public class Admin : BaseUser
    {
        public int RoleId {get;set;}
        public Role Role {get;set;}
        public int UserId {get; set;}
        public User User {get;set;}
    }
}