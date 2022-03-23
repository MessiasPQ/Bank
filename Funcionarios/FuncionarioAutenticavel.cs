using BiteBank.Sistemas;

namespace BiteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public FuncionarioAutenticavel(string nome, double salario) : base(nome, salario) { }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}