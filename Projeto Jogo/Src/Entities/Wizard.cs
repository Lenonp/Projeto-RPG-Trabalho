using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Jogo.Src.Entities
{
    public class Wizard : Hero
    {
            public Wizard(string Name, int Level, int HP, int MP, string HeroType){
            this.Name = Name;
            this.Level = Level;
            this.MP = HP;
            this.MP = MP;
            this.HeroType = HeroType;
        
        }


         public override string Attack(){
                return this.Name + " " + "Lançou Magia";

         }
        public string Attack(int Bonus){

            if (Bonus > 6){
                return this.Name + " " + "Lançou Super Ultra Magia Com Bonus de " + Bonus;
            }else{
                return this.Name + " " + "Lançou  uma magia com força fraca com bonus de " + Bonus;
            }

            
        }


         
    }
}