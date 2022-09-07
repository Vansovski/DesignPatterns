namespace StrategyCSharp
{
    public class FaturaBlackFriday70: IFaturaStrategy
    {
        //70% de desconto
        public double GetPreco(double preco) => preco*0.3;
    }
}