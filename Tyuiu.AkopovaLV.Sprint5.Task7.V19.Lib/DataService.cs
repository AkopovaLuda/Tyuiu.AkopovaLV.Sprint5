using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AkopovaLV.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string pathsave = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask7.txt" });

            FileInfo fileInfo = new FileInfo(pathsave);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathsave);
            }

            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strline = strline + line[i];
                    }
                }
                strline = strline.Replace("сс", "");
                File.AppendAllText(pathsave, strline);

            }
            return pathsave;
        }

       
    }
}
