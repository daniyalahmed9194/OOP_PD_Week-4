using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Player
    {
        public string Name;
        public float Hp;
        public float MaxHp = 100;
        public float Energy;
        public float MaxEnergy = 50;
        public float Armor;
        public Stats SkillStatics;
        public Player (string Name, float Hp, float Energy, float Armor)
        {
            this.Name = Name;
            this.Hp = Hp;
            this.Energy = Energy;
            this.Armor = Armor;
        }
        public void LearnSkill(Stats SkillStatics)
        {
            this.SkillStatics = SkillStatics;
        }
        public string Attack(Player Opponent)
        {
            Opponent.Armor -= SkillStatics.Penetration;
            if(SkillStatics.Cost > Energy)
            {
                Console.WriteLine("Not Enough Energy");
            }
            else
            {
                Energy -= SkillStatics.Cost;
            }
            Opponent.Armor = SkillStatics.Damage * (100 - Opponent.Armor)/100;
            Opponent.Hp -= Opponent.Armor;
            return $"{Name} used a {SkillStatics.Name} {SkillStatics.Description}, agains {Opponent.Name} doing {SkillStatics.Damage} damage! {Opponent.Name} is at {Hp} health"; 
        }
    }
}
