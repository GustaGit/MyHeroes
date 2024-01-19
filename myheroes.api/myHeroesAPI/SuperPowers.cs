using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myHeroesAPI
{
    public class SuperPowers
    {
        [Key]
        public int Id { get; set; }

        [Column("Superpoder"), MaxLength(50)]
        public string SuperPower { get; set; } = string.Empty;

        [Column("Descricao"), MaxLength(250)]
        public string? Description { get; set; }
    }
}
