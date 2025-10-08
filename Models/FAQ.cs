#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class FAQ
    {
        // Auto-generated primary key
        public int FAQId { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        // Foreign key to Topic
        [Required]
        public string TopicId { get; set; }

        // Foreign key to Category
        [Required]
        public string CategoryId { get; set; }

        // Navigation properties
        public Topic Topic { get; set; }
        public Category Category { get; set; }
    }
}