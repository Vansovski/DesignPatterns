namespace StrategyCSharp
{
    public class FaturaBlackFriday : IFaturaStrategy
    {
        //50% de desconto
        public double GetPreco(double preco) => preco*0.5;
    }
}