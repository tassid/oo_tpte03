class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }

    public void ImprimirDados()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Altura: {Altura}");
    }
}
