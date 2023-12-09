using LinkedOut.Contracts;
using Microsoft.AspNetCore.Http;

namespace LinkedOut.Entites
{
    public class Advertisement : AuditableEntity
    {
        public string Name { get;set;}
        public string Video {get;set;}
        public string Image {get;set;}
        public int CompanyId {get;set;}
        public Company Company {get;set;}

    }
}