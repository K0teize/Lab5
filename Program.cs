public class Program
{
    static void Main()
    {
        
        //Кол-во элементов оканч-ся на 3
        
        Console.WriteLine("Введите количество элементов массива:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы массива:");
        int j = 0, count = 0;
        int[] mas = new int[n];
        while (j < n)
        {
            mas[j] = int.Parse(Console.ReadLine());
            j++;
        }
        for (int i = 0; i < n; i++)
        {
            if (Math.Abs(mas[i]) % 10 == 3)
            {
                count++;
            }
        }

        Console.WriteLine("Количество элементов оканчивающихся на 3: " + count);
        Console.WriteLine();

        //Поменять местами макс и мин
        Console.WriteLine("Введите количество элементов второго массива:");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы массива:");
        int b = 0, masmin = int.MaxValue, masmax = int.MinValue, min_id=0, max_id=0;
        int[] mas2 = new int[v];
        while (b < v)
        {
            mas2[b] = int.Parse(Console.ReadLine());
            b++;
        }
        for (int i = 0; i < v; i++)
        {
            if (mas2[i] > masmax)
            {
                masmax=mas2[i];
                max_id = i;
            }
            if (mas2[i] < masmin)
            {
                masmin=mas2[i];
                min_id = i;
            }
        }
        mas2[min_id]=masmax;
        mas2[max_id]=masmin;
        Console.WriteLine("Массив с перестановкой максимума и минимума: ");
        for (int i = 0; i < v; i++) { 
        Console.WriteLine(mas2[i]);
        }
        
        //Равномерное возрастание
        Console.WriteLine("Введите количество элементов третьего массива: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите элементы третьего массива:");
        int o = 0,count3=0;
        int[] mas3 = new int[p];
        while (o < p) 
        {
            mas3[o] = int.Parse(Console.ReadLine());
            o++;
        }
        int rz = mas3[1] - mas3[0];
        for (int i = 1; i < p; i++)
        { 
            if(rz == mas3[i] - mas3[i-1] && rz > 0)
            {
                count3++;
            }
        }
        if (count3 == p - 1)
        {
            Console.WriteLine("Последовательность равномерно возрастающая");
        }
        else 
        {
            Console.WriteLine("Последовательность не равномерная или не возрастающая ");
        }
        
    }
}
