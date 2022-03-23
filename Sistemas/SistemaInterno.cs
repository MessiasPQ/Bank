using BiteBank.Funcionarios;

namespace BiteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}