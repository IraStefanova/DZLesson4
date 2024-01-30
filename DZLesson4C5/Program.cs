
int[] array1 = new int[5];
int[] array2 = new int[5];
Random rand = new Random();

for (int i = 0; i < array1.Length; i++)
    array1[i] = rand.Next(1, 10) ; 

for (int i = 0; i < array2.Length; i++)
    array2[i] = rand.Next(1, 10);

Console.WriteLine("[{0}]", string.Join(", ",array1));
Console.WriteLine("[{0}]", string.Join(", ",array2));

int sum1 = 0;
for (int i = 0; i < array1.Length; i++)
    sum1 += array1[i];
int res1 = sum1 / array1.Length;

Console.WriteLine($"Среднее арифметическое число массива 1 равно {res1}");

int sum2 = 0;
for (int i = 0; i < array2.Length; i++)
    sum2 += array2[i];
int res2 = sum2 / array2.Length;

Console.WriteLine($"Среднее арифметическое число массива 2 равно {res2}");

 if (res1 > res2)
{
    Console.WriteLine("Среднее арифметическое число массива 1 больше, чем у массива 2");
}
else if (res1 < res2)
{
    Console.WriteLine("Среднее арифметическое число массива 2 больше, чем у массива 1");
}
else if (res1 == res2)
{
    Console.WriteLine("Среднее арифметическое числа массивов равны");
}