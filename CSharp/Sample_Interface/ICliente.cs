namespace Sample_Interface
{
    public interface ICliente
    {
        string Versao { get; set; }
        void Teste();
        event EventHandler ValorChanged;
    }
}
