﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structures.Singleton
{
    public abstract class Single<T> where T : class, new()
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new T();
                return _instance;
            }
        }
    }
}
