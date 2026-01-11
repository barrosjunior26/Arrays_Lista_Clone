//Variáveis globais
string[] listaDeCompras;
string[] copia;
int quantidade, opcao;

do
{
    Console.Write("\n\nDigite 1 para novo cadastro ou 0 para sair do sistema: ");
    opcao = int.Parse(Console.ReadLine());

    while (opcao != 1 && opcao != 0)
    {
        Console.WriteLine("\n\nOpção inválida!");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("\n\nDigite 1 para novo cadastro ou 0 para sair do sistema: ");
        opcao = int.Parse(Console.ReadLine());
    }

    //Menu do sistema
    switch (opcao)
    {
        case 1:
            //Solicitação de quantos itens o usuário deseja adicionar a lista
            Console.Write("Informe quantos itens você deseja adicionar a lista: ");
            quantidade = int.Parse(Console.ReadLine());

            //Instancionado o array de string e criando um novo array cujo o tamanho dele será o valor da variável quantidade
            listaDeCompras = new string[quantidade];

            //Laço de repetição para adicionar cada item a lista
            for (int i = 0; i < listaDeCompras.Length; i++)
            {
                Console.Write($"Informe o {i + 1}º item da lista: ");
                listaDeCompras[i] = Console.ReadLine();
            }

            //Copiando os itens do array padrão para outro array
            copia = (string[])listaDeCompras.Clone();


            //Limpar as informações anteriores e exibe os itens copiados
            Console.Clear();
            Console.WriteLine("\n\n===== Estes foram os itens cadastrados =====\n");

            //Exibindo os itens copiados do array usando o foreach
            foreach (var itens in copia)
            {
                Console.WriteLine(itens);
            }
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("\n\nSaindo do sistema em...");
            Thread.Sleep(2000);
            Console.Clear();
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Environment.Exit(0);
            break;
    }

    Console.Write("\n\nDigite 1 para repetir ou 0 para sair: ");
    opcao = int.Parse(Console.ReadLine());

    while (opcao != 1 && opcao != 0)
    {
        Console.WriteLine("\n\nOpção inválida!");
        Thread.Sleep(1000);
        Console.Clear();
        Console.Write("\n\nDigite 1 para repetir ou 0 para sair: ");
        opcao = int.Parse(Console.ReadLine());

    }
} while (opcao != 0);

Console.Clear();
Console.WriteLine("\n\nSaindo do sistema em...");
Thread.Sleep(2000);
Console.Clear();
for (int i = 5; i > 0; i--)
{
    Console.WriteLine(i);
    Thread.Sleep(1000);
    Console.Clear();
}
Environment.Exit(0);