using System;

    class Obj
    {
        /// <summary>
        /// New class named Obj
        /// </summary>
        /// <param name="obj">first argument passed</param>
        /// <returns>true if obj is int, otherwise false</returns>
        public static bool IsOfTypeInt(object obj)
        {
            if (obj.GetType() == typeof(int))
                return true;
            else
            {
                return false;
            }
        }
    }
