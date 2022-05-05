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

        public void Paly()
        {
            Happiness = Happiness + 1;
            if(Happiness > 100)
                Happiness = 100;
        }
        public void Eat()
        {
            Happiness = Happiness + 20;
            if(Happiness > 100)
                Happiness=100;


        }
        public string Express()
        {
            string message = "";
            if (Happiness >= 80)
                message = "I am very happy.";
            else if (Happiness >= 60)
                message = "I am happy.";
            else if (Happiness >= 40)
                message = "I am just that.";
        }
    }
}
