
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFStarted.Entities
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long BlogId { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
        
    }
}