namespace FactoryMethodSample
{
    public class Program
    {
        static void Main()
        {
            var nome = ReceberInputNome();
            var limite = ReceberInputLimite();
            var tipoDeCartao = ReceberInputTipoCartao().ToLower();
            var cartao = GerarNovoCartao(tipoDeCartao, nome, limite);

            Console.WriteLine("\nOs dados do seu novo cartão são: ");
            Console.WriteLine(cartao.ToString());

            Console.WriteLine($"\nSimulando compra...");
            cartao.Cashback();
        }

        public static CartaoDeCredito GerarNovoCartao(string tipoCartao, string nome, int limite)
        {
            return tipoCartao switch
            {
                "visa infinite" => new CartaoVisaInfiniteFactory().GerarCartao(nome, limite),
                "master infinite" => new CartaoMasterInfiniteFactory().GerarCartao(nome, limite),
                "visa platinum" => new CartaoVisaPlatinumFactory().GerarCartao(nome, limite),
                "master platinum" => new CartaoMasterPlatinumFactory().GerarCartao(nome, limite),
                _ => throw new Exception("Deu ruim."),
            };
        }

        public static string ReceberInputNome()
        {
            Console.WriteLine("Que nome gostaria no seu cartão?: ");
            var nome = Console.ReadLine();
            return nome;
        }

        public static int ReceberInputLimite()
        {
            int limite = -1;

            while (limite < 0 || limite > 5000)
            {
                Console.WriteLine("Escolha um limite para seu cartão entre 0 e 5000: ");
                var limiteInput = Console.ReadLine();
                limite = Convert.ToInt32(limiteInput);
            }

            Console.WriteLine("");
            return limite;
        }

        public static string ReceberInputTipoCartao()
        {
            string[] arrCartoes = { "VISA INFINITE", "VISA PLATINUM", "MASTER INFINITE", "MASTER PLATINUM" };
            string tipoCartao = "";

            while (!arrCartoes.Contains(tipoCartao))
            {
                Array.ForEach(arrCartoes, Console.WriteLine);
                Console.WriteLine("\nEscolha o tipo de cartão que você deseja: ");
                tipoCartao = Console.ReadLine().ToUpper();
            }

            return tipoCartao;
        }
    }
}