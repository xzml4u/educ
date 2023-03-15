// Реализовать перемешивание массива
// 1 Создать массив
// 2 Распечатать массив
// 3 Заполнение 3.1 случайно
// 4 перемешивание



// 1. Создание массива

int[] CreateArray(int array)
{
    return new int[array];
}

// 2. Распечатать массив
void PrintArray(int[] array)
{
    int size = array.Length;
    int i = 0;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        ++i;
    }
}


// 3. Заполнение массива рандомными числами

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length){
        collection[index] = index;
        index++;
    }
}


// 4. Перемешивание массива
void Mix(int[] arr){
    int index = 0;
    int help = arr[index];
    int size = arr.Length - 1;

    while(index < size){
        int random = new Random().Next(arr[index] + 1);
        if(random != arr[index])
        {
        int help2 = arr[random];
        arr[random] = arr[index];
        arr[index] = arr[help2];
        }
        

        index++;
    }
}



int[] arr = CreateArray(10);
FillArray(arr);
Mix(arr);
PrintArray(arr);