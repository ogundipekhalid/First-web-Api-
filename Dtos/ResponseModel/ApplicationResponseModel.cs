using System.Collections.Generic;

namespace LinkedOut.Dtos.ResponseModel
{
    public class ApplicationResponseModel : BaseResponse
    {
        public ApplicationDto Data {get;set;}    
    }
    public class ApplicationsResponseModel : BaseResponse
    {
        public List<ApplicationDto> Data {get;set;} = new List<ApplicationDto>();
    }
}