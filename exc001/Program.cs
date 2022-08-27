// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] NewArray(int len, int min, int max){
    int[] array = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++){
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void Reverse(int[] array){
    for (int i = 0; i < array.Length / 2; i++){
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

const int SIZE = 7;
const int MIN_VAL = -9;
const int MAX_VAL = 9;

int[] list = NewArray(SIZE, MIN_VAL, MAX_VAL);

Console.Write('[' + string.Join(", ", list) + ']' + " ==> ");

Reverse(list);

Console.Write('[' + string.Join(", ", list) + ']');