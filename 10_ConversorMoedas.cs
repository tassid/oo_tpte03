class ConversorDeMoedas
{
    private const double TaxaDolarParaReal = 5.24;
    private const double TaxaEuroParaReal = 6.17;

    public static double DeRealParaDolar(double valor) => valor / TaxaDolarParaReal;
    public static double DeDolarParaReal(double valor) => valor * TaxaDolarParaReal;
    public static double DeRealParaEuro(double valor) => valor / TaxaEuroParaReal;
    public static double DeEuroParaReal(double valor) => valor * TaxaEuroParaReal;
}
