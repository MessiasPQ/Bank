namespace BiteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string nome, double salario) : base(nome, salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }
    }
}