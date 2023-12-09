using System.Collections.Generic;
using LinkedOut.Contracts;
using Microsoft.AspNetCore.Http;

namespace LinkedOut.Entites
{
    public class Company : AuditableEntity
    {
        public string Name {get;set;}
        public string CompanyNumber {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public string Website {get;set;}
        public string Logo {get;set;}
        public string CAC { get;set; }
        public bool isAproved {get;set;}
        public List<Advertisement> Advertisements {get;set;} = new List<Advertisement>();
        public List<Vacancy> Vacancies {get;set;} = new List<Vacancy>();
        public List<Contact> Contacts = new List<Contact>();
    }
}