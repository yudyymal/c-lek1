Console.Clear();
Console.WriteLine("Программа для вычисления расстояния между двумя точками в 3D пространстве");
Console.WriteLine("Введите координаты первой точки через запятую (Пример: 3,-10,1)");
string coorA = Console.ReadLine() + ','; // Вводим координаты через запятую в строку (Точка А) и добавляем разделитель в виде запятой, чтоб условие ниже работало
Console.WriteLine("Введите координаты второй точки через запятую (Пример: 3,-10,1)");
string coorB = Console.ReadLine() + ','; // Вводим координаты через запятую в строку (Точка B) и добавляем разделитель в виде запятой, чтоб условие ниже работало

int[] coordinate1 = new int[3]; // Создаём массив для хранения координатов в виде чисел (Точка А)
int[] coordinate2 = new int[3]; // Создаём массив для хранения координатов в виде чисел (Точка B)

string temp = String.Empty; // Вводим временную строку для хранения части массива, чтоб в дальнейшем присвоить координату, разделённую запятой
int j = 0;

for (int i = 0; i < coorA.Length; i++)
{
    if (coorA[i] != ',')
    {
        temp = temp + coorA[i]; // Пока не встретим запятую, лепим число, переходя от символа к символу
    }
    else
    {
        coordinate1[j] = Convert.ToInt32(temp); // Если встретили запятую, то что "слепили" превращаем в число и помещаем в массив ...
        temp = String.Empty; // ... Опустошаем временную строковую переменную, чтоб перейти к следующему числу и "лепить" следующую координату
        j = j + 1; // Повышаем индекс, чтоб записать следующую переменную
    }
}

temp = String.Empty;
j = 0;

for (int i = 0; i < coorB.Length; i++)
{
    if (coorB[i] != ',')
    {
        temp = temp + coorB[i];
    }
    else
    {
        coordinate2[j] = Convert.ToInt32(temp);
        temp = String.Empty;
        j = j + 1;
    }
}

// Вычисляем расстояние между точками с помощью теоремы Пифагора
double distant = Math.Round(Math.Sqrt(Math.Pow(coordinate1[0] - coordinate2[0], 2) + Math.Pow(coordinate1[1] - coordinate2[1], 2) + Math.Pow(coordinate1[2] - coordinate2[2], 2)), 2);
System.Console.WriteLine("Расстояние между данными точками = " + distant);