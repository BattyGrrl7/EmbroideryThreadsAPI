using System.ComponentModel.DataAnnotations;

namespace EmbroideryThreadsApi.Models
{
    public class Colors
    {
        [Key]
        public int ColorId { get; set; }

        public required string ColorName { get; set; }

        public required string HexCode { get; set; }
    }
}
