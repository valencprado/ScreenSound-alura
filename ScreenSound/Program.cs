// Screen Sound
string mensagem = "Boas vindas ao Screen Sound!\n\n";
 // List<string> bandas = new List<string>();

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

bandas.Add("Linkin Park", new List<int>());
bandas.Add("Limp Bizkit", new List<int>());
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
            AvaliarBanda();
            break;
        case 4:
            MostrarMediaDaBanda();
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
    bandas.Add(banda, new List<int>());
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
    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"{banda}");
    }
    Console.Write("\nDigite uma tecla para retornar ao menu\n");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();

}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda!");
    // digitar banda
    Console.Write("Digite a banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    // verificar se a banda existe
    if(bandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite a nota da banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"Obrigada por ter dado a nota {nota} para a banda {nomeDaBanda}! Registro com sucesso.");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    }

    else
    {
        Console.WriteLine($"A  banda {nomeDaBanda} não foi encontrada!");
        Console.WriteLine("Digite alguma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    // avaliar a banda
}

void MostrarMediaDaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Média de avaliação de uma banda");
    Console.Write("Digite o nome da banda que gostaria de ver a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(bandas.ContainsKey(nomeDaBanda))
    {
        double mediaDaBanda = bandas[nomeDaBanda].Average();
        Console.WriteLine($"A média de notas da banda {nomeDaBanda} é: {mediaDaBanda}");
        Thread.Sleep(5000);
        Console.Clear();
        ExibirMenu();
    } 
    else
    {
        Console.WriteLine("Banda inválida! Verifique se digitou certinho e tente novamente :)");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
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