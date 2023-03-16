namespace DoubleV.API.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public String Names { get; set; }
        public String LastNames { get; set; }
        public long Identification { get; set; }
        public String Email { get; set; }
        public String TypeID { get; set; }
        public DateTime creationDate { get; set; }
    }
}
