

public class ContaBancaria
{

    public int _numConta;
    public int _agencia;
    public string _titular;
    public double _saldo;


    

    public void SetSaldo(double saldo)
    {
        if (saldo < 0)
        {
            _saldo = saldo;
        }else
            Console.WriteLine("Valor inválido...");
    }

    public double GetSaldo()
    {
        return _saldo;
    }

   public void SetConta(int conta)
   {
        _numConta = conta;
   }

   public int GetConta()
    {
        return _numConta;
    }

    public void SetAgencia(int agencia)
    {
        _agencia = agencia;
    }

    public int GetAgencia()
    {
        return _agencia;
    }

    public void SetTitular(string titular)
    {
        _titular = titular;
    }

    public string GetTitular()
    {
        return _titular;
    }

    public void SetDeposito( double deposito)
    {
        if (deposito < 0)
        {
            throw new Exception("Valor invalido");
        }
        else
            _saldo += deposito;
    }

    public void SetSaque(double saque)
    {
        if(saque < 0)
        {
            throw new Exception("Saque inválido");
        }
        else
            _saldo -= saque;
    }

}