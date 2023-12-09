using System;
using System.Collections.Generic;
using LinkedOut.Contracts;

namespace LinkedOut.Entites
{
    public class Vacancy : AuditableEntity
    {
        public string JobType {get;set;}
        public DateTime ApplicationDeadLine {get;set;}
        public string JobDescription {get;set;}
        public string AplicationDescription {get;set;}
        public int CompanyId {get;set;}
        public Company Company {get;set;}
        public List<Application> Applications {get;set;} = new List<Application>();

    }
}