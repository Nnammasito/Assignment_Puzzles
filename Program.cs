
// Matriz Aleatoria
int[] randomArray = RandomArray();
Console.WriteLine("Valores en la matriz aleatoria:");
foreach (int value in randomArray)
{
    Console.Write(value + " ");
}
Console.WriteLine("\nValor mínimo: " + randomArray.Min());
Console.WriteLine("Valor máximo: " + randomArray.Max());
Console.WriteLine("Suma de los valores: " + randomArray.Sum());

// Lanzamiento de Moneda
string coinResult = TossCoin();
Console.WriteLine(coinResult);

// Lanzamiento de Monedas Múltiples (opcional)
int numTosses = 10; // Puedes cambiar este valor
double headToTotalRatio = TossMultipleCoins(numTosses);
Console.WriteLine("Relación entre lanzamientos de cara y lanzamientos totales: " + headToTotalRatio);

// Nombres
List<string> names = Nombres();
Console.WriteLine("Nombres con más de 5 caracteres:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Barajar Nombres (opcional)
names = names.OrderBy(x => Guid.NewGuid()).ToList();
Console.WriteLine("\nNombres barajados:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Función para crear una matriz de enteros aleatorios
static int[] RandomArray()
{
    int[] array = new int[10];
    Random random = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(5, 26);
    }

    return array;
}

// Función para lanzar una moneda y devolver el resultado
static string TossCoin()
{
    Console.WriteLine("¡Tirando una moneda!");
    Random random = new Random();
    int result = random.Next(2); // 0 o 1 para representar Cara o Cruz
    return (result == 0) ? "Cara" : "Cruz";
}

// Función para lanzar múltiples monedas y devolver la relación Cara/Todas
static double TossMultipleCoins(int num)
{
    int headCount = 0;

    for (int i = 0; i < num; i++)
    {
        if (TossCoin() == "Cara")
        {
            headCount++;
        }
    }

    return (double)headCount / num;
}

// Función para devolver una lista de nombres con más de 5 caracteres
static List<string> Nombres()
{
    List<string> names = new List<string> { "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney" };
return names.Where(name => name.Length > 5).ToList();
}