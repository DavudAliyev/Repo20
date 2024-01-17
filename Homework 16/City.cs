using System;
using System.Collections.Generic;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework_16
{
    internal class City
    {
        public string Name;
        public int Population;

        public City(string name, int population) 
        {
            if (Name.Length > 3 && Name.Length < 20)
            {
                Name = name;
            }

            if(Population>0)
            {
                Population = population;
            }

           
        }


        

    }
}
