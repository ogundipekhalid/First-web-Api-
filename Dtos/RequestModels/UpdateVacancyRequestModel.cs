using System;

namespace LinkedOut.Dtos.RequestModels
{
    public class UpdateVacancyRequestModel
    {
        public DateTime ApplicationDeadLine {get;set;}
        public string JobDescription {get;set;}
        public string AplicationDescription {get;set;}
    }
}