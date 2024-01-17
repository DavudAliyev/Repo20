using System;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_16
{
    internal class ChinaCity:City
    {
        public ChinaCity(string name, int population):base(name,population) 
        {
            if(population>10000)
            {
                this.Population = population;

            }



        }
        ChinaCity[] population1 = new ChinaCity[0];
        public void Add(City city)
        {
            Array.Resize(ref population1, population1.Length + 1);
            population1[population1.Length - 1] = city;
        }

    }
}
