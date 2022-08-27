// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[new Random().Next(3, 8)];

Random rand = new Random();
for (int i = 0; i < array.Length; i++){
    array[i] = rand.Next(1, 10);
}

Console.Write('[' + string.Join(", ", array) + ']' + " ==> ");

for (int i = 0; i < array.Length / 2; i++){
    int temp = array[i];
    array[i] = array[array.Length - i - 1];
    array[array.Length - i - 1] = temp;
}

Console.Write('[' + string.Join(", ", array) + ']');