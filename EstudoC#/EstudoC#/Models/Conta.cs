namespace EstudoC_.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        protected Conta(decimal saldo)
        {
            this.saldo = saldo;
        }

        public abstract void Creditar(decimal saldo);
    }
}
