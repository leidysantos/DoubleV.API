namespace DoubleV.API.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Password { get; set; }
        public DateTime creationDate { get; set; }
    }
}
