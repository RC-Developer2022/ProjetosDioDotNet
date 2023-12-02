using DIO.Domain.Enum;

namespace DIO.Domain.Entities;

public class Conta
{
    private string Nome { get; set; }
    private Decimal Saldo { get; set; }
    private Decimal Credito { get; set; }
    private TipoConta TipoConta { get; set; }

    public Conta(string nome, Decimal saldo, Decimal credito, TipoConta tipoConta)
    {
        Nome = nome;
        Saldo = saldo;
        Credito = credito;
        TipoConta = tipoConta; 
    }

    public bool Sacar(Decimal valorSaque) 
    {
        if(Saldo - valorSaque < (Credito -1))
        {
            Console.WriteLine("Saldo insuficiente!");
            return false;
        }

        Saldo -= valorSaque;
        Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
        return true;
    }

    public void Depositar(Decimal valorDeposito) 
    {
        Saldo += valorDeposito;
        Console.WriteLine($"Saldo atual da conta de {Nome} é {Saldo}");
    }

    public void Transferencia(Decimal valorTransferir, Conta contaDestino)
    {
        if(Sacar(valorTransferir))
        {
            contaDestino.Depositar(valorTransferir);
        }
    }

    public override string ToString()
    {
        string retorno = string.Empty;
        retorno += "Tipo Conta " + TipoConta + "\n";
        retorno += "Nome" + Nome + "\n";
        retorno += "Saldo" + Saldo + "\n";
        retorno += "Credito" + Credito + "\n";
        return retorno;
    }

}
