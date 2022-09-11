// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел происходит через Enter, останавливается при введении слова "stop"
/* 
int PositiveNumbers()
{
    Console.WriteLine("Введите числа(для завершения ввода введите 'stop'): ");
    int count = 0;
    for(int i = 0; ; i++)
    {
        string a = Console.ReadLine();
        if(a == "stop") break;
        else 
        {
            int b = Convert.ToInt32(a);
            if(b > 0) count++;         
        }
    }    
    Console.WriteLine($"Введено {count} положительных(-ое) чисел(-о)");
    return count;
}

PositiveNumbers();
 */


 // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
 // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
/* 
double[,] ratio = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficient(){
  for (int i = 0; i < ratio.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < ratio.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      ratio[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Formula(double[,] ratio)
{
  crossPoint[0] = (ratio[1,1] - ratio[0,1]) / (ratio[0,0] - ratio[1,0]);
  crossPoint[1] = crossPoint[0] * ratio[0,0] + ratio[0,1];
  return crossPoint;
}

void OutputResult(double[,] ratio)
{
  if (ratio[0,0] == ratio[1,0] && ratio[0,1] == ratio[1,1]) 
  {
    Console.Write($"Прямые совпадают");
  }
  else if (ratio[0,0] == ratio[1,0] && ratio[0,1] != ratio[1,1]) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
  {
    Formula(ratio);
    Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficient();
OutputResult(ratio);
 */