// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Input side x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input side y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Input side z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.Write($"Can a triangle with sides: {x}, {y}, {z}, exist?");

if (x < y + z && y < x + z && z < x + y){
    Console.Write(" -- yes");
}
else Console.Write(" -- no");