class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularPerimetro() => 2 * (Base + Altura);
}
