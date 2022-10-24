//  Задача 41: Пользователь вводит с клавиатуры m чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  0, 7, 8, -2, -2 -> 2
//  1, -7, 567, 89, 223-> 3


// double[] FillArrayTask1()
// {
// Random rnd = new Random();
// int insert = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[insert];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write($"Введите число № {i+1}: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }

// void PrintArray(double[] array)
// {
//     Console.WriteLine("[" + String.Join(";", array) + "]" );
// }
// void task1()
// {
// Console.Clear();
// Console.Write("Введите размер масива чисел М  ");
// double[] array = FillArrayTask1();
// PrintArray(array);
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0) count++;
// }
// Console.WriteLine("Чисел больше 0: " + count);
// }
// task1();




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void Zadacha43()
// {    
//     Console.WriteLine("Задайте значение b1, k1, b2 и k2 для уравнений y = k1 * x + b1, y = k2 * x + b2");
//     Console.Write("Введите b1: ");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите k1: ");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите b2: ");
//     double b2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("Введите k2: ");
//     double k2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine($"Точка пересечения двух прямых: {PointOfIntersection(b1, k1, b2, k2)}");
// }
// (double, double) PointOfIntersection(double b1, double k1, double b2, double k2)
// {   
//     double x = 0;
//     double y = 0;
//     if (k1 == k2)
//     {
//         Console.WriteLine("Прямые не пересекаются!");
//     }
//     else
//     {
//         x = (b2 - b1) / (k1 - k2);
//         y = (k1 * x + b1);  
//     }
//     return (Math.Round(x,2), Math.Round(y,2));
// }

// Console.Clear();
 
// Console.Write("Введите b1: ");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k1: ");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите b2: ");
// double b2 = double.Parse(Console.ReadLine()!);
// Console.Write("Введите k2: ");
// double k2 = double.Parse(Console.ReadLine()!);
 
// double[] intersecrionPoint = FindIntersection(b1,k1,b2,k2);
 
// Console.WriteLine($"{intersecrionPoint[0]} {intersecrionPoint[1]}");
 
 
 
// double[] FindIntersection(double b1, double k1, double b2, double k2)
// {
//     double[] result = new double[2];
//     result[0] = (b2 - b1) / (k1 - k2);
//     result[1] = k1 * result[0] + b1;
 
//     return result;
// }