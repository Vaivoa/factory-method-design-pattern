namespace FactoryMethodSample
{
    public class CartaoMasterPlatinumFactory : ICartaoFactory
    {
        public CartaoDeCredito GerarCartao(string nome, int limite)
        {
            return new CartaoMasterPlatinum(nome, limite);
        }
    }
}
