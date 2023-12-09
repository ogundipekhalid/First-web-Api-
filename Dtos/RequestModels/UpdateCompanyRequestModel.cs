using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos.RequestModels
{
    public class UpdateCompanyRequestModel
    {
        public string Name {get;set;}
        public string CompanyNumber {get;set;}
        public string Email {get;set;}
        public string Website {get;set;}
        public string Logo {get;set;}
        public IFormFile CAC { get;set; }
        public bool isAproved {get;set;}
    }
}