public class Reptil : Animal
{
    public Reptil(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie) { }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} está emitindo sons(ssSSSssSSS).");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} está andando.");
    }

    public void Rastejar()
    {
        Console.WriteLine($"{Nome} está rastejando.");
    }
}