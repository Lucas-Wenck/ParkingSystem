List<string?> listaCarros = [];
bool menu = true;
decimal precoInicial;
decimal precoHora;
int horas;

Console.WriteLine("Boas vindas ao sistema de estacionamento.");

Console.WriteLine("Favor informar o preço base: ");
while (!decimal.TryParse(Console.ReadLine(), out precoInicial))
{
    Console.WriteLine("Input invalido, favor inserir um valor numerico.");
}

Console.WriteLine("Favor informar o preço por hora");
while (!decimal.TryParse(Console.ReadLine(), out precoHora))
{
    Console.WriteLine("Input invalido, favor inserir um valor valido.");
}

do
{
    Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
    string? opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":

            Console.WriteLine("Digite a placa do veículo: ");
            string? novoVeículo = Console.ReadLine();
            listaCarros.Add(novoVeículo.ToUpper());
            Console.WriteLine("\nDigite qualquer tecla para continuar.");
            Console.ReadLine();
            break;

        case "2":

            Console.WriteLine("Informe a placa do veículo a ser removido: ");
            string? placa = Console.ReadLine();
            if (listaCarros.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                while (!int.TryParse(Console.ReadLine(), out horas))
                {
                    Console.WriteLine("Favor informar as horas de maneira inteira com valor numerico.");
                }
                decimal total = precoInicial + precoHora * horas;
                listaCarros.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {total}");
                Console.WriteLine("\nDigite qualquer tecla para continuar.");
                Console.ReadLine();
                break;
            }

            else
            {
                Console.WriteLine("O veículo informado não existe.");
                Console.WriteLine("\nDigite qualquer tecla para continuar.");
                Console.ReadLine();
                break;
            }

        case "3":

            foreach (string? veículo in listaCarros)
            {
                Console.WriteLine(veículo);
            }
            Console.WriteLine("\nDigite qualquer tecla para continuar.");
            Console.ReadLine();
            break;

        case "4":

            menu = false;
            Console.WriteLine("\nDigite qualquer tecla para continuar.");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Informe uma opção válida.");
            Console.WriteLine("\nDigite qualquer tecla para continuar.");
            Console.ReadLine();
            break;
    }

} while (menu);
