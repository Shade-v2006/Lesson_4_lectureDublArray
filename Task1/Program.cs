// Двумерный массив с типом данных целое число
int[,] matrix = new int[3, 5]; // Создание двумерного массива matrix

Random rnd = new Random(); //Генерация случайных цифр вынесенна за пределы циклов 

// Заполнение двумерного массива с помощью рандомных чисел от 1 до 10
for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам массива
{
    for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам массива
    {
        //Random rnd = new Random(); - лучще выносить за пределы циклов так как ресурсозатратный процесс
        matrix[i, j] = rnd.Next(1, 11); // заполнение строк и столбцов массива рандомными числами от 1 до 10
    }
}

// Вывод двумерного массива на экран
for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам массива
{
    for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам массива
    {
        Console.Write($"{matrix[i, j]}  "); // вывод данных - называется ИНТЕРПОЛЯЦИЯ строк
    }
    System.Console.WriteLine(); // переход на новую строку после заполнения первой строки массива
}
System.Console.WriteLine("*********************");
// Создание функции из сформированных выше циклах
int[,] createMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount]; // Создание двумерного массива matrix
    Random rnd = new Random(); //Генерация случайных цифр вынесенна за пределы циклов 

    // Заполнение двумерного массива с помощью рандомных чисел от 1 до 10
    for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // проход по столбцам массива
        {
            //Random rnd = new Random(); - лучще выносить за пределы циклов так как ресурсозатратный процесс
            matrix[i, j] = rnd.Next(1, 11); // заполнение строк и столбцов массива рандомными числами от 1 до 10
        }
    }
    return matrix;
}

// Функция вывода марици на экран
void showMatrix(int[,] matrix)
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

matrix = createMatrix(5, 5);
showMatrix(matrix);