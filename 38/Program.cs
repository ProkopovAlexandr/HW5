double [] gen_ar(int size)
{
    var rnd = new Random();
    double [] arr_num = new double [size];
    double  arr_num_dbl = 0;
    int  arr_num_int = 0;
    for (int i = 0; i < size; i++)
    {
        arr_num_dbl = Math.Round (rnd.NextDouble(), 2, MidpointRounding.AwayFromZero);
        arr_num_int = rnd.Next(0, 1000);
        arr_num[i] = arr_num_dbl + arr_num_int;
    }
    return arr_num;
}

double difference_max_min(int size, double [] arr_num)
{
    double min = 1000;
    double max = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr_num[i] < min)
        {
            min = arr_num[i];
        }
        if (arr_num[i] > max)
        {
            max = arr_num[i];
        }
    }
    return max - min;
}

Console.Write("Введите размер массива: ");
int size_ar = Convert.ToInt32(Console.ReadLine());
Console.Write("Разность между максимальным и минимальным элементами: " + difference_max_min(size_ar, gen_ar(size_ar)));