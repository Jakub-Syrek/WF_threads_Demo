using System;
using System.Diagnostics;
using System.Threading;

internal class Fibonacci
{


    private dynamic _output = "";

    internal dynamic Output
    {
        get { return _output; }
        set { _output = value; }
    }

    private ManualResetEvent _doneEvent;

    internal Fibonacci(int n, ManualResetEvent doneEvent)
    {
        N = n;
        _doneEvent = doneEvent;
    }

    internal int N { get; }

    internal System.Numerics.BigInteger FibOfN { get; private set; }

    internal void ThreadPoolCallback(Object threadContext)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        int threadIndex = (int)threadContext;
        _output += $"Thread {threadIndex} started...{Environment.NewLine}";        
        FibOfN = Calculate(N);
        _output += $"Thread {threadIndex} for Fibonacii(n = {N}) calculated in {stopwatch.Elapsed} with {FibOfN.ToString().Length} digits...{Environment.NewLine}";
        _doneEvent.Set();
    }

    //public UInt64 Calculate(UInt64 n)
    //{
    //    if (n <= 1)
    //    {
    //        return n;
    //    }
    //    return Calculate(n - 1) + Calculate(n - 2);
    //}
    internal System.Numerics.BigInteger Calculate(int limit)
    {        
        System.Numerics.BigInteger[] series = new System.Numerics.BigInteger[1];
        Array.Resize(ref series, limit);

        series[0] = 0;
        series[1] = 1;

        for (int i = 2; i < limit; i++)
            series[i] = series[i - 1] + series[i - 2];

        return series[series.LongLength-1];
    }
}

