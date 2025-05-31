    public class Zelador : Funcionario, ICuidador
    {
        public Zelador(string nome, int idade)
            : base(nome, idade, "Zelador") { }

        public override void Trabalhar()
        {
            Console.WriteLine($"{Nome} está limpando habitats e alimentando animais.");
        }

        public void AlimentarAnimal(Animal animal)
        {
            Console.WriteLine($"Zelador {Nome} alimentou o animal {animal.Nome} com sucesso.");
        }

        public void CuidarHabitat(Animal animal)
        {
            Console.WriteLine($"{Nome} está cuidando do habitat do animal {animal.Nome}.");
        }
    }