using System;
using LinkedOut.Contracts;
using Microsoft.AspNetCore.Http;

namespace LinkedOut.Entites.Identity
{
    public class BaseUser : AuditableEntity
    {
        public string Username {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string PhoneNumber { get; set; }
        public string PrifileImage {get;set;}
        public DateTime DateOfBirth { get;set; }
    }
}