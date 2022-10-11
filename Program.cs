/* D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


void GetDistanceBetweenTwoPoints(int firstX, int secondX, int firstY, int secondY, int firstZ, int secondZ)
{
double result = 0;

double tempX = Math.Pow (secondX - firstX,2);
double tempY = Math.Pow (secondY - firstY,2);
double tempZ =Math.Pow (secondZ - firstZ,2);

result = Math.Sqrt(tempX + tempY + tempZ);

Console.WriteLine($"расстояние между двумя точками в 3D = {result}");
}

GetDistanceBetweenTwoPoints(3,2,6,1,8,-7);
