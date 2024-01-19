using System.ComponentModel.DataAnnotations.Schema;

namespace myHeroesAPI.Models
{
    [Table("HeroisSuperpoderes")]
    public class HeroSuperpower
    {
        public int HeroId { get; set; }
        public Hero Hero { get; set; }

        public int SuperpowerId { get; set; }
        public Superpower Superpower { get; set; }
    }
}
