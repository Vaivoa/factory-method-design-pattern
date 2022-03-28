namespace FactoryMethodSample
{
    public class CartaoVisaPlatinumFactory : ICartaoFactory
    {
        public CartaoDeCredito GerarCartao(string nome, int limite)
        {
            return new CartaoVisaPlatinum(nome, limite);
        }
    }
}
