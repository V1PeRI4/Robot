using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLess
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bot bot = new Bot("Bot", 800, new byte[] { 0, 0, 0 });
            bot.printValues();

            Killer killer = new Killer("killer", 1200, new byte[] { 10, 0, 0 }, 100, Type.Hero);
            killer.printValues();
            killer.Lazer();

            /*Robot.print();

            Console.WriteLine(killer.Weight);

            Bot bot1 = new Bot();
            bot1.Weight = -100;


            List<Killer> robots = new List<Killer>();
            robots.Add(new Killer("Bob", 120, new byte[] { 0, 0, 10 }, 100));
            robots.Add(new Killer("Alex", 320, new byte[] { 2, 0, 10 }, 100));
            robots.Add(new Killer("John", 120, new byte[] { 10, 7, 10 }, 100));
            robots.Add(new Killer("Josh", 120, new byte[] { 5, 1, 10 }, 100));

            Robot newRobot = null;


            foreach (Killer obj in robots)
            {
                if (obj.Name == "John")
                {
                    newRobot = obj as Robot;
                }
            }


            Multiply(5.123f, 6.123f);

            Bot bot2 = new Bot();
            bot2.setValues()*/


            Book idiot = new Book();
            idiot.setValues("Идиот", "Fedor");
            idiot.printValues();
            

            Console.ReadLine();

        }

        public static void Multiply(int a, int b)
        {
            int res = a * b;
            Console.WriteLine("Result: " + res);
        }

        public static void Multiply(float a, float b)
        {
            float res = a * b;
            Console.WriteLine("Result: " + res);
        }

    }

}
