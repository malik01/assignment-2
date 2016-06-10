using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment_2
{
    class SuperHero : Hero
    {
        private string[] _superpower;
        Random random = new Random();

        public string[] Superpower
        {
            get { return this._superpower; }
            set { this._superpower = value; }
        }

        private void _generatepowers()
        {
            string[] superPower = new string[] { "superstrenght", "superspeed", "bodyarmor", "flight", "fire genration", "weather control" };
            for (int g = 0; g < 3; g++)
            {
                int rndm = random.Next(0, 6);
                string s = superPower[rndm];
                Console.WriteLine(" powers generated " + s);
            }
        }
            public void showpowers()
        {
            _generatepowers();
        }
        public SuperHero(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
