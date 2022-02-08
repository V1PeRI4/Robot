using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLess
{
    internal struct Book
    {
        private string title, avtor, intro;

        private short pages;


        public void setValues(string title, string avtor)
        {
            this.title = title;
            this.avtor = avtor;
        }

        public void printValues()
        {
            Console.WriteLine(this.avtor + " написал книгу: " + this.title + ">>");
        }
    }
}
