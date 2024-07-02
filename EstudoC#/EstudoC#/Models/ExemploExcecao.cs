namespace EstudoC_.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção Tratada "+ex.Message);//StackTrace = Rastro do caminho feito para chegar ate aqui no erro
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {

            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma Exceção!");
        }
    }

    
}
