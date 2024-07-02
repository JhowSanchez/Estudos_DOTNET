namespace EstudoC_.Models
{
    public class ContaCorrente : Conta
    {

        public ContaCorrente(decimal saldo) : base(saldo)
        {
            
        }
        public override void Creditar(decimal saldo)
        {
            if (this.saldo - saldo >= 0)
                this.saldo -= saldo;
        }
    }
}
