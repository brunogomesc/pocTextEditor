using System.ComponentModel.DataAnnotations;

namespace pocTextEditor.Models
{
    public class Document
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Write the title!")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Write the content!")]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}
