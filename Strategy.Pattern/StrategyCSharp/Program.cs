using StrategyCSharp;

internal class Program
{
    private static void Main(string[] args)
    {

        //Estrátegias de pagamento 
        var precoNormal = new FaturaNormal();
        var precoBlackFriday = new FaturaBlackFriday();
        var precoBlackFriday70 = new FaturaBlackFriday70();

        //Fatura do Cliente 
        var fatura = new FaturaCliente(precoNormal);

        //Compra 1º produto 
        fatura.Add(100, 5);

        fatura.SubTotal();

        //Produto com valor de blackfriday 
        fatura.Strategy = precoBlackFriday;

        //Compra 2º produto 
        fatura.Add(100, 5);

        fatura.SubTotal();

        //Produto com valor de blackfriday com 70% 
        fatura.Strategy = precoBlackFriday70;

        //Compra 3º produto 
        fatura.Add(100, 5);

        fatura.SubTotal();

        //Finalizando Fatura
        fatura.Total();
    }
}
