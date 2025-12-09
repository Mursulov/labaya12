using System.ComponentModel.DataAnnotations;

namespace Lab12RazorJson.Models
{
    public class Researcher
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Department { get; set; } = string.Empty;

        [Required]
        public DateTime HireDate { get; set; }

        public List<ProjectAssignment> ProjectAssignments { get; set; } = new();
    }
}
