// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool Palindrom(int Num)
{
    if ((Num / 10000 == Num % 10) && ((Num / 1000) % 10 == (Num % 100) /10))      
        return true;
    else
        return false;
}
Console.WriteLine("Введите пятизначное число");
int Number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrom(Number));
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distans3D(double x1, double y1,double z1,double x2,double y2,double z2)
{
    double distans = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)+ (z1-z2)*(z1-z2));
    return distans;
}
Console.WriteLine("Введите координаты первой точки: x1");
double PointX1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки: y1");
double PointY1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки: z1");
double PointZ1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: x2");
double PointX2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: y2");
double PointY2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки: z2");
double PointZ2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" Растояние между уакзанными точками: {Distans3D(PointX1, PointY1, PointZ1, PointX2, PointY2, PointZ2)}");
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void TableCube(int number)
    {
        int i = 1;
        while(i <= number)
        {
            double result = Math.Pow(i, 3);
            Console.WriteLine(result + " ");
            i ++;
        }
    }
    Console.WriteLine("Введите целое число больше 0");
    int Num = Convert.ToInt32(Console.ReadLine());
    TableCube(Num);
    */