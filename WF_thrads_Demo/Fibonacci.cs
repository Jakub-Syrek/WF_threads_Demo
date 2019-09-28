using System;
using System.Diagnostics;
using System.Threading;

public class Fibonacci
{


    private dynamic _output = "";

    public dynamic Output
    {
        get { return _output; }
        set { _output = value; }
    }


    private ManualResetEvent _doneEvent;

    public Fibonacci(UInt64 n, ManualResetEvent doneEvent)
    {
        N = n;
        _doneEvent = doneEvent;
    }

    public UInt64 N { get; }

    public UInt64 FibOfN { get; private set; }

    public void ThreadPoolCallback(Object threadContext)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int threadIndex = (int)threadContext;
        _output += $"Thread {threadIndex} started...{Environment.NewLine}";        
        FibOfN = Calculate(N);
        _output += $"Thread {threadIndex} result calculated in {stopwatch.Elapsed}...{Environment.NewLine}";
        _doneEvent.Set();
    }

    public UInt64 Calculate(UInt64 n)
    {
        if (n <= 1)
        {
            return n;
        }
        return Calculate(n - 1) + Calculate(n - 2);
    }
}

