
int[] RandomArray()
{
    int[] tempArrayInt = new int[10];
    Random rand = new Random();
    for (int i = 0; i < tempArrayInt.Length; i++)
    {
        tempArrayInt[i] = rand.Next(5, 25);
    }

    int minResult = tempArrayInt[0];
    int maxResult = tempArrayInt[0];
    int sum = 0;
    foreach (int number in tempArrayInt)
    {
        if (number < minResult)
        {
            minResult = number;
        }
        if (number > maxResult)
        {
            maxResult = number;
        }
        sum += number;
    }
    Console.WriteLine("Valor minimo : " + minResult + " --- " + "Valor maximo : " + maxResult);
    Console.WriteLine("Suma total " + sum);
    return tempArrayInt;
}

String TossCoin()
{
    Console.WriteLine("¡Tirando una moneda!");
    Random rand = new Random();
    string result;
    if (rand.Next(0, 2) == 1)
    {
        result = "Cruz";
        Console.WriteLine(result);
    }
    else
    {
        result = "Cara";
        Console.WriteLine(result);
    }
    return result;
}

double TossMultipleCoins(int num)
{
    int sumCruz = 0;
    for (int i = 0; i < num; i++)
    {
        if (TossCoin() == "Cruz")
        {
            sumCruz++;
        }
    }
    return sumCruz / num;
}

List<string> Nombres()
{
    List<string> listaNombre = new List<string>()
    {
        "Todd", "Tiffany", "Charlie", "Ginebra", "Sydney"
    };
    List<string> listaTemp = new List<string>();
    foreach (var item in listaNombre)
    {
        if (item.Length > 5)
        {
            listaTemp.Add(item);
            Console.WriteLine(item);
        }
    }

    //Barajar la lista.
    Console.WriteLine("\nBaraja la lista\n");
    Random rand = new Random();
    for (int i = 0; i < listaTemp.Count; i++)
    {
        int posicion1 = rand.Next(0, listaTemp.Count);
        int posicion2 = rand.Next(0, listaTemp.Count);
        while (posicion1 == posicion2)
        {
            posicion2 = rand.Next(0, listaTemp.Count);
        }
        Console.WriteLine(posicion1 + " ---- " + posicion2 + "\n");
        string tempStore = listaTemp[posicion1];
        listaTemp[posicion1] = listaTemp[posicion2];
        listaTemp[posicion2] = tempStore;
    }

    foreach (var result in listaTemp)
    {
        Console.WriteLine(result);
    }

    return listaTemp;
}