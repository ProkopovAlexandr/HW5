int [] gen_ar(int size)
    {
    var rnd = new Random();
    int [] arr_num = new int [size];
    for (int i = 0; i < size; i++)
        arr_num[i] = rnd.Next(0, 1000);
    return arr_num;
    }

int sum_of_el_with_odd_ind(int size, int[] arr_num)
    {
    int sum = 0;
    for (int i = 1; i < size; i+=2)
        sum += arr_num[i];
    return sum;
    }


Console.Write("Введите размер массива: ");
int size_ar = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма элементов с нечёным индексом: " + sum_of_el_with_odd_ind(size_ar, gen_ar(size_ar)));