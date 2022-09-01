// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write($"Введите количество чисел М: ");
// int m = int.Parse(Console.ReadLine());
// int[] manyNumbers = new int[m];

// void inputNumbers(int m){
// for (int i = 0; i < m; i++)
//   {
//     Console.Write($"Введи {i + 1} число: ");
//     manyNumbers[i] = int.Parse(Console.ReadLine());
//   }
// }

// int Comparison(int[] manyNumbers)
// {
//   int count = 0;
//   for (int i = 0; i < manyNumbers.Length; i++)
//   {
//     if(manyNumbers[i] > 0 ) count += 1; 
//   }
//   return count;
// }

// inputNumbers(m);

// Console.WriteLine($"Введено чисел больше 0: {Comparison(manyNumbers)} ");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// double[,] coeff = new double[2, 2];
// double[] crossPoint = new double[2];

// void inputCoefficients(){
//   for (int i = 0; i < coeff.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
//     for (int j = 0; j < coeff.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       coeff[i,j] = int.Parse(Console.ReadLine());
//     }
//   }
// }

// double[] Decision(double[,] coeff)
// {
//   crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//   crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//   return crossPoint;
// }

// void outputResponse(double[,] coeff)
// {
//   if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     Decision(coeff);
//     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }

// inputCoefficients();
// outputResponse(coeff);