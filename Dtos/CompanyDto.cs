using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos
{
    public class CompanyDto
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string CompanyNumber {get;set;}
        public string Email {get;set;}
        public string Website {get;set;}
        public string Logo {get;set;}
    }
}