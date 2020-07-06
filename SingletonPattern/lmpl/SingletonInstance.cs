using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    internal class SingletonInstance
    {
        private static volatile SingletonInstance _instance;
        private static readonly object _lock = new object();

        private SingletonInstance()
        {

        }

        public SingletonInstance GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonInstance();
                    }
                }
            }

            return _instance;
        }
    }
}
