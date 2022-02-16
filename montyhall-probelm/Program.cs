using System;
using System.Diagnostics;
using System.Xml;

namespace montyhall
{
    class program
    {

        private static double change = 0;
        private static double DontChange = 0;
        private static double totalTry = 0;
        private static double taskcase = 0;
        public static void Main(string[] args)
        {
            taskcase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < taskcase; i++)
            {
                monty();
            }
            
            Console.WriteLine("Calculation done");
            Console.WriteLine("Total Try: " + totalTry);
            Console.WriteLine("Change: " + change);
            Console.WriteLine("Didn't Change: " + DontChange);

            double Persentage = change / taskcase;
            Persentage = Persentage * 100;
            Console.WriteLine("Total Percentage: " + Convert.ToString(Persentage) + "%");
            
        }

        public static void monty()
        {
            Random rnd = new Random();

            int door = rnd.Next(1, 4);

            int firstSel = rnd.Next(1, 4);

            if (firstSel == door)
            {
                totalTry += 1;
                DontChange += 1;

                double progress = totalTry / taskcase;
                progress = progress * 100;
                Console.WriteLine("didn't changed" + progress + "% Done");
            }

            else
            {
                totalTry += 1;
                change += 1;
                
                double prograss = totalTry / taskcase;
                prograss = prograss * 100;
                Console.WriteLine("changed" + prograss + "% Done");
            }
        }
    }
}