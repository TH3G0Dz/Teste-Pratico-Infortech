using TestePratico_ConsumoCombustivel;
using TestePratico_ConsumoCombustivel.Carros;

class Principal
{
    static void Main(string[] args)
    {
        Persistencia persistencia = new Persistencia();

        // cria três carros de portadores quaisquer diferentes
        persistencia.Incluir(50, "Vitor Hugo");
        persistencia.Incluir(55, "Luiz Eduardo");
        persistencia.Incluir(40, "Gilmar Dantas");

        Console.WriteLine("Abastecendo os carros:");
        Console.Write("Quantos litros para o carro de " + persistencia.ObterCarro(1).Portador + "? ");
        double litrosJoao = double.Parse(Console.ReadLine());
        persistencia.ObterCarro(1).Abastecer(litrosJoao);

        Console.Write("Quantos litros para o carro de " + persistencia.ObterCarro(2).Portador + "? ");
        double litrosMaria = double.Parse(Console.ReadLine());
        persistencia.ObterCarro(2).Abastecer(litrosMaria);

        Console.Write("Quantos litros para o carro de " + persistencia.ObterCarro(3).Portador + "? ");
        double litrosPedro = double.Parse(Console.ReadLine());
        persistencia.ObterCarro(3).Abastecer(litrosPedro);

        // Disparando todos os carros
        Console.WriteLine("\nDisparando os carros:");

        Console.Write("Quantos litros o carro do " + persistencia.ObterCarro(1).Portador + " deve rodar? ");
        persistencia.ObterCarro(1).Rodar(double.Parse(Console.ReadLine()));

        Console.Write("Quantos litros o carro do " + persistencia.ObterCarro(2).Portador + " deve rodar? ");
        persistencia.ObterCarro(2).Rodar(double.Parse(Console.ReadLine()));

        Console.Write("Quantos litros o carro do " + persistencia.ObterCarro(3).Portador + " deve rodar? ");
        persistencia.ObterCarro(3).Rodar(double.Parse(Console.ReadLine()));

        while (true)
        {
            Console.WriteLine("\nO que deseja fazer?");
            Console.WriteLine("1 - Abastecer um carro");
            Console.WriteLine("2 - Rodar um carro");
            Console.WriteLine("3 - Adicionar um carro");
            Console.WriteLine("4 - Alterar um carro");
            Console.WriteLine("5 - Excluir um carro");
            Console.WriteLine("6 - Listar carros");
            Console.WriteLine("7 - Sair");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("Digite o número de série do carro: ");
                int numeroSerie = int.Parse(Console.ReadLine());
                ConsumoCombustivel carro = persistencia.ObterCarro(numeroSerie);

                if (carro != null)
                {
                    Console.Write("Digite a quantidade de litros para abastecer: ");
                    double litros = double.Parse(Console.ReadLine());
                    carro.Abastecer(litros);
                }
                else
                {
                    Console.WriteLine("Carro não encontrado");
                }
            }
            else if (opcao == 2)
            {
                Console.Write("Digite o número de série do carro: ");
                int numeroSerie = int.Parse(Console.ReadLine());
                ConsumoCombustivel carro = persistencia.ObterCarro(numeroSerie);

                if (carro != null)
                {
                    Console.Write("Digite a quantidade de km para rodar: ");
                    double km = double.Parse(Console.ReadLine());
                    carro.Rodar(km);
                }
                else
                {
                    Console.WriteLine("Carro não encontrado");
                }
            }
            else if (opcao == 3)
            {
                Console.Write("Digite a capacidade do tanque: ");
                double capacidade = double.Parse(Console.ReadLine());
                Console.Write("Digite o nome do portador: ");
                string portador = Console.ReadLine();
                persistencia.Incluir(capacidade, portador);
            }
            else if (opcao == 4)
            {
                Console.Write("Digite o número de série do carro: ");
                int numeroSerie = int.Parse(Console.ReadLine());
                ConsumoCombustivel carro = persistencia.ObterCarro(numeroSerie);

                if (carro != null)
                {
                    Console.Write("Digite a nova capacidade do tanque: ");
                    double capacidade = double.Parse(Console.ReadLine());
                    Console.Write("Digite o novo nome do portador: ");
                    string portador = Console.ReadLine();
                    persistencia.Alterar(numeroSerie, capacidade, portador);
                }
                else
                {
                    Console.WriteLine("Carro não encontrado");
                }
            }
            else if (opcao == 5)
            {
                Console.Write("Digite o número de série do carro: ");
                int numeroSerie = int.Parse(Console.ReadLine());
                persistencia.Excluir(numeroSerie);
            }
            else if (opcao == 6)
            {
                persistencia.MostrarCarros();
            }
            else if (opcao == 7)
            {
                Console.WriteLine("Saindo...");
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
        }
    }
}
