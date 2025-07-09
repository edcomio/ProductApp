 using System;
using System.Collections.Generic;
using System.IO;

namespace MovieApp
    {
        public class SimpleMoviesApp
        {
            private const int MaxMovies = 5;
            private readonly string filePath = "movies.txt";
            private List<Movie> movies = new List<Movie>();

            public SimpleMoviesApp()
            {
                LoadMovies();
            }

            public void Run()
            {
                int choice;
                do
                {
                    Console.WriteLine("\n--- Movie App Menu ---");
                    Console.WriteLine("1. Display Movies");
                    Console.WriteLine("2. Add Movie");
                    Console.WriteLine("3. Clear All Movies");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    if (!int.TryParse(Console.ReadLine(), out choice)) continue;

                    switch (choice)
                    {
                        case 1: DisplayMovies(); break;
                        case 2: AddMovie(); break;
                        case 3: ClearMovies(); break;
                        case 4: SaveMovies(); Console.WriteLine("Exiting... Data saved."); break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }

                } while (choice != 4);
            }

            private void DisplayMovies()
            {
                if (movies.Count == 0)
                {
                    Console.WriteLine("No movies to display.");
                    return;
                }

                Console.WriteLine("\n--- Movie List ---");
                foreach (var movie in movies)
                {
                    Console.WriteLine(movie);
                }
            }

            private void AddMovie()
            {
                if (movies.Count >= MaxMovies)
                {
                    Console.WriteLine("Movie list is full (max 5).");
                    return;
                }

                Movie m = new Movie();

                Console.Write("Enter Movie ID: ");
                m.Id = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter Movie Name: ");
                m.Name = Console.ReadLine();

                Console.Write("Enter Genre: ");
                m.Genre = Console.ReadLine();

                Console.Write("Enter Year: ");
                m.Year = int.Parse(Console.ReadLine() ?? "0");

                movies.Add(m);
                SaveMovies();
                Console.WriteLine("Movie added and saved.");
            }

            private void ClearMovies()
            {
                movies.Clear();
                SaveMovies();
                Console.WriteLine("All movies cleared.");
            }

            private void LoadMovies()
            {
                if (!File.Exists(filePath)) return;

                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        movies.Add(Movie.FromFileString(line));
                }
            }

            private void SaveMovies()
            {
                List<string> lines = new List<string>();
                foreach (var movie in movies)
                {
                    lines.Add(movie.ToFileString());
                }
                File.WriteAllLines(filePath, lines);
            }
        }
    }


