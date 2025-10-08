using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment2.Models;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        private readonly FAQContext _context;

        public HomeController(FAQContext context)
        {
            _context = context;
        }

        // Most specific route: topic + category
        [Route("topic/{id}/category/{catId}/")]
        
        [Route("topic/{id}/")]
        
        [Route("category/{catId}/")]

        // Default route for all FAQs
        [Route("")]
        public IActionResult Index(string id = "all", string catId = "all")
        {
            // Start with all FAQs including related Topic and Category
            var query = _context.FAQs
                .Include(f => f.Topic)
                .Include(f => f.Category)
                .AsQueryable();

            // Filter by topic if not "all"
            if (id != "all")
            {
                query = query.Where(f => f.TopicId == id);
            }

            // Filter by category if not "all"
            if (catId != "all")
            {
                query = query.Where(f => f.CategoryId == catId);
            }

            // Get all topics and categories for navigation
            ViewBag.Topics = _context.Topics.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.SelectedTopic = id;
            ViewBag.SelectedCategory = catId;

            return View(query.ToList());
        }
    }
}
