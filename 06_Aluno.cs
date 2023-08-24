class Aluno
{
    public string Nome { get; set; }
    public List<double> Notas { get; set; }

    public double CalcularMedia() => Notas.Count > 0 ? Notas.Average() : 0;
}
