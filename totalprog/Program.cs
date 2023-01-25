/* Написать программу, которая из имеюегося массива строк формирует массив 
из строк, длина которых меньше или равна 3 символа. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.
Пример: 
[ "hello", "2", "world", ":-)"] -> [ "2", ":-)"]
*/

// Метод проверки размерности исходного массива
static int GetNumber(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Введите корректную размерность массива. Натуральное число");
    }
    return result;
}

//Получить заполненный исходный массив значениями типа string
static string[] InitArray(int dimArray)
{
    string[] array = new string[dimArray];

    Console.WriteLine("Вводим строковый массив ниже");
    for (int i = 0; i < dimArray; i++)
    {
        Console.Write($"{i} элемент:");
        array[i] = Console.ReadLine();
    }
    return array;
}

//Выбрать элементы массива длина которых меньше или равна 3 символа
// и определить размерность нового массива 
static int ArrayElementCheck3S(string[] array)
{
    int count = 0;
    string temp = string.Empty;

    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i];
        if (temp.Length <= 3) count++;
    }
    return count;
}

//Формирование новых элементов массива, длина которых меньше 
//или равна 3 символа

static string[] MyArrayCreate3S(string[] array, int myDimArray)
{
    string[] MyArray3S = new string[myDimArray];

    int mycount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            MyArray3S[mycount] = array[i];
            mycount++;
        }
    }
    return MyArray3S;
}

// Распечатать массив на консоль
static void PrintArray(string[] myArray)
{
    Console.WriteLine("Выводим новый массив с элементами <=3 символа");
    for (int i = 0; i < myArray.Length; i++) Console.WriteLine($"{i} элемент:{myArray[i]}");
    Console.WriteLine();
}

Console.WriteLine("Формируем массив из строк");
int dimArray = GetNumber("Введите размерность этого массива: ");
string[] array = InitArray(dimArray);
int myDimArray = ArrayElementCheck3S(array);
string[] myArray = MyArrayCreate3S(array, myDimArray);
PrintArray(myArray);
Console.Write("Программа завершила работу. Нажмите любую кнопку для выхода...");
Console.ReadKey();