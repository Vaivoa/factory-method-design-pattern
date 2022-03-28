namespace FactoryMethodSample
{
    public class CartaoVisaInfiniteFactory : ICartaoFactory
    {
        public CartaoDeCredito GerarCartao(string nome, int limite)
        {
            return new CartaoVisaInfinite(nome, limite);
        }
    }
}
