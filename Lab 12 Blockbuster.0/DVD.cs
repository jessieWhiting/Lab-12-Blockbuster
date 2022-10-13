using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_Blockbuster._0
{
    class DVD : Movie
    {
        public DVD(string Title, Genre Category, int Runtime, string Scenes) : base(Title, Category, Runtime, Scenes)
        { }
        public override void Play()
        {
            Blockbuster bB = new Blockbuster();

            //If movie is in the list within Blockbuster, Print Title and Print SceneList
            Console.WriteLine($"Scene Selection: {Title}:\n");
            bB.PrintScenes(SceneList);
            bool playDVD = true;
            while (playDVD)
            {
                try
                {
                    int userSelect = int.Parse(Console.ReadLine());
                    //Prints a list of scenes from selected index point, forward.

                    if (userSelect > 0 && userSelect < SceneList.Count)
                    {
                        int currentTime = (Runtime / SceneList.Count) * (userSelect - 1);
                        Console.WriteLine($"Playing {Title} Start Scene: {userSelect}: {SceneList[userSelect]}.  \nPlaying from {currentTime} mins.\n");

                        for (int i = userSelect; i < SceneList.Count; i++)
                        {
                            Console.WriteLine($"{currentTime} mins: {SceneList[i]}\n");
                            currentTime += Runtime / SceneList.Count;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Scene Selection in: {Title}.  Select Scenes 1 - {SceneList.Count}.");
                        continue;
                    }
                }
                //Exception inserted to catch invalid input
                catch (Exception)
                {
                    Console.WriteLine($"Input 1 - {SceneList.Count} to continue");
                    continue;
                }
            }
        }
    }
}
