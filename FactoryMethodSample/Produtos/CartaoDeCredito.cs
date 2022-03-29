namespace FactoryMethodSample
{
    public abstract class CartaoDeCredito
    {
        public string Nome { get; }
        public DateTime Validade { get; }
        public string Bandeira { get; }
        public string? Numero { get; init; }
        public int CodigoSeguranca { get; }
        public int LimiteTotal { get; protected set; }
        public decimal LimiteDisponivel { get; protected set; }

        protected CartaoDeCredito(string nome, string bandeira, int limiteTotal)
        {
            Nome = nome;
            Validade = DateTime.Today.AddYears(5);
            Bandeira = bandeira;
            CodigoSeguranca = new Random().Next(100, 999);
            LimiteTotal = limiteTotal;
            LimiteDisponivel = limiteTotal;
        }

        public virtual void AtualizarLimiteTotal(int limiteTotal) { LimiteTotal = limiteTotal; }
        public virtual void AtualizarLimiteDisponivel(decimal valorGasto) { LimiteDisponivel -= valorGasto; }

        public abstract string GerarNumeroCartao();
        public abstract void Cashback();

        public override string ToString()
        {
            return $"Nome: {Nome}\n" +
                   $"Número: {Numero}\n" +
                   $"Bandeira: {Bandeira}\n" +
                   $"CVV: {CodigoSeguranca}\n" +
                   $"Limite Total: {LimiteTotal}\n" +
                   $"Limite Disponível: {LimiteDisponivel}\n" +
                   $"Validade: {Validade}";
        }

    }
}
