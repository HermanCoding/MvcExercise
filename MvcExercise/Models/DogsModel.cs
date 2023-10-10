namespace MvcExercise.Models
{
    public class DogsModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Cuteness { get; set; }
        public string Image { get; set; } = null!;
		public string? FavFood { get; set; }
        public string? FavToy { get; set; }
        public int Temperament { get; set; }
        public bool IsAdopted { get; set; }
    }
}
