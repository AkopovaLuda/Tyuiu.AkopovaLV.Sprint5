using Tyuiu.AkopovaLV.Sprint5.Task7.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Гогин М. А. | АСОиУБ-23-1";
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #5                                                              *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #19                                                            *");
        Console.WriteLine("* Выполнил: Гогин Михаил Александрович | АСОиУБ-23-1                     *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Удалить все          *");
        Console.WriteLine("* удвоенные буквы сс из файла.Полученный результат сохранить в файл      *");
        Console.WriteLine("* OutPutDataFileTask7V19.txt.                                            *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");
        string path = @"C:\DataSprint5\InPutDataFileTask7V19.txt";
        string pathsave = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });
        Console.WriteLine("Данные находятся в файле: " + path);
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Находится в файле: ");
        pathsave = ds.LoadDataAndSave(path);
        Console.WriteLine(pathsave);
        Console.ReadKey();
    }
}