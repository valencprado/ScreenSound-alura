// Screen Sound
string mensagem = "Boas vindas ao Screen Sound!\n\n";
 List<string> bandas = new List<string>();

void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagem);

}

void ExibirMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("Digite 1 para registrar banda");
    Console.WriteLine("Digite 2 para listar bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir média de avaliação de uma banda");
    Console.WriteLine("Digite -1 para sair.");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoNumber = int.Parse(opcaoEscolhida);

    switch (opcaoNumber)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção: avaliar banda");
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção: exibir média da banda");
            break;
        case -1:
            Console.WriteLine("Você escolheu sair. Tchauzinho!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;

    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string banda = Console.ReadLine()!;
    bandas.Add(banda);
    Console.WriteLine($"Banda registrada: {banda}");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();

}

void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas:");
    /*
    for(int i = 0; i < bandas.Count; i++)
    {
        Console.WriteLine($"{i + 1}:{bandas[i]}");
    }
    */
    foreach (string banda in bandas)
    {
        Console.WriteLine($"{banda}");
    }
    Console.Write("\nDigite uma tecla para retornar ao menu\n");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}

void ExibirTituloDaOpcao(string titulo)
{
    int letrasLentgh = titulo.Length;
    string asteriscos = String.Empty.PadLeft(letrasLentgh, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
ExibirMenu();