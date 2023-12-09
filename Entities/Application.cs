using System.Collections.Generic;
using LinkedOut.Contracts;

namespace LinkedOut.Entites
{
    public class Application : AuditableEntity
    {
        public string CV {get;set;}
        public bool isAproved {get;set;}
        public string PhoneNumber {get;set;}
        public string Email {get;set;}
        public int ApplicantId {get;set;}
        public Applicant Applicant {get;set;}
        public int VacancyId {get;set;}
        public Vacancy Vacancy {get;set;}
    }
}