public abstract class Funcionario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, int idade, string cargo)
    {
        Nome = nome;
        Idade = idade;
        Cargo = cargo;
    }

    public abstract void Trabalhar();

    public string Info()
    {
        return $"Nome: {Nome}\nIdade: {Idade} anos\nCargo: {Cargo}";
    }
}