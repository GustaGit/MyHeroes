using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myHeroesAPI
{
    public class HeroModel
    {
        [Key]
        public int Id { get; set; }

        [Column("Nome"),MaxLength(120)]
        public string Name { get; set; } = string.Empty;

        [Column("NomeHeroi"),MaxLength(120)]
        public string NameHero { get; set; } = string.Empty;

        public List<SuperPowers>? Superpowers { get; set; }

        [Column("DataNascimento")]
        public DateTime? Birthdate { get; set; }

        [Column("Altura")]
        public float Height { get; set; }

        [Column("Peso")]
        public float Weight { get; set; }
    }
}
