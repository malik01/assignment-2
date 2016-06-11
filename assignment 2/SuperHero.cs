﻿using System;
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
    class SuperHero : Hero
    {
        private string[] _superpower;
        Random random = new Random();

        public string[] Superpower
        {
            get { return this._superpower; }
            set { this._superpower = value; }
        }
        

        private void _generateRandomPowers()
        {
            int[] dummyPower = new int[] { 0,1,2,3,4,5,6,7,8,9,10,11 };
            string[] superPower = new string[] { "Super Strenght", "Super Speed", "Body Armor", "Flight", "Fire Genration", "Weather Control" };
            for (int g = 3; g < 6; g++)
            {
                
                int rndm = random.Next(0, 6);
                string s = superPower[rndm];
                if (superPower[0] != dummyPower[0].ToString() && superPower[1] != dummyPower[1].ToString() && superPower[2] != dummyPower[2].ToString() && superPower[3] != dummyPower[3].ToString() && superPower[4] != dummyPower[4].ToString())
                {
                    Console.WriteLine(" power generated for {0}  {1} ", Name, s);
                }
            }   
        }
            public void showpowers()
        {
            _generateRandomPowers();
        }
        public SuperHero(string name) : base(name)
        {
            this.Name = name;
        }
    }
}
