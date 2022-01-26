using System;
using Projeto_Jogo.Src.Entities;

namespace dotnet___poo
{

    class program
    {

        static void Main(string[] args)
        {
            // Hero arus = new Hero("Arus", 42, 469, 72, "Knigth");
            // Hero Wedge = new Hero("Wedge", 42, 292, 89, "Ninja");
            // Hero Jennica = new Hero("Jennica", 42, 325, 474,"Whit Wizard");
            // Hero Topapa = new Hero("Topapa", 42, 106, 611, "Black Wizard");

            string jogador1 = "";
            string jogador2 = "";

            Console.WriteLine(RetornaPersonagem());

            Console.WriteLine("\n Escolha Seu Heroi");
            jogador1 = Console.ReadLine();
            Console.WriteLine("\n Escolha Seu Heroi");
            jogador2 = Console.ReadLine();

            RealizaAcaoPersonagem(jogador1.ToUpper());
            RealizaAcaoPersonagem(jogador2.ToUpper());
        }
        private static string RetornaPersonagem()
        {
            string espadachim = "A - EspadaChim - Arus";
            string ninja = "B - Ninja - Wedge";
            string magoBranco = "C - Mago Branco = Jennica";
            string magoNegro = "D - Mago Negro = Topapa";
            return "\n" + espadachim + "\n" + ninja + "\n" + magoBranco + "\n" + magoNegro;
        }
        private static void RealizaAcaoPersonagem( string jogador){
            switch (jogador)
            {
                case "A":
                    knight espadachim = new knight("Arus", 42, 469, 72, "Knigth");
                    Console.WriteLine(espadachim.Attack(9));
                    break;
                case "B":
                    Ninja ninja = new Ninja("Wedge", 42, 292, 89, "Ninja");
                    Console.WriteLine(ninja.Attack(7));
                    break;
                case "C":
                    Wizard magoBranco = new Wizard("Jennica", 42, 325, 474, "Whit Wizard");
                    Console.WriteLine(magoBranco.Attack(12));
                    break;
                case "D":
                    BlackWizard magoNegro = new BlackWizard("Topapa", 42, 106, 611, "Black Wizard");
                    Console.WriteLine(magoNegro.Attack(15));
                    break;
                default: break;
            }
        }
    }

}