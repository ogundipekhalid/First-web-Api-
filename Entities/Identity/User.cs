using LinkedOut.Contracts;

namespace LinkedOut.Entites.Identity
{
    public class User : AuditableEntity
    {
        public string Email {get; set;}  
        public string Password { get; set; }
        public Applicant Applicant {get;set;}
        public Admin Admin {get; set;}
    }
}