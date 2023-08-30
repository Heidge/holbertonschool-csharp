using System;

/// <summary>
/// New class obj
/// </summary>
    class Obj
    {
        /// <summary>
        /// New method for check if argument is int or not
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
