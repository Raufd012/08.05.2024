namespace ProniaAb106.Models
{
    public class BaseEntity
    {
        public int id { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedTime { get; set; }
    }
}
