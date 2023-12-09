using System.Collections.Generic;

namespace LinkedOut.Dtos.ResponseModel
{
    public class VacancyResponseModel : BaseResponse
    {
        public VacancyDto Data {get;set;}
    }
    public class VacanciesResponseModel : BaseResponse
    {
        public List<VacancyDto> Data {get;set;} = new List<VacancyDto>();
    }
}