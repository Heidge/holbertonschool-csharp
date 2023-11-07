using System;
/// <summary>
/// New generic list Queue of type T
/// </summary>
/// <typeparam name="T"></typeparam>
    class Queue<T>
    {
        /// <summary>
        /// New function for check type
        /// </summary>
        /// <returns>Type of T</returns>
        public Type CheckType()
        {
            return(typeof(T));
        }
    }
