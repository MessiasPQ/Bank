using BiteBank.Funcionarios;

namespace BiteBank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}