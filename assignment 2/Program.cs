using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero theflash = new SuperHero("The Arrow");
            theflash.Show();
            theflash.showpowers();
            theflash.Fight();
        }
    }
}
