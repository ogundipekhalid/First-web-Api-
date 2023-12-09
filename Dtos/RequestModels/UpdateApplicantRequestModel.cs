using System;
using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos.RequestModels
{
    public class UpdateApplicantRequestModel
    {
       public string Username {get; set;}
       public string FirstName {get; set;}
       public string LastName {get; set;}
       public string Email {get; set;}  
       public string PhoneNumber { get; set; }
       public string Profession {get;set;}
       public IFormFile ProfileImage {get;set;}
       public bool LookingForJob {get;set;} 
       public DateTime DateOfBirth {get;set;}
    }
}