
namespace BiteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();

    }
}