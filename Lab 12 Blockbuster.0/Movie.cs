using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Blockbuster._0
{
    //Create an abstract class called movie.
    //Parent Class
    abstract class Movie
    {
        //create properties for program.
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        //first recognizes scenes. The second creates a list.
        public string Scenes { get; set; }
        public List<string> SceneList => GetScenes(Scenes);


        public Movie(string Title, Genre Category, int Runtime, string Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            this.Scenes = Scenes;
        }

        //Prints information from movie list to string.
        public override string ToString()
        {
            return $"Title: {Title}\nCategory: {Category}\nRuntime: {Runtime} Mins";
        }
        public virtual void PrintScenes(List<string> SceneList)
        {
            for (int i = 0; i < SceneList.Count; i++)
            {
                Console.Write($"{i}: ");
                Console.WriteLine(SceneList[i]);
            }
        }
        //Make virtual. Both Play() overrides cycle
        public virtual void Play()   
        { 
        
        }
        //Used for List in blockbuster. Lists and Splits the scenes in order.
        public List<string> GetScenes(string Scenes)
        { 
            List<string> SceneList = Scenes.Split(',').ToList();
            return SceneList;
        }
    }

    //creates a category for movie types. Strung into main property Catergory
    public enum Genre
    {
        Horror,
        Comedy,
        Action,
        Romance,
        Drama
    }
}
