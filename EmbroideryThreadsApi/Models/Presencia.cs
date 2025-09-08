using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbroideryThreadsApi.Models
{
    public class Presencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PresenciaId { get; set; }
        public required string PresenciaNumber { get; set; }
        public required string PresenciaName { get; set; }
        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }
        public virtual required Color Color { get; set; }
    }
}
