namespace Sample_Interface
{
    public class TesteTransacao : Transacao
    {
        public override double CalcularImposto() //sobrescreve o método
        {
            return GetValor() * 30;
        }
    }
}
