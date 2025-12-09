using Tyuiu.AkopovaLV.Sprint5.Task0.V21.Lib;
namespace Tyuiu.AkopovaLV.Sprint5.Task0.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.AkopovaLV.Sprint5\Tyuiu.AkopovaLV.Sprint5.Task0.V21\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fd = new FileInfo(path);
            bool fe = fd.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fe);

        }
    }
}
