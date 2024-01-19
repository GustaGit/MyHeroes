using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myHeroesAPI
{
    public class HeroModel
    {
        [Key]
        public int Id { get; set; }

        [Column("Nome")]
        public string Name { get; set; } = string.Empty;

        [Column("NomeHeroi")]
        public string NameHero { get; set; } = string.Empty;

        public List<SuperPowers>? Superpowers { get; set; }

        [Column("DataNascimento")]
        public DateTime? Birthdate { get; set; }

        [Column("Altura")]
        public double Height { get; set; }

        [Column("Peso")]
        public double Weight { get; set; }
    }
}
