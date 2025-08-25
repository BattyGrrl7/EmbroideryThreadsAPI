using Microsoft.Identity.Client;

namespace EmbroideryThreadsApi.Models
{
    public class Anchor
    {
        public int AnchorId { get; set; }
        public required string AnchorNumber { get; set; }

        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }

        public virtual required Colors Color { get; set; }
    }
}
