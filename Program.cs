using System;
using BiteBank.Funcionarios;
using BiteBank.Sistemas;

namespace BiteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor manoel = new Diretor("Manoel", 5000);
            manoel.Senha = "123Corinthians";
            GerenteDeConta micael = new GerenteDeConta("Micael", 4000);
            micael.Senha = "VaiTimao";
            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "Habilitado";

            Console.WriteLine(sistemaInterno.Logar(manoel, "123Corinthians"));
            Console.WriteLine(sistemaInterno.Logar(micael, "VaiTimao"));
            Console.WriteLine(sistemaInterno.Logar(parceiro, "NoToque"));
        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            Designer messias = new Designer("Messias", 3000);
            Diretor manoel = new Diretor("Manoel", 5000);
            Auxiliar maria = new Auxiliar("Maria", 2000);
            GerenteDeConta micael = new GerenteDeConta("Micael", 4000);

            gerenciadorBonificacao.Registrar(messias);
            gerenciadorBonificacao.Registrar(micael);
            gerenciadorBonificacao.Registrar(maria);
            gerenciadorBonificacao.Registrar(manoel);

            Console.WriteLine("Total de Bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
