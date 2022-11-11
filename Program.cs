int[] array = new int[5];                      //Создание одномерного массива, заполненного случайными числами;
int i;
void fillArray (int[] array)                    //Заполнение массива случайными числами
{
Random rnd = new Random();
for (i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(-10, 15);
    Console.Write(array[i] + " ");
}
}
fillArray (array);
Console.WriteLine();

int countSum (int []array)
{
int sum = 0;                                    //Сумма чисел, имеющих нечетный индекс в массиве;
for (i = 1; i <array.Length; i++)

{
    sum = sum + array[i];
    i = i + 1;
}
return sum;
}
int sum = countSum (array);
Console.WriteLine(sum);