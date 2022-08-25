//
int[] ReverseArray(int[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0,j = input.Length - 1; i < input.Length;i++,j--)
    {
        result[i]= input [j];
    }
    return result;
}

void PrintArray(int[]input)
{
    for(var i = 0;i < input.Length; i++)
    Console.Write (input[i]+ ",");
}

int [] input = new int[]{1, 2, 3, 4, 5};
var result = ReverseArray(input);
PrintArray(result);