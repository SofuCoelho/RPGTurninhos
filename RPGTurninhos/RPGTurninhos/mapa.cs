using System;
using System.Collections.Generic;
using System.Text;

namespace RPGTurninhos
{
    class Mapa
    {
        string viagem;
        string local;
        int jogadaPc;
        Random numero = new Random();

        public void cidadeCentral()
        {
            Console.WriteLine("você esta na cidade central");
            Console.WriteLine("você pode viajar para a Cidade na floresta, para o Porto, para o Deserto sem fim ou para as Minas Esquecidas");
            Console.WriteLine("você quer viajar para algum desses lugares? (s/n)");
            viagem = Console.ReadLine();
            if (viagem == "s")
            {

                Console.WriteLine("para que local deseja ir?");
                Console.WriteLine("[1] Cidade na floresta");
                Console.WriteLine("[2] Porto");
                Console.WriteLine("[3] Deserto sem fim");
                Console.WriteLine("[4] Minas esquecidas");
                local = Console.ReadLine();

                if (local == "1")
                {
                    CidadeNaFloresta();
                }
                else if (local == "2")
                {
                    Porto();
                }
                else if (local == "3")
                {
                    DesertoSemFim();
                }
                else if (local == "4")
                {
                    MinasEsquecidas();
                }
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Você permaneceu aqui");
            }

            Console.ReadKey();
        }

        public void CidadeNaFloresta()
        {
            Console.WriteLine("Você chegou a Cidade na Floresta,  deseja continuar aqui? (s/n)");
            viagem = Console.ReadLine();
            if (viagem == "n")
            {
                Console.WriteLine("para que local deseja ir?");
                Console.WriteLine("[1] Cidade Central");
                Console.WriteLine("[2] Minas esquecidas");
                local = Console.ReadLine();

                if (local == "1")
                {
                    cidadeCentral();

                }
                else if (local == "2")
                {
                    MinasEsquecidas();
                }
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Você permaneceu aqui");
            }
            Console.ReadKey();
        }

        public void MinasEsquecidas()
        {
            Console.WriteLine("Você chegou as Minas Esquecidas");
            Console.ReadKey();

            jogadaPc = numero.Next(1, 5);

            if ((jogadaPc == 1) ||
                (jogadaPc == 2) ||
                (jogadaPc == 3))
            {
                Console.WriteLine("você foi atacado por uma aranha gigante");
            }
            else
            {
                Console.WriteLine("você não foi atacado");
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Deseja continuar aqui? (s/n)");
            viagem = Console.ReadLine();
            if (viagem == "n")
            {
                Console.WriteLine("para que local deseja ir?");
                Console.WriteLine("[1] Cidade Central");
                Console.WriteLine("[2] Cidade na Floresta");
                local = Console.ReadLine();

                if (local == "1")
                {
                    cidadeCentral();

                }
                else if (local == "2")
                {
                    CidadeNaFloresta();
                }
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Você permaneceu aqui");
            }
            

        }
        public void Porto()
        {
            Console.WriteLine("Você chegou ao Porto");
            Console.ReadKey();

            jogadaPc = numero.Next(1, 3);

            if (jogadaPc == 1)
            {
                Console.WriteLine("você foi atacado por um bandido");
            }
            else
            {
                Console.WriteLine("você não foi atacado");
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Deseja continuar aqui? (s/n)");
            viagem = Console.ReadLine();
            if (viagem == "n")
            {
                Console.WriteLine("para que local deseja ir?");
                Console.WriteLine("[1] Cidade Central");
                Console.WriteLine("[2] Ilha Solitaria");
                local = Console.ReadLine();

                if (local == "1")
                {
                    cidadeCentral();

                }
                else if (local == "2")
                {
                    IlhaSolitaria();
                }
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Você permaneceu aqui");
            }
            Console.ReadKey();


        }
        public void IlhaSolitaria()
        {
            Console.WriteLine("Você chegou a Ilha Solitaria");
            Console.ReadKey();

            jogadaPc = numero.Next(1, 3);

            if (jogadaPc == 1)
            {
                Console.WriteLine("você foi atacado por uma Quara");
            }
            else
            {
                Console.WriteLine("você não foi atacado");
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Deseja continuar aqui? (s/n)");
            viagem = Console.ReadLine();
            if (viagem == "n")
            {
                Console.WriteLine("Você pode voltar para o Porto, quer ir para lá? (s/n)");
                local = Console.ReadLine();

                if (local == "s")
                {
                    Porto();


                }
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Você permaneceu aqui");
            }
            Console.ReadKey();

        }
        public void DesertoSemFim()
        {
            Console.WriteLine("Você chegou ao Deserto sem Fim");

            Console.ReadKey(); 

            jogadaPc = numero.Next(1, 5);

            if (jogadaPc == 1)
            {
                Console.WriteLine("você foi atacado por um escorpião");
            }
            else
            {
                Console.WriteLine("você não foi atacado");
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Deseja continuar aqui? (s/n)");
            viagem = Console.ReadLine();
            if (viagem == "n")
            {
                Console.WriteLine("Você pode voltar para a Cidade Central, quer ir para lá? (s/n)");
                local = Console.ReadLine();

                if (local == "s")
                {
                    cidadeCentral();

                }
                else
                {
                    Console.WriteLine("Você permaneceu aqui");
                    Console.ReadKey();
                }
               


            }
            else
            {
                Console.WriteLine("Você permaneceu aqui");
                Console.ReadKey();
            }
            
        }
    }
}
