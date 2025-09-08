using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace EmbroideryThreadsApi.Models
{
    public class DMC
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DMCId { get; set; }

        public required string DMCNumber { get; set; }
        public required string DMCName { get; set; }

        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }

        public virtual required Color Color { get; set; }
    }
}
