using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos
{
    public class ApplicationDto
    {
        public string CV {get;set;}
        public bool isAproved {get;set;}
        public string PhoneNumber {get;set;}
        public string Email {get;set;}
    }
}