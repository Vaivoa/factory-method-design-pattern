namespace FactoryMethodSample
{
    public interface ICartaoFactory
    {
        // Factory Method
        public CartaoDeCredito GerarCartao(string nome, int limite);
    }
}
