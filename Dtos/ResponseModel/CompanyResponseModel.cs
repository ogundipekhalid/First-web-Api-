using System.Collections.Generic;

namespace LinkedOut.Dtos.ResponseModel
{
    public class CompanyResponseModel : BaseResponse
    {
        public CompanyDto Data {get;set;}
    }
    public class CompanysResponseModel : BaseResponse
    {
        public List<CompanyDto> Data {get;set;} = new List<CompanyDto>();
    }
}