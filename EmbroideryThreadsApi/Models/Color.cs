using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmbroideryThreadsApi.Models
{
    public class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }

        public required string ColorName { get; set; }

        //This will only store the Hex Code without the hashtag
        // ie, for #FFFFFF, FFFFFF will be stored
        [MaxLength(6)]
        public required string HexCode { get; set; }
    }
}
