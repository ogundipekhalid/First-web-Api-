using System;

namespace LinkedOut.Dtos.RequestModels
{
    public class CreateVacancyRequestModel
    {
        public string JobType {get;set;}
        public DateTime ApplicationDeadLine {get;set;}
        public string JobDescription {get;set;}
        public string AplicationDescription {get;set;}
        public int CompanyId {get;set;}
    }
}