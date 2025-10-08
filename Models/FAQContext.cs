#nullable disable
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models
{
    public class FAQContext : DbContext
    {
        public FAQContext(DbContextOptions<FAQContext> options) : base(options)
        {
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FAQ> FAQs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<FAQ>()
                .HasOne(f => f.Topic)
                .WithMany(t => t.FAQs)
                .HasForeignKey(f => f.TopicId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FAQ>()
                .HasOne(f => f.Category)
                .WithMany(c => c.FAQs)
                .HasForeignKey(f => f.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed Topics
            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "bootstrap", Name = "Bootstrap" },
                new Topic { TopicId = "js", Name = "JavaScript" },
                new Topic { TopicId = "jquery", Name = "jQuery" }
            );

            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "gen", Name = "General" },
                new Category { CategoryId = "hist", Name = "History" }
            );

            // Seed FAQs
            modelBuilder.Entity<FAQ>().HasData(
                // Bootstrap FAQs
                new FAQ
                {
                    FAQId = 1,
                    Question = "What is Bootstrap?",
                    Answer = "Bootstrap is a free, open-source front-end framework for developing websites and web applications.",
                    TopicId = "bootstrap",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    FAQId = 2,
                    Question = "When was Bootstrap released?",
                    Answer = "Bootstrap was originally released in August 2011.",
                    TopicId = "bootstrap",
                    CategoryId = "hist"
                },
                new FAQ
                {
                    FAQId = 3,
                    Question = "Who created Bootstrap?",
                    Answer = "Bootstrap was created by Mark Otto and Jacob Thornton at Twitter.",
                    TopicId = "bootstrap",
                    CategoryId = "hist"
                },
                // JavaScript FAQs
                new FAQ
                {
                    FAQId = 4,
                    Question = "What is JavaScript?",
                    Answer = "JavaScript is a high-level, interpreted programming language used to make web pages interactive.",
                    TopicId = "js",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    FAQId = 5,
                    Question = "When was JavaScript created?",
                    Answer = "JavaScript was created in 1995 by Brendan Eich while he was working at Netscape.",
                    TopicId = "js",
                    CategoryId = "hist"
                },
                new FAQ
                {
                    FAQId = 6,
                    Question = "Is JavaScript the same as Java?",
                    Answer = "No, JavaScript and Java are completely different programming languages with different purposes and syntax.",
                    TopicId = "js",
                    CategoryId = "gen"
                },
                // jQuery FAQs
                new FAQ
                {
                    FAQId = 7,
                    Question = "What is jQuery?",
                    Answer = "jQuery is a fast, small, and feature-rich JavaScript library that simplifies HTML document manipulation and event handling.",
                    TopicId = "jquery",
                    CategoryId = "gen"
                },
                new FAQ
                {
                    FAQId = 8,
                    Question = "Who developed jQuery?",
                    Answer = "jQuery was created by John Resig and released in 2006.",
                    TopicId = "jquery",
                    CategoryId = "hist"
                }
            );
        }
    }
}