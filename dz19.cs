/*Задача 44:выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8 */
Console.WriteLine("Введите количесво желаемых чисел Фибоначчи : ");
int N = Convert.ToInt32(Console.ReadLine());
int prev = 0;
int current = 1;
int temp;
Console.WriteLine("Ряд Фибоначчи : ");
 Console.WriteLine(prev);
    for (int i = 2; i <= N; i++)
    {
        Console.WriteLine(current);
        temp = current;
        current = current + prev;
        prev = temp;
    }
 
Console.ReadKey();
    