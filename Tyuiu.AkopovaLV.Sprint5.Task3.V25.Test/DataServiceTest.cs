namespace Tyuiu.AkopovaLV.Sprint5.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\source\repos\Tyuiu.AkopovaLV.Sprint5\Tyuiu.AkopovaLV.Sprint5.Task3.V25\bin\Debug\net8.0\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            Assert.IsTrue(exists);
        }
    }
}
