using System;
using System.Text;
using System.Xml.Linq;
using Coord;
using Monster;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Random rand = new Random();
			s
			Coord cooord = new Coord(5,5);
			Monster mod = new Monster();
			

            int[] list = new int[1000];
            double sum = 0;

            for (int i = 0; i < list.Length; i++)
            {
                list[i] = rand.Next(100, 901);

                sum += list[i];
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
			
			Console.ReadLine();

            Console.WriteLine("\nAvarage = "  + sum / list.Length);
        }
    }
}
