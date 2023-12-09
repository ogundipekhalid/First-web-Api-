using System.Collections.Generic;

namespace LinkedOut.Dtos.ResponseModel
{
    public class AdvertisementResponseModel : BaseResponse
    {
        public AdvertisementDto Data {get;set;}
    }
    public class AdvertisementsResponseModel : BaseResponse
    {
        public List<AdvertisementDto> Data {get;set;} = new List<AdvertisementDto>();
    }
}