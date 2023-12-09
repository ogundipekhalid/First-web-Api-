using System;

namespace LinkedOut.Dtos
{
    public class VacancyDto
    {
        public int Id {get;set;}
        public string JobType {get;set;}
        public DateTime ApplicationDeadLine {get;set;}
        public string JobDescription {get;set;}
        public string AplicationDescription {get;set;}
    }
}