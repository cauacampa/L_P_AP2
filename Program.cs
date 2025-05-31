List<Animal> animais = new List<Animal>();
List<Funcionario> funcionarios = new List<Funcionario>();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== Sistema Zoológico ===");
    Console.WriteLine("1. Cadastrar Animal");
    Console.WriteLine("2. Cadastrar Funcionário");
    Console.WriteLine("3. Interação Animal-Funcionário");
    Console.WriteLine("4. Sair");
    Console.Write("Escolha uma opção: ");
    string opc = Console.ReadLine();

    if (opc == "1")
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Animal");
        Console.WriteLine("Tipos: 1 - Mamífero, 2 - Ave, 3 - Réptil");
        Console.Write("Tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int.TryParse(Console.ReadLine(), out int idade);

        Console.Write("Peso (kg): ");
        double.TryParse(Console.ReadLine(), out double peso);

        Console.Write("Espécie: ");
        string especie = Console.ReadLine();

        Animal animal = null;
        if (tipo == "1")
            animal = new Mamifero(nome, idade, peso, especie);
        else if (tipo == "2")
            animal = new Ave(nome, idade, peso, especie);
        else if (tipo == "3")
            animal = new Reptil(nome, idade, peso, especie);

        if (animal != null)
        {
            animais.Add(animal);
            Console.WriteLine($"Animal cadastrado com sucesso: {animal.Info()}");
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
        }

        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }
    else if (opc == "2")
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Funcionário");
        Console.WriteLine("Tipos: 1 - Veterinário, 2 - Zelador");
        Console.Write("Tipo: ");
        string tipo = Console.ReadLine();

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int.TryParse(Console.ReadLine(), out int idade);

        Funcionario funcionario = null;
        if (tipo == "1")
            funcionario = new Veterinario(nome, idade);
        else if (tipo == "2")
            funcionario = new Zelador(nome, idade);

        if (funcionario != null)
        {
            funcionarios.Add(funcionario);
            Console.WriteLine($"Funcionário cadastrado com sucesso: {funcionario.Info()}");
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
        }

        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }
    else if (opc == "3")
    {
        Console.Clear();
        if (animais.Count == 0 || funcionarios.Count == 0)
        {
            Console.WriteLine("Cadastre pelo menos um animal e um funcionário antes.");
            Console.ReadLine();
            continue;
        }

        Console.WriteLine("Animais cadastrados:");
        for (int i = 0; i < animais.Count; i++)
            Console.WriteLine($"{i + 1}. {animais[i].Info()}");

        Console.Write("Escolha um animal (número): ");
        int.TryParse(Console.ReadLine(), out int animalIndex);
        if (animalIndex < 1 || animalIndex > animais.Count)
        {
            Console.WriteLine("Escolha inválida.");
            Console.ReadLine();
            continue;
        }
        Animal animalEscolhido = animais[animalIndex - 1];

        Console.WriteLine("Funcionários cadastrados:");
        for (int i = 0; i < funcionarios.Count; i++)
            Console.WriteLine($"{i + 1}. {funcionarios[i].Info()}");

        Console.Write("Escolha um funcionário (número): ");
        int.TryParse(Console.ReadLine(), out int funcIndex);
        if (funcIndex < 1 || funcIndex > funcionarios.Count)
        {
            Console.WriteLine("Escolha inválida.");
            Console.ReadLine();
            continue;
        }
        Funcionario funcEscolhido = funcionarios[funcIndex - 1];

        if (funcEscolhido is Veterinario vet)
        {
            vet.ConsultarAnimal(animalEscolhido);
            vet.RealizarTratamento(animalEscolhido);
        }
        else if (funcEscolhido is Zelador zel)
        {
            zel.AlimentarAnimal(animalEscolhido);
            zel.CuidarHabitat(animalEscolhido);
        }
        else
        {
            Console.WriteLine("Funcionário sem ação definida.");
        }

        Console.WriteLine("Pressione Enter para continuar...");
        Console.ReadLine();
    }
    else if (opc == "4")
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida.");
        Console.ReadLine();
    }
}
