using System.ComponentModel.DataAnnotations;

namespace WebAssignment2.Models
{
    public class Reviews
    {
        [Key]
        public int ID { get; set; }
        public string Product { get; set; }
        public string Name { get; set; }
        public string Feedback { get; set; }
    }
}
