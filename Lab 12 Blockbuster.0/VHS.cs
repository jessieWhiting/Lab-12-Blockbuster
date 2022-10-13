using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Blockbuster._0
{
    class VHS : Movie
    {
        public VHS(string Title, Genre Category, int Runtime, string Scenes) : base(Title, Category, Runtime, Scenes) { }

        public int CurrentTime { get; set; } = 0;
        public override void Play()
        {
            //Prints movie with random scene times. Movie time / The amount of scenes.
            int sceneDivide = Runtime / SceneList.Count;

            for (int i = 0; i < SceneList.Count; i++)
            {
                Console.WriteLine($"{CurrentTime} mins: {SceneList[i]}\n");
                CurrentTime += sceneDivide;
            }
            Rewind();

        }
        //Prompts user to rewind video and resets the runtime to 0.
        public void Rewind()
        {

            Console.WriteLine("==================================================================================================================");
            bool rewind = ContinueLoop("Rewind VHS to beginning?");
            Console.WriteLine("==================================================================================================================");
            if (rewind == true)
            {
                CurrentTime = 0;
                Console.WriteLine("Tape Rewinding: Current play time reset to 0.");
            }


        }
        //Used to verify input from 
        public static bool ContinueLoop(string question)
        {
            string response = GetInput(question);
            if (response.ToLower() == "y")
            {
                return true;
            }
            else if (response.ToLower() == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter \"y\" or \"n\".\n");
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
