// ## Итоговая проверочная работа.

// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик.
// Мы должны убедиться что базовое знакомство с it прошло успешно.

// Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
// 1.Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
// 3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4.Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

// **Задача * *: Написать программу, которая из имеющегося массива целых чисел формирует массив из чётных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//**Примеры**:
//[1, 2, 3, 4] -> [2, 4]


// Основная программа:

//int[] massiv = FillArray(); // заполнение массива с клавиатуры ("0"-выход)
int[] massiv = FillRandomArray(); // заполнение массива рандомными числами
Console.WriteLine("Исходный массив: ");
PrintArray(massiv); // печать исходного массива
int[] newMassiv = NewArray(massiv); // преобразование в новый массив
Console.WriteLine("Новый массив: ");
PrintArray(newMassiv); // печать нового массива
Console.WriteLine("Конец програмы. Нажмите любую клавишу");
Console.ReadKey();


//МЕТОДЫ:

// функция преобразования из одного массива в другой массив
int[] NewArray(int[] array)
{
    int[] newArray = new int[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[newArray.Length - 1] = array[i];
        }
    }
    return newArray;
}

// функция заполнения массива с клавиатуры
int[] FillArray()
{
    int[] array = new int[0];
    int input;

    Console.WriteLine("Заполните массив значениями, (для выхода введите '0'): ");
    for (int i = 0; true; i++)
    {
        Console.Write($"Ведите значение {i + 1}: ");
        input = InputNumber("");
        if (input == 0) break;
        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = input;
    }
    return array;
}

// функция заполнения массива рандомными целыми числами
int[] FillRandomArray()
{
    int n = InputNumber("Введите размер массива: ");
    int[] array = new int[Math.Abs(n)];
    Random randomNumber = new Random();
    for (int i = 0; i < n; i++)
        array[i] = randomNumber.Next(-99, 100);
    return array;
}

// функция ввода числа с клавиатуры
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int number;
    bool checkInput = int.TryParse(input, out number);
    while (!checkInput)
    {
        Console.Write(message);
        input = Console.ReadLine();
        checkInput = int.TryParse(input, out number);
    }
    return number;
}

// функция печати массива
void PrintArray(int[] array)
{
    if (array.Length != 0)
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i] + "  ");
        }
}

