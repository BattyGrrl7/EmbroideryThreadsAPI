namespace EmbroideryThreadsApi.Models
{
    public class Dimensions
    {
        public int DimensionsId { get; set; }
        public required string DimensionsNumber { get; set; }

        public required string DimensionsName { get; set; }

        /// <summary>
        /// Foreign key to Colors table
        /// </summary>
        public required int ColorId { get; set; }
        public virtual required Colors Color { get; set; }
    }
}
