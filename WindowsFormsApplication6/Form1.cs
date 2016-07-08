using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pathExe = @"C:\Program Files\WinRAR\WinRAR.exe";
            Process p = new Process();
            p.StartInfo.FileName = pathExe;
            p.StartInfo.Arguments = "a -as -s " + "d:\\ddd.rar" + " " + "d:\\DBTools.DAT" + " ";
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardError = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.ErrorDialog = false;
            p.Start();
            int idx = 1;
            while (!p.HasExited)
            {
                idx++;
                p.WaitForExit(500);
                if (idx == 5)
                {
                    p.Kill();
                }
            }
            p.Close();
            p.Dispose();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TaskFactory tf = new TaskFactory();
            //for (int i = 50; i <= 1000; i ++)
            //{
            //    //Thread.Sleep(888);
            //    button1.Size = new Size(button1.Size.Width + i, button1.Size.Height);
            //    //tf.StartNew(() => button1.Size = new Size(button1.Size.Width + i, button1.Size.Height));
            //}

            for (int i = 0; i < 5; i++)
            {
                for(int n=0;n<=999999999;n++)
                {

                }
                Console.WriteLine("===================同步完成一次计算==,=======================");
            }
            Console.WriteLine("===================同步完成=======================");
        }
        private void ThreadMethod(object obj)
        {
            //等待2秒，用于模拟系统在处理事情
            Thread.Sleep(2000);

            ManualResetEvent mre = (ManualResetEvent)obj;
            mre.Set();
            Console.WriteLine("Thread execute");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            List<ManualResetEvent> manualEvents = new List<ManualResetEvent>();
            TaskFactory tf = new TaskFactory();
            Action doThread = () =>
            {
                for (int n = 0; n <= 999999999; n++)
                {

                }
                Console.WriteLine("===================多线程完成一次计算==,=======================");
                ManualResetEvent mre = new ManualResetEvent(false);
                manualEvents.Add(mre);
                ThreadPool.QueueUserWorkItem(ThreadMethod, mre);
            };
            for (int i = 0; i < 5; i++)
            { 
                tf.StartNew(doThread);
                //AutoResetEvent.WaitAll(waitHandles);
            }
            Action doThreadend = () =>
             {
                 Console.WriteLine("===================多线程计算完成=======================");
             };
            Func<string, int> dofuc = (s) =>  Thread.CurrentThread.ManagedThreadId;
          ;
            //AsyncCallback acb = (int s)=>
          Console.WriteLine(dofuc.Invoke("hello ,time is " + System.DateTime.Now.ToString() + "" ));
          Console.ReadLine();
            //tf.ContinueWhenAny(new Task[]{null}, doThreadend);
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
}
