// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] NewArray(int len, int min, int max){
    int[] array = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++){
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

int[] CopyArray(int[] original){
    int[] copy = new int[original.Length];
    for (int i = 0; i < copy.Length; i++){
        copy[i] = original[i];
    }
    return copy;
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

int[] bunchie = NewArray(SIZE, MIN_VAL, MAX_VAL);

Console.Write('[' + string.Join(", ", bunchie) + ']' + " = copied into => ");

int[] ripOff = CopyArray(bunchie);

Console.WriteLine('[' + string.Join(", ", ripOff) + ']');

Console.WriteLine();

Reverse(bunchie);

Console.WriteLine("Oh no, someone reversed the original array!");

Console.WriteLine('[' + string.Join(", ", bunchie) + ']');

Console.WriteLine("Thankfully, the copy still exists.");

Console.WriteLine('[' + string.Join(", ", ripOff) + ']');