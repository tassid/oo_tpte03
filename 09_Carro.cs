class Carro
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }

    public double CalcularDesconto()
    {
        if (Ano < 2010)
        {
            return Preco * 0.1; // 10% de desconto
        }
        else
        {
            return Preco * 0.05; // 5% de desconto
        }
    }
}
