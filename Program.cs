using System;
using poo;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFísica pf = new PessoaFísica();

            pf.cpf = "000.000.000-00";

            pf.nome = "Ruan";

            Console.WriteLine( pf.DarBoasVindas(pf.nome) );

            Console.WriteLine( pf.ValidarCPF(pf.cpf) ); 
        }
    }
}
