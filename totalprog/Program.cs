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
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Введите корректную размерность массива. Натуральное число");
    }
    return result;
    }
    
    /*Получить заполненный масств рандомными значениями типа string
    static string[] InitArray (int dimArray)
    {
	string[] array = new string[dimArray];
	
    Console.WriteLine("Введите строковый массив.");
	for (int i=0;i<dimArray;i++)
	{
        Console.Write($"{i} элемент:");
        
		array[i]=rnd.Next(100,1000);
	}
	return array;
    }

    //Распечатать массив на консоль
    static void PrintArray (int[] array)
    {
	for (int i=0;i<array.Length;i++) Console.Write(array[i] + "  ");
    }
    
    //Определить элемент массива
    static int GetCount (int[] array)
    {
        int count=0;
	    for (int i=0;i<array.Length;i++)
	    {
		    if(array[i]%2==0) count++;
	    }
	return count;
    }*/

    Console.WriteLine("Формируем массив из строк");
    int dimArray=GetNumber("Введите размерность этого массива: ");
    /*string[] array=InitArray(dimArray);
    PrintArray(array);
    Console.WriteLine($"Количество четных чисел в массиве = {GetCount(array)}");*/