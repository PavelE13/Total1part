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
    static string[] InitArray (int dimArray)
    {
	string[] array = new string[dimArray];
	
    Console.WriteLine("Вводим строковый массив ниже");
	for (int i=0;i<dimArray;i++)
	{
        Console.Write($"{i} элемент:");
        array[i]=Console.ReadLine();
	}
	return array;
    }

    //Выбрать элементы массива длина которых меньше или равна 3 символа
    // и определить размерность нового массива 
    static int ArrayElementCheck3S (string[] array)
    {
        int count=0;
        string temp = string.Empty;

        for (int i=0;i<array.Length;i++)
        {
            temp=array[i];
            if(temp.Length<=3)
            {
                count++;
            }
        }
	return count;
    }

    /*//Определить элемент массива
    static string MyArray3S (string[] myarray, string[] array)
    {
        nt undefined=5;
        string[] MyArray3S = new string[undefined];
        string[] myarray = new string[];
	    for (int i=0;i<array.Length;i++)
	    {
		    if(array[i]%2==0) count++;
	    }
	return count;
    }*/
    
    // Распечатать массив на консоль
    static void PrintArray (string[] array)
    {
	for (int i=0;i<array.Length;i++) Console.WriteLine(array[i]);
    }
    


    Console.WriteLine("Формируем массив из строк");
    int dimArray=GetNumber("Введите размерность этого массива: ");
    string[] array=InitArray(dimArray);
    int myDimArray=ArrayElementCheck3S(array);
    //string[] myArray=ArrayElementCheck3S(array);
    //PrintArray(myArray);
    Console.WriteLine(myDimArray);