using Tyuiu.AkopovaLV.Sprint5.Task1.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнила: Акопова Л. В. | АСОиУб-25-1";
        Console.WriteLine("****************************************************************************************************");
        Console.WriteLine("* Спринт #5                                                                                        *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                                          *");
        Console.WriteLine("* Задание #1                                                                                       *");
        Console.WriteLine("* Вариант #16                                                                                      *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                                           *");
        Console.WriteLine("****************************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
        Console.WriteLine("* Дана функция на заданном диапазоне. Произвести проверку деления на 0. Результат сохранить в      *");
        Console.WriteLine("* текстовый файл и вывести на консоль таблицу. Значения округлить до 2 знаков после запятой        *");
        Console.WriteLine("*                                                                                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int start = -5, end = 5;
        Console.WriteLine("Начало диапазона:" + start);
        Console.WriteLine("Конец диапазона: " + end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(start, end);

        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}