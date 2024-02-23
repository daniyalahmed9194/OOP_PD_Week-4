using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Stats
    {
        public string Name;
        public float Damage;
        public string Description;
        public float Penetration;
        public float Cost;
        public float Heal;
        public Stats(string Name, float Damage, string Description, float Penetration, float Cost, float Heal)
        {
            this.Name = Name;
            this.Damage = Damage;
            this.Cost = Cost;
            this.Heal = Heal;
            this.Description = Description;
            this.Penetration = Penetration;

        }
    }
}
