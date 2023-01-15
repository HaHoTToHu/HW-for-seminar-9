/*Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.*/

// int DecInBin (int number){
// if (number/2==0 && number > 0) return 1;
// if (number/2==0 && number < 0) return -1;
// if (number % 2 == 1 || number %2 == -1)
// {
// System.Console.Write(DecInBin (number/2));
// return 1;
// }
// else{
// System.Console.Write(DecInBin(number/2));
// return 0;
// }
// }
// System.Console.WriteLine("Write number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number != 0)
// System.Console.WriteLine(DecInBin(number));
// else
// System.Console.WriteLine("Write number");

/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/

// Console.WriteLine("Введите n: ");
// int n = Convert.ToInt16(Console.ReadLine());
// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt16(Console.ReadLine());
// int temp = m;

// void Summ(int m, int n, int sum)
// {
//     sum = sum + n;
//     if (n <= m)
//     {
//         Console.Write($"{sum}");
//         return;
//     }
//     Summ(m, n - 1, sum);
// }

// if (m > n)
// {
//     m = n;
//     n = temp;
// }
// Console.Write($"Сумма от {m} до {n} будет равна: ");
// Summ(m, n, temp = 0);