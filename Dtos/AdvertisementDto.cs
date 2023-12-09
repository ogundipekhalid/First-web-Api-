using Microsoft.AspNetCore.Http;

namespace LinkedOut.Dtos
{
    public class AdvertisementDto
    {
        public int Id {get;set;}
        public string Name { get;set;}
        public string Video {get;set;}
        public string Image {get;set;}
    }
}