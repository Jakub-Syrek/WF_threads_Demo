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

namespace WF_thrads_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_ThreadStart_Click(object sender, EventArgs e)
        {
            ThreadHelper thread = new ThreadHelper();
            thread.returnDate.Start();
            thread.returnDate.Join();
            tb_Console.AppendText(thread.Output);            
        }

        private void  Bt_ThreadStartPooled_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<Fibonacci> list = new List<Fibonacci>();
            const int FibonacciCalculations = 5;

            ManualResetEvent[] doneEvents = new ManualResetEvent[FibonacciCalculations];
            Fibonacci[] fibArray = new Fibonacci[FibonacciCalculations];
            Random rand = new Random();            

            tb_Console.AppendText($"Launching {FibonacciCalculations} tasks...{Environment.NewLine}");
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);
                list.Add(new Fibonacci(Convert.ToUInt64(rand.Next(20, 10000)), doneEvents[i]));
                fibArray[i] = list[i];
                ThreadPool.QueueUserWorkItem(list[i].ThreadPoolCallback, i);
                
            }

            for (int i = 0; i < doneEvents.Length; i++)
            {
                doneEvents[i].WaitOne();
                tb_Console.AppendText(list[i].Output);
            }

            tb_Console.AppendText($"All calculations are completed in {stopwatch.Elapsed}.{Environment.NewLine}");

            for (int i = 0; i < FibonacciCalculations; i++)
            {
                Fibonacci f = fibArray[i];
                tb_Console.AppendText($"Fibonacci({f.N}) = {f.FibOfN}{Environment.NewLine}");
            }
        }
    }
}
