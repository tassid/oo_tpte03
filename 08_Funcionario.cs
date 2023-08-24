class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }
    public double HorasTrabalhadas { get; set; }

    public double CalcularSalarioTotal() => Salario * HorasTrabalhadas;
}
