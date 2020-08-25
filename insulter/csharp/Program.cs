using System;
using System.Collections.Generic;
using System.Linq;

namespace Insulter
{
    // We write C# code in classes.
    class Program
    {
        // All C# applications start in the "Main" method.
        static void Main(string[] args)
        {
            // We must specify the Type of the "names" variable.
            //  It is a "List" that can only contain "strings".
            List<string> insults = new List<string>()
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            // Print some output to the terminal (aka. "Console");
            Console.WriteLine("A few Insults");

            List<int> indexz = new List<int>();
            while (indexz.Count < 3);

            for (int i = 0; i < indexz.Count; i++)
            {
                int index = indexz[i];
                Console.WriteLine(insults[index]);
            }

            {
                Random candidate = new Random();
                //  I believe 0 is the starting point and 1 will be added in increments  
                randomCandidate = candidate.Next(0, insults.Count - 1);
                if (!indexz.Contains(randomCandidate))
                {
                    indexz.Add(randomCandidate);
                }
            }

        }
    }
}