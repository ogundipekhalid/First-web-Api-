namespace LinkedOut.Dtos
{
    public class AdminDto
    {
        public int Id {get; set;}
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PrifileImage {get;set;}
        public RoleDto RoleDto {get;set;}
    }
}