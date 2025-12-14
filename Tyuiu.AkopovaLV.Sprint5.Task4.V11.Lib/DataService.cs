using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkopovaLV.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            
            string[] parts = strX.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            
            if (parts.Length == 0)
            {
                throw new InvalidDataException("Файл не содержит чисел.");
            }

            
            string firstNumberStr = parts[0];

            
            double x = double.Parse(firstNumberStr, CultureInfo.InvariantCulture);

            
            double res = Math.Round(Math.Sin(x) + Math.Pow(x, 2) / 2, 3);
            return res;

        }
    }
}
