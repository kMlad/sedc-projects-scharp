using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Driver
    {
        public string Name { get; set; }
        public int Skill { get; set; }
        //skill is measured on a scale of 1-10

        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }
    }
}
