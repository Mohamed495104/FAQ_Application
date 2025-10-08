#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Topic
    {
        // String primary key for user-friendly URLs
        [Key]
        [MaxLength(10)]
        public string TopicId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // Navigation property
        public ICollection<FAQ> FAQs { get; set; }
    }
}