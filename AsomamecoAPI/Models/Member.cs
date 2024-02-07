namespace AsomamecoAPI.Models
{
    public class Member
    {
        public int Id { get; set; }
        public int IdCard { get; set; }
        public int IdRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }
        public bool IsActive { get; set; }
    }
}
