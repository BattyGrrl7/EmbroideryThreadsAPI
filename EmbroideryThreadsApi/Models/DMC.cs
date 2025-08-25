using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace EmbroideryThreadsApi.Models
{
    public class DMC
    {
        [Key]
        public int DMCId { get; set; }

        public required string DMCNumber { get; set; }

        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }

        public virtual required Colors Color { get; set; }
    }
}
