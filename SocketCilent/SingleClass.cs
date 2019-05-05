using System;
using System.Collections.Generic;
using System.Text;

namespace SocketCilent
{
    public abstract class SingleClass<T> where T :class, new()
    {
        private static T m_instance;
        private static readonly object syn = new object();
        public static T instance
        {
            get
            {
                if (m_instance == null)
                {
                    m_instance = new T();
                }
                return m_instance;
            }
        }
        public static T CreateInstance()
        {
            if (m_instance == null)
            {
                lock (syn)  //加锁防止多线程
                {
                    if (m_instance == null)
                    {
                        m_instance = new T();
                    }
                }
            }
            return m_instance;
        }
    }
}
