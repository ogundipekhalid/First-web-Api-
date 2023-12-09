using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos
{
    public class ApplicantDto
    {
       public int Id {get; set;}
       public string Username {get; set;}
       public string FirstName {get; set;}
       public string LastName {get; set;}
       public string Email {get; set;}  
       public string PhoneNumber { get; set; }
       public string Profession {get;set;}
       public string ProfileImage {get;set;}
       public bool LookingForJob {get;set;}  
    }
}