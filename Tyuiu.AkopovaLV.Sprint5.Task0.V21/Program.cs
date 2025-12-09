using tyuiu.cources.programming.interfaces.Sprint5;
using Tyuiu.AkopovaLV.Sprint5.Task0.V21.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int x = 3;

        Console.Title = "Спринт #5 | Выполнила: Акопова Л. В. | АСОиУб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Акопова Людмила Владимировна | АСОиУб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.Write("Функция от данного x равна " + File.ReadAllText(ds.SaveToFileTextData(x)));
        Console.ReadLine();
    }
}