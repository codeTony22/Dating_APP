namespace DatingApp.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description {get; set; }
        public System.DateTime DateAddded { get; set; }
        public bool isMain { get; set; }
    }
}