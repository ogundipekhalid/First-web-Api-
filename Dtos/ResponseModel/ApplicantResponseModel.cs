using System.Collections.Generic;

namespace LinkedOut.Dtos.ResponseModel
{
    public class ApplicantResponseModel : BaseResponse
    {
        public ApplicantDto Data {get;set;}
    }
    public class ApplicantsResponseModel : BaseResponse
    {
        public List<ApplicantDto> Data {get;set;} = new List<ApplicantDto>();
    }
}