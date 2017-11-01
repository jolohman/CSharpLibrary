using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Player
    {
        //Method
        
        public void Attack(int damage)
        {
            Console.WriteLine($"Attacked for {damage}!");
        }

        public void Attack(int damage, string weapon)
        {
            Console.WriteLine($"Attaked with {weapon} for {damage}!");
        }

        public void Attack(int damage, string weapon, int times)
        {
            Console.WriteLine($"Attaked with {weapon} for {damage} damage {times} times! Dealing a total damage of {damage*times}!");
        }

        //My First Attempt FAILED
        //Contructors
        //public Player(int damage, string weapon, int timesHit)
        //{
        //    this.Damage = damage;
        //    this.weapon = weapon;
        //    this.timesHit = timesHit;
        //}

        //public Player(int damage, string weapon)
        //{
        //    this.damage = damage;
        //    this.weapon = weapon;
        //}

        //public Player(int damage)
        //{
        //    this.damage = damage;
        //}

        //Properties
        //public string Damage { get; set; }
        //public string Weapon { get; set; }
        //public string TimesHit { get; set; }
    }
}
