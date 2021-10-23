using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FieldLevel.Models
{
    [NotMapped]
    public class PostModel
    {
        public string Body { get; set; }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int UserId { get; set; }
    }
}