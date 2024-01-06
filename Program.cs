Console.Write("Введите количество элементов массива => ");
int maslength = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[maslength];

void generateArray(string[] array) //Функция ввода массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine(); // Перевод строки (чтобы отделять массивы)
}

string[] thirdsimvol(string[] array) //Основная функция
{
    int kol = 0; //Начало счетчика
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        kol++; //Подсчет кол-ва элементов с тремя и менее символами
    }

    
    string[] rezult = new string[kol]; //Создание нового массива размерностью с kol
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            rezult[j] = array[i]; //Внос элементов с тремя и менее символами с введенного массива в новый
            j++;
        }
    }
    return rezult;
}

void printArray(string[] array) //Функция вывода массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"‘{ array[i]}’, ");
    }
    Console.Write("]");
}

generateArray(Array);
printArray(thirdsimvol(Array));
