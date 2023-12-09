using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos.RequestModels
{
    public class CreateApplicationRequestModel
    {
        public IFormFile CV {get;set;}
        public bool isAproved {get;set;}
        public string PhoneNumber {get;set;}
        public string Email {get;set;}
        public int ApplicantId {get;set;}
    }
}