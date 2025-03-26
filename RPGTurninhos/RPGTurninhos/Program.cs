using System;

namespace RPGTurninhos
{
    class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            Console.WriteLine("                          RPG DO TERMINAL                         ");
            Console.WriteLine("");
            Console.WriteLine("[1] - Novo Jogo");
            Console.WriteLine("[2] - Sair");
            escolha = Console.ReadLine();
            if (escolha == "1")
            {
                Personagem Char = new Personagem();
                Char.criacaoPersonagem();


                Itens Equips = new Itens();
                Equips.cadastrarItem();


            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}