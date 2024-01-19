namespace myHeroesAPI
{
    public class HeroModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameHero { get; set; } = string.Empty;
        public List<string>? Superpowers { get; set; }=null;
        public DateTime Birthdate { get; set; }
        public double Height { get; set; } 
        public double Weight { get; set; }
    }
}
