namespace BiteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string nome, double salario) : base(nome, salario)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}