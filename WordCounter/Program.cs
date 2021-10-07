using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu sõna on lauses "Hello World!"


            string helloW = "Hello World!";

            /*while
            int i = 0;
            int wordcounter = 1;

            while (i < helloW.Length)
            {
                if(helloW[i] == ' ')
                {
                    wordcounter++;
                }

                i++;
            }*/
            int wordcounter = 1;
            for(int i = 0; i < helloW.Length; i++)
            {
                if (helloW[i] == ' ')
                {
                    wordcounter++;
                }
            }

            Console.WriteLine($"Lauses on {helloW} on {wordcounter} sõna");
        }
    }
}
