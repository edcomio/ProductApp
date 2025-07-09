namespace MovieApp
{
    public class Movie
    {
        public int Id;
        public string Name;
        public string Genre;
        public int Year;

        public override string ToString()
        {
            return $"{Id}: {Name} - {Genre} ({Year})";
        }
        public string ToFileString()
        {
            return $"{Id}|{Name}|{Genre}|{Year}";
        }

       
        public static Movie FromFileString(string line)
        {
            var parts = line.Split('|');
            return new Movie
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Genre = parts[2],
                Year = int.Parse(parts[3])
            };
        }
    }
}
