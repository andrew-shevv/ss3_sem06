// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("How many numbers do you want to input? ");
int x = Convert.ToInt32(Console.ReadLine());

int[] inputArr = new int[x];

int countPos = 0;

for (int i = 0; i < x; i++){
    Console.Write($"Input number {i + 1} of {x}: ");
    inputArr[i] = Convert.ToInt32(Console.ReadLine());
    if (inputArr[i] > 0){
        countPos++;
    }
}

Console.WriteLine('[' + string.Join(", ", inputArr) + ']');
Console.Write($"You have inputted {countPos} positive numbers");