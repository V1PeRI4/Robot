using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLess
{
    abstract class Robot : IRun, IJump
    {
        private static int count;

        protected string surname;

        private string name;

        private int weight;

        private byte[] coordinates;

        public string Name
        {
            get { return name; }
            private set { }
        }

        public int Weight { 
            get => weight; 
            set {
                if (value < 1)
                    this.weight = 1;
                else 
                    this.Weight = value;
            }         
        }

        public byte[] Coordinates
        {
            get { return coordinates; }
            private set { }
        }

        public int Width { get; set; }
        public float speed { get; set; }
        public float y { get ; set ; }

        public Robot(string name, int weight, byte[] coordinates) 
        {
            this.setValues(name, weight, coordinates);
            count++;
        }

        public Robot() {
            count++;
        }

        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;

        }

        public void setValues(string name)
        {
            this.name = name;
        }

        public void setValues(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public abstract void printValues();
        

        public static void print()
        {
            Console.WriteLine("Счетчик " + count);

        }

        public void RobotRun()
        {
            Console.WriteLine("Robot is running");
        }

        public void Jump()
        {
            Console.WriteLine("Robot is jumping");
        }
    }
}
