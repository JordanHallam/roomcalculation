using System;

namespace roomcalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string answer;
            Console.WriteLine("Do you want to measure a room?");
            answer = Console.ReadLine();
            while (answer == "yes")
            {
                Console.WriteLine("What is the length of the room?");
                string length = Console.ReadLine();
               
                Console.WriteLine("What is the width of the room?");
                string width = Console.ReadLine();
                
                Console.WriteLine("What is the height of the room?");
                string height = Console.ReadLine();
                
                float numlength = float.Parse(length);
                float numwidth = float.Parse(width);
                float numheight = float.Parse(height);
               
                float area = (numlength * numwidth);
                float perimiter = ((2* numlength) + (2*numwidth));
                float volume = (numlength * numwidth * numheight);
                float surface = (2 * (numheight * numlength)) + (2 * (numheight * numwidth)) + (2 * (numlength * numwidth));
                
                Console.WriteLine("Perimiter: " + perimiter);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Volume: " + volume);
                Console.WriteLine("Surface Area: " + surface);
                Console.WriteLine("Would you like to measure another room?");
                answer = Console.ReadLine();
            }
        }
    }
}
