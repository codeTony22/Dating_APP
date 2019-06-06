namespace DatingApp.API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description {get; set; }
        public System.DateTime DateAddded { get; set; }
        public bool isMain { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}