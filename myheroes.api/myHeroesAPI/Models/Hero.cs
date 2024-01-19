using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myHeroesAPI.Models
{
    [Table("Herois")]
    public class Hero
    {
        [Key]
        public int Id { get; set; }

        [Column("Nome"), MaxLength(120)]
        public string Name { get; set; } = string.Empty;

        [Column("NomeHeroi"), MaxLength(120)]
        public string NameHero { get; set; } = string.Empty;

        public List<Superpower> Superpowers { get; set; }

        [Column("DataNascimento")]
        public DateTime? Birthdate { get; set; }

        [Column("Altura", TypeName ="float")]
        public float Height { get; set; }

        [Column("Peso", TypeName ="float")]
        public float Weight { get; set; }
    }
}
