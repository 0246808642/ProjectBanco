using System.Globalization;

namespace Banco
{
    public class ContaBancaria
    {
        public string _nome;
        public int _conta;
        public double Valor { get; private set; }

        public ContaBancaria(string nome, int conta, double valor)
        {
            _nome = nome;
            _conta = conta;
           MetDeposito(valor);
        }
        public ContaBancaria(string nome, int conta)
        {
            _nome = nome;
            _conta = conta;
        }
        public int Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value != null && value > 0)
                    _conta = value;
            }
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    _nome = value;
                }
            }
        }

        public double  MetDeposito(double deposito)
        {
            Valor = deposito + Valor;

            return Valor;
        }

        public void MetSaque(double saque)
        {
           Valor = Valor - saque - 5;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + Nome + ", Saldo: $" + Valor.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
