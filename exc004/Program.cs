// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Input number of elements: ");
int numN = Convert.ToInt32(Console.ReadLine());

double[] fibo = new double[numN];

if (numN > 1){
    fibo[1] = 1;
    for (int i = 2; i < numN; i++){
        fibo[i] = fibo[i - 1] + fibo[i - 2];
    }
}


Console.Write(string.Join(" ", fibo));