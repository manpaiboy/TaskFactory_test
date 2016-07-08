using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Task t = new Task(() =>
            {
                Console.WriteLine("任务开始工作……");
                //模拟工作过程
                Thread.Sleep(5000);
            });
            t.Start();
            t.ContinueWith((task) =>
            {
                Console.WriteLine("任务完成，完成时候的状态为：");
                Console.WriteLine("IsCanceled={0}\tIsCompleted={1}\tIsFaulted={2}", task.IsCanceled, task.IsCompleted, task.IsFaulted);
            });
            Console.ReadKey();
        }


        public void TestMethod2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n <= 999999999; n++)
                {

                }
                Console.WriteLine("===================同步完成一次计算==,=======================");
            }
            Console.WriteLine("===================同步完成=======================");
        }
    }
}
