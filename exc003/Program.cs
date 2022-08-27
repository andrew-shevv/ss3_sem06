// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] ToBinary(int numDecimal){
    if (numDecimal > 0){
        int size =  ((int)Math.Log2(numDecimal) + 1);
        int[] numBinary = new int[size];
        for (int i = size - 1; i >= 0; i--){
            numBinary[i] = numDecimal % 2;
            numDecimal /= 2;
        }
        return numBinary;
    }
    else {
        int[] zeroVal = {0};
        return zeroVal;
    }
}

int[] binaryAlley = ToBinary(num);

Console.Write(string.Join("", binaryAlley));