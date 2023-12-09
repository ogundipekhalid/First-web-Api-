using System.Collections.Generic;
using LinkedOut.Contracts;

namespace LinkedOut.Entites.Identity
{
    public class Role : AuditableEntity
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Admin> Admin {get;set;}
    }
}