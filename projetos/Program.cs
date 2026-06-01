int opcao = 0;
double saldo = 0.0;
double deposito = 0.0;
double saque = 0.0;
string[] extrato = new string[100];
int qtdMovimentacao = 0;
do
{
    Console.WriteLine("======BANCO======");
    Console.WriteLine("ESCOLHA UMA OPÇÃO");
    Console.WriteLine("[1] VER SALDO");
    Console.WriteLine("[2] DEPOSITAR");
    Console.WriteLine("[3] SACAR");
    Console.WriteLine("[4] EXTRATO");
    Console.WriteLine("[5] SAIR");
    Console.WriteLine("=================");
    opcao = int.Parse(Console.ReadLine());
    Console.Clear();
    if (opcao == 1)
    {
        Console.WriteLine($"SALDO: R${saldo:F2}");
    }
    else if (opcao == 2)
    {
        Console.Write("QUANTO DESEJA DEPOSITAR: R$");
        do
        {
            deposito = double.Parse(Console.ReadLine());
            if (deposito <= 0)
            {
                Console.WriteLine("O deposito não pode ser menor ou igual 0");
                Console.WriteLine("DIGITE UM VALOR VALIDO: ");
            }
        } while (deposito <= 0);
        saldo += deposito;
        extrato[qtdMovimentacao] = $"Deposito = R${deposito:f2} | Saldo Total = R${saldo:f2}";
        qtdMovimentacao++;
        Console.Clear();
        Console.WriteLine("DEPÓSITO REALIZADO COM SUCESSO!");
        Console.WriteLine($"NOVO SALDO: R${saldo:f2}");
    }
    else if (opcao == 3)
    {
        Console.Write("QUANTO DESEJA SACAR: R$");
        do
        {
            saque = double.Parse(Console.ReadLine());
            if (saque <= 0|| saque > saldo)
            {
                Console.WriteLine("O valor de saque não pode ser menor ou igual a 0");
                Console.WriteLine("DIGITE UM VALOR VALIDO: ");
            }
        } while (saque <= 0 || saque > saldo);
        saldo -= saque;
        extrato[qtdMovimentacao] = $"Saque: R${saque:f2} | Saldo Total = R${saldo:f2}";
        qtdMovimentacao++;
        Console.Clear();
        Console.WriteLine("SAQUE REALIZADO COM SUCESSO!");
        Console.WriteLine($"NOVO SALDO: R${saldo:f2}");
    }
    else if (opcao == 4)
    {
        for(int i = 0; i < qtdMovimentacao; i++)
        {
            Console.WriteLine(extrato[i]);
        }
    }
    else if (opcao == 5)
    {
        Console.WriteLine("ENCERRANDO ATENDIMENTO..");

    }
    else
    {
        Console.WriteLine("OPÇÃO INVÁLIDA. TENTE NOVAMENTE");
    }
    Console.WriteLine("Pressione qualquer botão para continuar..");
    Console.ReadKey();
    Console.Clear();
} while (opcao != 5);