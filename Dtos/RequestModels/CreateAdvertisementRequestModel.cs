using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos.RequestModels
{
    public class CreateAdvertisementRequestModel
    {
        public string Name { get;set;}
        public IFormFile Video {get;set;}
        public IFormFile Image {get;set;}
    }
}