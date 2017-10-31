﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._111_v2OOP_Game
{
    class Player : Character
    {
        //Consturtors
        public Player(string name, Specialization role)
        {
            this.Name = name;
            this.Role = role;
            this.IsAlive = true;
            this.Health = 100;
            this.Level = 1;
            this.AttackPower = 10;
            this.CritChance = 0.10;
        }

        //Properties
        public Specialization Role { get; set; }
        public string Name { get; set; }

        //Enums
        public enum Specialization
        {
            HorseNamge,
            TrollCat,
            KnightTemlator,
            Demogorg,
            Vampire,
            BovineFrog
        }
        public enum Action
        {
            Attack,
            Run,
            Hide
        }
    }
}
