using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Jogo.Src.Entities
{
    public class Ninja : Hero
    {
            public Ninja(string Name, int Level, int HP, int MP, string HeroType)
            {
                this.Name = Name;
                this.Level = Level;
                this.MP = HP;
                this.MP = MP;
                this.HeroType = HeroType;
            }

            public override string Attack()
            {
                return this.Name + " " + "Atirou Com a Kunai";
            }
            public string Attack(int Bonus)
            {

                if (Bonus > 6) 
                {
                    return this.Name + " " + "Atirou uma Super Rajada de Kunai  Com Bonus de " + Bonus;
                }
                    else{
                    return this.Name + " " + "Atirou uma Kunai fraca com bonus de " + Bonus;
                    }
            }
        }
    }
