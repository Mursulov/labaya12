using System.ComponentModel.DataAnnotations;

namespace Lab12RazorJson.Models
{
    public class ProjectAssignment
    {
        public int Id { get; set; }

        [Required]
        public int ResearcherId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string Role { get; set; } = string.Empty;

        public Researcher? Researcher { get; set; }
        public Project? Project { get; set; }
    }
}
