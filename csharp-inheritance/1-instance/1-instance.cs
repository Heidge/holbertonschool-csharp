using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// New class Obj
/// </summary>
    class Obj
    {
        /// <summary>
        /// new method for determine if obj is an array or not
        /// </summary>
        /// <param name="obj">first argument</param>
        /// <returns>true if obj is an array, otherwise false</returns>
        public static bool IsInstanceOfArray(object obj)
        {
            Type objType = obj.GetType();
            if (typeof(Array).IsAssignableFrom(objType) )
                return true;
            else
            {
                return false;
            }
        }
    }

