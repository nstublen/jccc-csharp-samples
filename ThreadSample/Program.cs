using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JCCC.Samples.ThreadSample
{
    class Program
    {
        static object mSharedIntLock = new object();
        static int mSharedInt = 0;

        static void UpdateSharedInt()
        {
            for (int index = 0; index < 10000; ++index)
            {
                // The lock statement is necessary to serialize
                // access to mSharedInt. When it is commented out,
                // multiple threads will interfere with one
                // another's updates.

                //lock (mSharedIntLock)
                {
                    int value = mSharedInt;
                    value++;
                    mSharedInt = value;
                }
            }
        }

        static void ThreadProc()
        {
            UpdateSharedInt();
        }

        static void Main(string[] args)
        {
            int passes = 0;
            do
            {
                mSharedInt = 0;
                passes++;

                Thread t1 = new Thread(new ThreadStart(ThreadProc));
                t1.Start();

                Thread t2 = new Thread(new ThreadStart(ThreadProc));
                t2.Start();

                t1.Join();
                t2.Join();
            } while (passes < 1000 && mSharedInt == 30000);

            MessageBox.Show("Count = " + mSharedInt + " on pass " + passes);
        }
    }
}
