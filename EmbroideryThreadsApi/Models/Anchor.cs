using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbroideryThreadsApi.Models
{
    public class Anchor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AnchorId { get; set; }
        public required string AnchorNumber { get; set; }
        public required string AnchorName { get; set; }

        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }

        public virtual required Color Color { get; set; }
    }
}
