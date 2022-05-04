using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    internal class Cat
    {
        public string Name;
        public int Age;

        private int Happiness=50;
        public Cat(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        void Paly()
        {
            Happiness = Happiness + 1;
            if(Happiness > 100)
            {
                Happiness = 100;
            }
        }
    }
}
