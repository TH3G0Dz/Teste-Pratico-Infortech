using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico_ConsumoCombustivel
{
    using System;

    class ConsumoCombustivel
    {
        private static int contador = 1;

        public int NumeroSerie { get; private set; }
        public double Capacidade { get; set; }
        public string Portador { get; set; }
        private double Litros { get; set; }

        public ConsumoCombustivel(double capacidade, string portador)
        {
            NumeroSerie = contador++;
            Capacidade = capacidade;
            Portador = portador;
            Litros = 0;
        }

        public void Abastecer(double litros)
        {
            if (Litros == Capacidade)
            {
                Console.WriteLine("Tanque cheio. Não é possível abastecer mais.");
            }
            else if (Litros + litros > Capacidade)
            {
                Console.WriteLine("Erro: capacidade menor que a quantia informada.");
               
                Console.WriteLine("Informe uma quantidade válida para abastecer até a capacidade máxima:");

                while (Litros < Capacidade)
                {
                    double quantidadeRestante = Capacidade - Litros;
                    Console.WriteLine("Quantidade máxima que pode ser adicionada: {0} litros.", quantidadeRestante);
                    Console.WriteLine("Digite a quantidade de litros para abastecer:");
                    double litrosAdicionais = double.Parse(Console.ReadLine());
                    if (Litros + litrosAdicionais > Capacidade)
                    {
                        Console.WriteLine("Erro: capacidade menor que a quantia informada.");
                    }
                    else
                    {
                        Litros += litrosAdicionais;
                        Console.WriteLine("Abastecido com sucesso. Litros disponíveis: {0}", Litros);
                        break;
                    }
                }
            }
            else
            {
                Litros += litros;
                Console.WriteLine("Abastecido com sucesso. Litros disponíveis: {0}", Litros);
            }
        }



        public void Rodar(double km)
        {
            double litrosNecessarios = km;
            if (Litros >= litrosNecessarios)
            {
                Litros -= litrosNecessarios;
                Console.WriteLine("Rodou {0} Lts. Litros disponíveis: {1}", km, Litros);
            }
            else
            {
                Console.WriteLine("Erro: combustível insuficiente");
            }
        }

        public void Contar()
        {
            Console.WriteLine("Litros disponíveis: {0}", Litros);
        }
    }

}