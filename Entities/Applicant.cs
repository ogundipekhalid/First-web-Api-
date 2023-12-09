using System.Collections.Generic;
using LinkedOut.Contracts;
using LinkedOut.Entites.Identity;

namespace LinkedOut.Entites
{
    public class Applicant : BaseUser
    {
        public string Profession {get;set;}
        public bool LookingForJob {get;set;}  
        public int UserId {get;set;} 
        public User User {get;set;}    
        List<Application> Applications {get;set;} = new List<Application>();
    }
}