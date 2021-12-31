using System.Threading;

namespace Info.Classes
{
    class InstanceChecker
    {
        private static readonly Mutex _mutex = new(false, "Info");
        private static bool _taken;
        public static bool TakeMemory() => _taken = _mutex.WaitOne(0, true);
        public static void ReleaseMemory()
        {
            if (_taken)
                try { _mutex.ReleaseMutex(); } catch { }
        }

    }
}
