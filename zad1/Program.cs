// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] FillArrayWithRandomNumber(int size)
{
    int[] arr = new int[size];
    
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine("Введите число массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

System.Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join(", ", array));
int num=0;

for (int i=0; i<array.Length; i++)
{
    if(array[i]<0)
    {
        num++;
    }
}
System.Console.WriteLine(num);
