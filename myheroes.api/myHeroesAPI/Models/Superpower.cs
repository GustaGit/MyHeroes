using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myHeroesAPI.Models
{
    [Table("Superpoderes")]
    public class Superpower
    {
        [Key]
        public int Id { get; set; }

        [Column("Superpoder"), MaxLength(50)]
        public string SuperPower { get; set; } = string.Empty;

        [Column("Descricao"), MaxLength(250)]
        public string? Description { get; set; }

        public List<Hero> Hero { get; set; }

    }
}
