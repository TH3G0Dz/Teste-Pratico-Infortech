using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico_ConsumoCombustivel.Carros
{
    using System;
    using System.Collections.Generic;

    class Persistencia
    {
        private List<ConsumoCombustivel> carros = new List<ConsumoCombustivel>();

        public void Incluir(double capacidade, string portador)
        {
            ConsumoCombustivel novoCarro = new ConsumoCombustivel(capacidade, portador);
            carros.Add(novoCarro);
            Console.WriteLine("Novo carro adicionado: {0} - {1}", novoCarro.NumeroSerie, novoCarro.Portador);
        }

        public void Alterar(int numeroSerie, double capacidade, string portador)
        {
            ConsumoCombustivel carro = carros.Find(c => c.NumeroSerie == numeroSerie);
            if (carro != null)
            {
                carro.Capacidade = capacidade;
                carro.Portador = portador;
                Console.WriteLine("Carro alterado com sucesso: {0} - {1}", carro.NumeroSerie, carro.Portador);
            }
            else
            {
                Console.WriteLine("Erro: carro não encontrado");
            }
        }

        public void Excluir(int numeroSerie)
        {
            ConsumoCombustivel carro = carros.Find(c => c.NumeroSerie == numeroSerie);
            if (carro != null)
            {
                carros.Remove(carro);
                Console.WriteLine("Carro excluído com sucesso: {0} - {1}", carro.NumeroSerie, carro.Portador);
            }
            else
            {
                Console.WriteLine("Erro: carro não encontrado");
            }
        }

        public void MostrarCarros()
        {
            Console.WriteLine("Lista de carros:");
            foreach (ConsumoCombustivel carro in carros)
            {
                Console.WriteLine("{0} - {1} - {2}", carro.NumeroSerie, carro.Portador, carro.Capacidade);
            }
        }

        public ConsumoCombustivel ObterCarro(int numeroSerie)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return carros.Find(c => c.NumeroSerie == numeroSerie);
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }
    }
}
