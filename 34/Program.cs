int [] gen_ar(int size)
    {
    var rnd = new Random();
    int [] arr_num = new int [size];
    for (int i = 0; i < size; i++)
        arr_num[i] = rnd.Next(100, 1000);
    return arr_num;
    }

int parity_check(int size, int[] arr_num)
{
    int num_of_even_num = 0;
    for (int i = 0; i < size; i++)
        if (arr_num[i] % 2 == 0)
        {
            num_of_even_num ++;
        }

    return num_of_even_num;
}

Console.Write("Введите размер массива: ");
int size_ar = Convert.ToInt32(Console.ReadLine());
Console.Write("В массиве чётных чисел: " + parity_check(size_ar, gen_ar(size_ar)));
