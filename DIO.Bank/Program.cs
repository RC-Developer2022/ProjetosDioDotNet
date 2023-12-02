using DIO.Domain.Entities;
using DIO.Domain.Enum;

Conta conta = new Conta("Rafael" , 200 , 0 , TipoConta.PessoaFisica);
string opcaoUsuario = ObterOpcaoUsuario();
while(opcaoUsuario.ToUpper() != "X")
{
    switch(opcaoUsuario)
    {
        case"1":
                break;
    }
}


static string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("SICOOB a seu dispor!!!");
    Console.WriteLine("Informe a opção desejada:");

    Console.WriteLine("1 - Listar contas");
    Console.WriteLine("2 - Inserir nova conta");
    Console.WriteLine("3 - Transferir");
    Console.WriteLine("4 - Sacar");
    Console.WriteLine("5 - Depositar");
    Console.WriteLine("6 - Limpar tela");
    Console.WriteLine("X - Sair");
    Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;
}