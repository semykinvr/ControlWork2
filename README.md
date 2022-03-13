ControlWork (2)


# Итоговая проверочная работа

## 1. Создан репозиторий на GitHub:
https://github.com/semykinvr/ControlWork2.git

## 2. Нарисована блок-схема алгоритма (основной содержательной части, отдельный метод): 
! [Скан] (https://disk.yandex.ru/i/PEXdl_PUZmRe4w)

## 3. Репозиторий снабжён оформленным текстовым описанием решения (данный файл README.md)

## 4. Написана программа, решающая поставленную задачу. 
Код: 

```C#
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
```  

Результат работы программы:
! [Скриншот] (https://disk.yandex.ru/i/FP00_GbZrNpZAQ)


## 5. Использован контроль версий в работе над этим проектом (залито несколькими коммитами, в том числе этапы 2, 3 и 4 расположены в разных коммитах)


