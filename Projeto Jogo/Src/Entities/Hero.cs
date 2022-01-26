using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Jogo.Src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, int HP, int MP, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.MP = HP;
            this.MP = MP;
            this.HeroType = HeroType;
        }
        public Hero(){

        }


        public string Name;
        public int Level;
        public int HP;
        public int MP;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HP + " " + this.MP + " " + this.HeroType;
        }

            public virtual string Attack(){
                return this.Name + " " + "Atacou com sua espada";
            }

        }


    }
