namespace poo
{
    public class PessoaFísica
    {
        public string cpf;

        public string rg;

        public string nome;



        public string DarBoasVindas(string nomeUsuario){
            return "Olá "+nomeUsuario+"! Seja bem vindo(a) ao nosso sistema";
        }


        public bool ValidarCPF(string documento)
        {
            if(documento != ""){
                return true;
            }
            return false;
        }
    }
}