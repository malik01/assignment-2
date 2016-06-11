using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{
    /**
   * this is the driver class of my program used to create new objects from the class hero
   * @class program
   * @method Main(string[]) args
   */
    class Program
    {
        /**the main method of the driver class
         * @method Main(string[]) args
         */ 
        static void Main(string[] args)
        {
            SuperHero theflash = new SuperHero("The Arrow"); // creating the name(object) superhero
            theflash.Show(); // the show method called from the hero class
            theflash.showpowers(); // show powers method called from the super hero class  
            theflash.Fight(); // fight method inherited from the hero class
        }
    }
}
