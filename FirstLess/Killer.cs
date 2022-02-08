using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLess
{
    enum Type
    {
        Enemy, Hero, Traitor
    }


    internal class Killer : Robot 
    {
        public int Health { get; set; }

        public Type type { get; set; }
            
        public Killer() { }

        public Killer(string name, int weight, byte[] coordinates, int health, Type type) : base (name, weight, coordinates)
        {
            this.Health = health;
            this.type = type;
        }

        public override void printValues()
        {
            Console.WriteLine(this.Name + " weight: " + this.Weight +Coordinates);
            Console.WriteLine("Health " + this.Health);

            if(this.type == Type.Hero)
            {
                Console.WriteLine("He is hero!");
            }
        }

        public void Lazer()
        {
            Console.WriteLine("Lazer activated");
            this.surname = "Doe";
        }


    }
}
