using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLess
{
    internal class Bot : Robot, IRun
    {
        public Bot() { }

        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)
        { }

        public override void printValues()
        {
            Console.WriteLine(this.Name + " weight: " + this.Weight + " Coordinates: ");
            foreach(byte el in this.Coordinates)
            {
                Console.WriteLine(el);
            }
        }

    }
}
