using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
/**
 * author Shahzaib Malik
 * student id 300852792 
 * Date created 5/3/2016
 * Date modified 6/3/2016
 * version 1.2 added final comments
 */
{
    /**
     * This class creates a hero who has certain values of strength,speed,health and
     * a userdefined name.This class also includes methods which determine in a 
     * random manner if the hero lands a hit on the bad guy and also how damaging 
     * the hit was. 
     * @class Hero
     * @field {string} _name 
     * 
     */
    public class Hero
    {
        // private instance variables
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;
        // using random number method to generate random numbers
        Random randomInt = new Random();
        /**
      * <summary>
      * This is a public property for the private _name field
      * </summary>
      * 
      * @property {string} Name
      */
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        /**
        * <summary>
        * This is a consructor that takes name as a parameter and passes 
        * it to the _name private instance variable
        * </summary>
        * 
        * @constructor hero
        * @param {string} name
        */

        public Hero(string name)
        {

            this.Name = name;

        }
        /**
         * <summary>
         * This method uses the randomly created _hitattempt method if the created hero hits only then the _hitdamage method is called
         * </summary>
         * 
         * @method Fight
         * @returns {void}
         */
        public void Fight()
        {

            if (_hitAttempt() == true)
            {
                Console.WriteLine("\n {0} Landed a hit with a damage of {1}", Name, _hitDamage() + "\n");
            }
            else
            {
                Console.WriteLine("\n {0} Missed" , Name);
            }
        }
        /**
         * <summary>
         * This method calls the _generateAbilities Method
         * </summary>
         * 
         * @method Show
         * @returns {void}
         */
        public void Show()
        {
            _generateAbilities();
        }
        /**
         * <summary>
         * This method outputs randomly generated values which are then assigned 
         * to the private instance variables _spped,_strength,_health
         * <summary>
         * @method _generateAbilities
         * @return void
         */
        private void _generateAbilities()
        {
            _strength = randomInt.Next(1, 100);
            _speed = randomInt.Next(1, 100);
            _health = randomInt.Next(1, 100);
            Console.WriteLine("\n" + " Your hero named as {0} has been created with the following abilities \n Strength: {1}  Speed: {2}  Health: {3}", Name, _strength, _speed, _health + "\n");
        }
        /**
         * <summary>
         * This method is used to determine if the created hero hits which is a boolean variable
         * hitting chance is of a 20%
         * <summary>
         * @method _hitattempt
         * @return attempt
         */
        public bool _hitAttempt()
        {
            bool attempt = false;
            int attp;
            attp = randomInt.Next(4);
            if (attp == 0)
            {
                attempt = true;
            }
            return attempt;
        }
        /**
         * <summary>
         * This method outputs randomly generated values between 1 to 6 and are then assigned 
         * to a variable. Then the random value is multipled by the hero's strength which is
         * the private _strength instance variable
         * <summary>
         * @method _generateAbilities
         * @return void
         */
        private int _hitDamage()
        {
            int multiplier;
            int damage;
            multiplier = randomInt.Next(1, 6);
            damage = multiplier * _strength;
            return damage;
        }
    }
}
