class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public bool EhMaiorDeIdade() => Idade > 18;
}
