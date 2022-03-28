namespace FactoryMethodSample
{
    public class CartaoMasterInfiniteFactory : ICartaoFactory
    {
        public CartaoDeCredito GerarCartao(string nome, int limite)
        {
            return new CartaoMasterInfinite(nome, limite);
        }
    }
}
