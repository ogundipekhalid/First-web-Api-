using System;
using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos.RequestModels
{
    public class CreateAdminRequestModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string RoleName { get;set;}
        public string ProfileImage {get;set;}
        public DateTime DateOfBirth { get;set; }
    }
}