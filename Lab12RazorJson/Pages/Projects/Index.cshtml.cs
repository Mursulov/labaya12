using Microsoft.AspNetCore.Mvc.RazorPages;
using Lab12RazorJson.Models;
using Lab12RazorJson.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab12RazorJson.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Project> Projects { get; set; } = new List<Project>();

        public async Task OnGetAsync()
        {
            Projects = await _context.Projects.ToListAsync();
        }
    }
}
