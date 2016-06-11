using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * author Shahzaib Malik
 * student id 300852792 
 * Date created 6/10/2016
 * Date modified 6/10/2016
 * version 1.0..1 finished things starting comments
 */

namespace assignment_2
{
    /**
     * This class creates a super hero who has certain super powers such as super strength, 
     * superspeed, body armor, flight,firegeneration and even weather control
     * a userdefined name.This class also includes methods which determine in a 
     * random manner the generate abilities of the super hero. And also inherits from the class Hero  
     * @class SuperHero
     * @field {string} _name 
     * 
     */
    class SuperHero : Hero
    {
        // private string instance variable
        private string[] _superpower;
        // random number generator method 
        Random random = new Random();
      /**
      * <summary>
      * This is a public property for the private _superpower field
      * </summary>
      * 
      * @property {strin} Name
      */
        public string[] Superpower
        {
            get { return this._superpower; }
            set { this._superpower = value; }
        }

        /**
 * <summary>
 * This method outputs randomly generated values which are then assigned 
 * to the private instance variable _superpower
 * <summary>
 * @method _generateRandomPowers()
 * @return void
 */
        private void _generateRandomPowers()
        {
            int[] dummyPower = new int[] { 0,1,2,3,4,5,6,7,8,9,10,11 }; // dummy values from comparision
            string[] superPower = new string[] { "Super Strenght", "Super Speed", "Body Armor", "Flight", "Fire Genration", "Weather Control" };
            for (int g = 3; g < 6; g++) // loop creating only three super powers
            {
                
                int rndm = random.Next(0, 6);
                string s = superPower[rndm];
                // if statement compairing the string values of dummy and superpower if the values are same the next value random value is chosen
                if (superPower[0] != dummyPower[0].ToString() && superPower[1] != dummyPower[1].ToString() && superPower[2] != dummyPower[2].ToString() && superPower[3] != dummyPower[3].ToString() && superPower[4] != dummyPower[4].ToString())
                {
                    Console.WriteLine(" power generated for {0}  {1} ", Name, s);
                }
            }   
        }
        /**
        * <summary>
        * This method uses the randomly created _generateRandomPowers method and displlays it to the console
        * </summary>
        * 
        * @method showPowers()
        * @returns {void}
        */
        public void showpowers()
        {
            _generateRandomPowers();
        }
        /**
      * <summary>
      * This is a consructor that takes name as a parameter and passes 
      * it to the _name private instance variable inherited from the 
      * base class Hero
      * </summary>
      * 
      * @constructor Superhero
      * @param {string} name
      */
        public SuperHero(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
