using System.Collections.Generic;
using LinkedOut.Contracts;

namespace LinkedOut.Entites
{
    public class Contact : AuditableEntity
    {
        public string Name {get;set;}
        public string Link {get;set;}
        public int CompanyId {get;set;}
        public Company Company {get;set;}
    }
}