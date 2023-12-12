using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodType
{
    internal class FoodType
    {
        public string name;
        public int protein;
        public int carbs;
        public int fat;
        static int counter;

        public void setname(string name)
        {
            this.name = name;
        }

        public void setprotein(int protein)
        {
            this.protein = protein;
        }

        public void setcarbs(int carbs)
        {
            this.carbs = carbs;
        }

        public void setfat(int fat)
        {
            this.fat = fat;
        }

        public string getname()
        {
            return this.name;
        }

        public int getprotein()
        {
            return this.protein;
        }

        public int getcarbs()
        {
            return this.carbs;
        }

        public int getfat()
        {
            return this.fat;
        }

        public int getCounter()
        {
            return counter;
        }

        public override string ToString()
        {
            string ispis = name + " p - " + this.getprotein() + "%"
            + " c - " + this.getcarbs() + "%"
            + " f - " + this.getfat() + "%";

            return ispis;
        }

        public FoodType(string name, int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }

        private FoodType() { }
    }
}
