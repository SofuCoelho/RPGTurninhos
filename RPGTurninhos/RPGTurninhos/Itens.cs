using System;
using System.Collections.Generic;
using System.Text;

namespace RPGTurninhos
{
    public class Itens
    {
        string[,] equipamentos = new string[21, 6];
        public void cadastrarItem()
        {
            equipamentos[0, 0] = "ITEM";
            equipamentos[0, 1] = "TIPO";
            equipamentos[0, 2] = "VALOR";
            equipamentos[0, 3] = "DANO";
            equipamentos[0, 4] = "DEFESA";
            equipamentos[0, 5] = "SLOTS";

            equipamentos[1, 0] = "Adaga";
            equipamentos[1, 1] = "Arma";
            equipamentos[1, 2] = "10";
            equipamentos[1, 3] = "2";
            equipamentos[1, 4] = "0";
            equipamentos[1, 5] = "1";

            equipamentos[2, 0] = "colete";
            equipamentos[2, 1] = "armadura";
            equipamentos[2, 2] = "7";
            equipamentos[2, 3] = "0";
            equipamentos[2, 4] = "10";
            equipamentos[2, 5] = "1";

            equipamentos[3, 0] = "espada";
            equipamentos[3, 1] = "arma";
            equipamentos[3, 2] = "7";
            equipamentos[3, 3] = "6";
            equipamentos[3, 4] = "0";
            equipamentos[3, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "capacete";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "5";
            equipamentos[4, 3] = "0";
            equipamentos[4, 4] = "7";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "Calça";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "7";
            equipamentos[4, 3] = "0";
            equipamentos[4, 4] = "10";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "Bota";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "4";
            equipamentos[4, 3] = "0";
            equipamentos[4, 4] = "6";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "arco";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";

            equipamentos[4, 0] = "escudo";
            equipamentos[4, 1] = "armadura";
            equipamentos[4, 2] = "3";
            equipamentos[4, 3] = "1";
            equipamentos[4, 4] = "8";
            equipamentos[4, 5] = "1";




            listarItens();
        }

        public void listarItens()
        {
            Console.Clear();
            Console.WriteLine();
        }
    }
}
