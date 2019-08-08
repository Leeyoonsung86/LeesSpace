using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoFAS_MES.CORE.Function
{
    public static class CoFAS_ThreadManager
    {
        public enum enThreadPriority
        {
            AboveNormal,
            BelowNormal,
            Highest,
            Lowest,
            Normal
        };

        private static bool isThreadAlive = false;

        public static bool ThreadAlive
        {
            get
            {
                return isThreadAlive;
            }
            set
            {
                isThreadAlive = value;
            }
        }


        public static Thread ThreadStart(enThreadPriority _enThreadPriority, Action action)
        {
            Thread thread = new Thread(() => { action(); });

            switch(_enThreadPriority)
            {
                case enThreadPriority.AboveNormal:
                    thread.Priority = ThreadPriority.AboveNormal;
                    break;
                case enThreadPriority.BelowNormal:
                    thread.Priority = ThreadPriority.BelowNormal;
                    break;
                case enThreadPriority.Highest:
                    thread.Priority = ThreadPriority.Highest;
                    break;
                case enThreadPriority.Lowest:
                    thread.Priority = ThreadPriority.Lowest;
                    break;
                case enThreadPriority.Normal:
                    thread.Priority = ThreadPriority.Normal;
                    break;
                default:
                    thread.Priority = ThreadPriority.Normal;
                    break;
            }

            thread.IsBackground = true;

            isThreadAlive = thread.IsAlive;

            thread.Start();

            return thread;
        }


    }
}
