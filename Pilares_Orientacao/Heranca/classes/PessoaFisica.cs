namespace Heranca.classes
{
    public class PessoaFisica : Pessoa
    {
        public string cnpj;
        public string inscriçaoEstadual;

        private bool VerificarCnoj(string documento){
            if(documento != ""){
                return true;
            }

            return false;
        }
    }
}