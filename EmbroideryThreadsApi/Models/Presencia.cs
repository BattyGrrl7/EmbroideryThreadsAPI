namespace EmbroideryThreadsApi.Models
{
    public class Presencia
    {
        public int PresenciaId { get; set; }
        public required string PresenciaNumber { get; set; }
        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }
        public virtual required Colors Color { get; set; }
    }
}
