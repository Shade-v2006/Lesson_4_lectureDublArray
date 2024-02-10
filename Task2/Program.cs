int[,] createMatrix(int rowCount, int columsCount) //Функция заполнения двумерного массива с помощью рандомных чисел от 1 до 1000
{
    int[,] matrix = new int[rowCount, columsCount]; // Создание двумерного массива matrix
    Random rnd = new Random(); //Генерация случайных цифр вынесенна за пределы циклов 

    // Заполнение двумерного массива с помощью рандомных чисел от 1 до 10
    for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам массива
        {
            //Random rnd = new Random(); - лучще выносить за пределы циклов так как ресурсозатратный процесс
            matrix[i, j] = rnd.Next(1, 1000); // заполнение строк и столбцов массива рандомными числами от 1 до 10
        }
    }
    return matrix; // Возврвщаем matrix
}

bool IsIntresting(int value) // функцию IsIntresting принимает параметр (int value) и проверив возвращает истину или лож
{
    int sumOfDigit = GetSumOfDigit(value); //создали переменную для суммы чисел массива
    if (sumOfDigit % 2 == 0) // Проверка на четность (если делится на 2 без остатка возвращаем истину иначе лож)
    {
        return true; //возвращаем истину
    }
    return false; // иначе лож
}

int GetSumOfDigit(int value) // Функция для сложения чисел массива
{
    int sum = 0; // создаем переменную в нутри функции
    while (value > 0) // проверяем что при делении на десять число не стало нулем
    {
        sum = sum + value % 10; // получаем сумму числа получая цифры остатком от деления на 10
        value = value / 10; // убераем делением на десять последнюю цифру числа
    }
    return sum; // возвращаем сумму числа
}

void showMatrix(int[,] matrix)// Функция вывода марици на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам массива
        {
            Console.Write($"{matrix[i, j]}  "); // вывод данных - называется ИНТЕРПОЛЯЦИЯ строк
        }
        System.Console.WriteLine(); // переход на новую строку после заполнения первой строки массива
    }
}

int[,] matrix = createMatrix(3, 5); // создаем переменную 2-мерного массива matrix принемаемую из функции createMatrix с передаваемыми значениями строк и столбцов матрици
showMatrix(matrix);

foreach (int e in matrix) // перебераем полученный массив 
{
    if (IsIntresting(e) == true) // проверяем числа массива на четность передавая их в функцию IsIntresting(e)
    {
        Console.Write($"{e}  "); // вывод данных
    }
}