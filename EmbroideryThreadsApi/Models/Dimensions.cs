using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbroideryThreadsApi.Models
{
    public class Dimensions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DimensionsId { get; set; }
        public required string DimensionsNumber { get; set; }

        public required string DimensionsName { get; set; }

        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }
        public virtual required Color Color { get; set; }
    }
}
