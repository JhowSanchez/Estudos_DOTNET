using System.Data;

namespace EstudoC_.Models
{
    public class Professor : Pessoa
    {
        //SEALED PARA SELAR UMA CLASSE OU METODO !
        public override void TESTE()
        {
            throw new NotImplementedException();
        }
    }
}
