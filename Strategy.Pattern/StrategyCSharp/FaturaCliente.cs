namespace StrategyCSharp
{
    public class FaturaCliente
    {
        //Lista de preços dos produtos 
        private IList<double> produtos;

        //Possibilidade de alterar a estrategia de preço dentro da fatura 
        public IFaturaStrategy Strategy { get; set; }

        //Construtor com injeção da estrategia de fatura a ser utilizada 
        public FaturaCliente(IFaturaStrategy strategy)
        {
            this.Strategy = strategy;
            this.produtos = new List<double>();
        }

        //Entada de um novo produto
        public void Add(double preco, int qtd)
        {
            //Adiciona o valor do produto de acordo com a estrategia escolhida
            this.produtos.Add(this.Strategy.GetPreco(preco * qtd));
        }

        //Total a ser pago 
        public void Total()
        {
            SubTotal();

            //Libera lista do preço dos prdutos comprados 
            this.produtos.Clear();
        }

        //SubTotal  a ser pago 
        public void SubTotal()
        {
            double sum = 0;
            foreach (var produto in this.produtos)
            {
                sum = sum + produto;
            }

            System.Console.WriteLine($"Total da Fatura: {sum}");

        }
    }
}