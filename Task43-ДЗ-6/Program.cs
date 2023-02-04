// Задача 43: 
// Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double k1, double k2, double b1, double b2)
{
    double[] result=new double[2];
    result[0] = (b2-b1)/(k1-k2);
    result[1] = k1*result[0]+b1;
    return result;
}

Console.WriteLine("Введите коэффициент b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Заданные порямые паралельны!");
    return;
}

double[] res = IntersectionPoint(k1, k2, b1, b2); 
Console.WriteLine(b1 + ", " + k1 + ", " + b2 + ", " + k2);
double x = Math.Round(res[0], 2);
double y = Math.Round(res[1], 2);
Console.WriteLine("Точка пересечкния" + " -> " + x + ", " + y); 
