using System;
using System.Threading;

namespace WF_thrads_Demo
{
    internal class ThreadHelper
    {
        private static dynamic _output;

        internal dynamic Output
        {
            get { return _output; }
            set { _output = value; }
        }
        internal Thread returnDate = new Thread(() =>
        {            
            // tworzenie nowego wątku
            var thread = new Thread(start =>
            {
                // zadanie do wykonania
                _output = DateTime.Now.ToString();
            });
            //start wątku
            thread.Start();
            //dolaczanie watku do maina
            thread.Join();
            //just in case
            thread = null;
        });

        



    }
}
