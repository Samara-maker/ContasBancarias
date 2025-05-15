
public class ContaEmpresa: ContaBancaria
{
    public double _anuidade;
    public double _limiteEmprestimo;
    public double _totalEmprestimo;


    public ContaEmpresa()
    {

    }
    public ContaEmpresa(int _numConta, int _agencia, string _titular, double _saldo, double _anuidade, double _limiteEmprestimo, double _totalEmprestimo)
    {
        SetConta(_numConta);
        SetAgencia(_agencia);
        SetTitular(_titular);
        SetSaldo(_saldo);
        SetAnuidade(_anuidade);
        SetEmprestimo(_limiteEmprestimo);
    }



    public void SetAnuidade(double anuidade)
    {
        _anuidade = anuidade;
    }
    public double GetAnuidade()
    {
        return _anuidade;
    }

    public void SetEmprestimo(double valorEmprestimo)
    {
        if (valorEmprestimo <= 0)
        {
            throw new Exception("Valor invalido");

        }else if(_limiteEmprestimo > valorEmprestimo)
        {
            _limiteEmprestimo -= valorEmprestimo;
            _totalEmprestimo = valorEmprestimo;
            _saldo = valorEmprestimo;
            Console.WriteLine("Emprestimo realizado com sucesso...");
        }
        else
        {
            Console.WriteLine("Emprestimo negado");
        }


    }


    public void SetSacar(double valorSacar)
    {
        double saque = 0;
        double taxa = 0;

        if(valorSacar <= 0)
        {
            Console.WriteLine("Valor invalido...");
        }else if(saque > 5000)
        {
            taxa = 5;
        }
        double valorTotal = valorSacar - taxa;
    }
}
