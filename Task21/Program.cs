// Напишите программу, которая принимает на 
// вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

//Math.Pow(x,2)
//Math.Sqrt(5.25);
//Math.Round (x,3)


int[] GetCoor (string message)
{
    int[] coordinates = new int[3];
    Console.Write(message + " X: ");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + " Y: ");
    coordinates[1] = int.Parse(Console.ReadLine()!);
    Console.Write(message + " Z: ");
    coordinates[2] = int.Parse(Console.ReadLine()!);
    return coordinates;
}
double DistanceBetweenPoints(int[] pointA, int[] pointB)
{
    int deltaX = pointA[0] - pointB[0]; 
    int deltaY = pointA[1] - pointB[1];
    int deltaZ = pointA[2] - pointB[2];
    double dist = Math.Sqrt(Math.Pow(deltaX,2) + Math.Pow(deltaY,2)+Math.Pow(deltaZ,2));
    return dist;
}

int[] pointA = GetCoor("Введите для точки A координаты");
int[] pointB = GetCoor("Введите для точки B координаты");
double result = DistanceBetweenPoints(pointA, pointB);
result = Math.Round(result,3);
System.Console.WriteLine(result);