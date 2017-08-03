using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalePick
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Music Vomber v1.13" + "\n"+
                              "Press any key to continue, or press ESCAPE to quit.");
            string[] musicNotes = new string[] { "C ", "C# ", "D ", "D# ", "E ", "F ", "F# ", "G ", "G# ", "A ", "A# ", "B " };
            string[] musicScale = new string[] { "Major", "Minor", "Dorian", "Phrygian", "Lydian", "Mixolydian", "Locrian" };
            int[] timeDivider = new int[] { 2, 4, 8, 16 };
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                int rndNote = random.Next(0, 11);
                int rndScale = random.Next(0, 6);
                int rndBPM = random.Next(32, 300);
                int rndTS = random.Next(3, 31);
                int rndTD = random.Next(0, 3);
                Console.WriteLine("Key: " + musicNotes[rndNote] + "\n"+ 
                                  "Scale: " + musicScale[rndScale] + "\n"+
                                  "BPM: " + rndBPM + "\n"+
                                  "Time sig.: " + rndTS + "/" + timeDivider[rndTD]);
                Console.WriteLine("Press any key to continue, or press ESCAPE to quit.");
            }
        }
    }
}