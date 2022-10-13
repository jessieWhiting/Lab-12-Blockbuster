using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Blockbuster._0
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Movie TheConjuring = (new DVD("The Conjuring", Genre.Horror, 112, " Ghost, Hand Clap, Annabelle, Exorcism, Valak\nEnd Movie"));
        public Movie PulpFiction = (new DVD("Pulp Fiction", Genre.Action, 174, " Vince Vega and Marsellus Wallace's Wife, The Bonnie Situation, The Gold Watch, The Diner, The Diner Prologue\nEnd Movie"));
        public Movie TheShawshankRedemption = (new DVD("The Shawshank Redemption", Genre.Drama, 142, "Arrival at Shawshank, Andy Escapes, Andy and Red Reunited, Suds on The Roof, Brooks Gets Out\nEnd Movie"));
        public Movie TrickRTreat = (new DVD("Trick 'r Treat", Genre.Horror, 82, " New Halloween Decoration, Hiding Bodies, Vixens and Victims, Zombies in the lake, Zombie Children\nEnd Movie"));
        public Movie Idiocracy = new VHS("Idiocracy", Genre.Comedy, 84, " State of the Union, Television Brainwashing, Joe Wakes up Five Years Later, Actually, 500 Years Later, Not your Average Joe\nEnd Movie");
        public Movie Gladiator = new VHS("Gladiator", Genre.Drama, 300, " He is strong, He is mighty, He is beauty, He is grace, He is Gladiator\nEnd Movie");
        public Movie MeetTheParents = new VHS("Meet the Parents", Genre.Romance, 108, " I have parents, I also have parents, They should meet, What's the worst that could happen, See, it's fine\nEnd Movie");
        public Movie JurrassicPark = new VHS("Jurrasic Park", Genre.Action, 127, " Let's make a dinosaur island, Let's open it up to the public, Well that didn't go as expected, Time to fly home, Be back soon\nEnd Movie");

        public Blockbuster()
        {
            Movies.Add(TheConjuring);
            Movies.Add(PulpFiction);
            Movies.Add(TheShawshankRedemption);
            Movies.Add(TrickRTreat);
            Movies.Add(Idiocracy);
            Movies.Add(Gladiator);
            Movies.Add(MeetTheParents);
            Movies.Add(JurrassicPark);
            

        }
        public virtual void PrintScenes(List<string> SceneList)
        {

            for (int i = 0; i < SceneList.Count; i++)
            {
                Console.Write($"{i}: ");
                
                Console.WriteLine(SceneList[i]);
            }
        }
        public List<string> GetScenes(string Scenes)
        {
            List<string> SceneList = Scenes.Split(',').ToList();
            return SceneList;
        }
        public void PrintMovies()
        {

           
            Movies.OrderBy(Movie => Movie.Title).ToList();
            for (int i = 0; i < Movies.Count; i++)
            {                            
              Console.WriteLine($"{i}: {Movies.OrderBy(Movie => Movie.Title).ToList()[i].Title }");              
            }
        }
        public Movie CheckOut()
        {
            Console.WriteLine("==================================================================================================================");
            Console.WriteLine("Select a Movie: ");
            Console.WriteLine("==================================================================================================================");
            PrintMovies();
            bool rent = true;
            Movie m;
            while (rent)
            {
                try
                {
                    int userInput = int.Parse(Console.ReadLine());

                    if (userInput > -1 && userInput < Movies.Count)
                    {
                        m = Movies.OrderBy(Movie => Movie.Title).ToList()[userInput];
                        Console.WriteLine($"Checking out " + m);
                        return m;

                    }
                    else
                    {
                        Console.WriteLine($"That is not a valid movie.  Please select a movie between 1 and {Movies.Count - 1}.");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Please input a number from 1 to {Movies.Count - 1} to continue");
                    continue;
                }

            }

            return CheckOut();
        }
        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToUpper() == "Y")
            {
                return true;
            }
            else if (response.ToUpper() == "N")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input.  Please input \"Y\" or \"N\".\n");
                return ContinueLoop(question);
            }
        }
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}
