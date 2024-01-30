uint x;
uint y;
uint i;
while (true)
{
 Console.WriteLine("Введите положительное число");
  if (!System.UInt32.TryParse(Console.ReadLine(), out x))
  {
    Console.WriteLine("Ошибка ввода, введите целое, положительное чиcло");
  }
  else
  {
     break;
  }
}
 
y = 0;

    for (i = 1; i <= x; i++)
    
        y += i;
    { 
        Console.Write($"Сумма всех чисел равна {y}");
    }

