namespace DatingApp.API.Models
{
    public class Roles
    {
        public string Id { get; set; }
        public string Role { get; set; }
        public System.DateTime DateUpdated {get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}