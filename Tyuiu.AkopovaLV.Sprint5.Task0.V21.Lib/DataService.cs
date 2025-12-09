using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkopovaLV.Sprint5.Task0.V21.Lib
{
    public class DataService : ISprint5Task0V21
    {
        public string SaveToFileTextData(int x)
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.AkopovaLV.Sprint5\Tyuiu.AkopovaLV.Sprint5.Task0.V21\bin\Debug\net8.0\OutPutFileTask0.txt";
            double y = Math.Round((x * x + 1) / Math.Sqrt(4 * x * x - 3), 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
