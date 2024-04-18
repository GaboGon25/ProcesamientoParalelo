using ProcesamientoParalelo;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia del repositorio
        IRepository<string> repository = new StringRepository();

        // Obtener todos los nombres que empiezan con 'E' usando procesamiento paralelo
        char startingChar = 'E';
        List<string> namesStartingWithE = GetNamesStartingWithParallel(repository, startingChar);

        // Mostrar los nombres encontrados
        Console.WriteLine($"Nombres que empiezan con '{startingChar}':");
        foreach (var name in namesStartingWithE)
        {
            Console.WriteLine(name);
        }
    }

    static List<string> GetNamesStartingWithParallel(IRepository<string> repository, char startingChar)
    {
        List<string> allNames = repository.GetAllNames();

        // Usar Parallel LINQ (PLINQ) para buscar nombres que empiecen con el carácter especificado de forma paralela
        return allNames
            .AsParallel()
            .Where(name => name.StartsWith(startingChar.ToString(), StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}