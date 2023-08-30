using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

class Obj
{
    public static void Print(object myObj)
    {
        Type myObjType = myObj.GetType();
        TypeInfo t = myObjType.GetTypeInfo();
        PropertyInfo[] pList = t.GetProperties();
        MethodInfo[] mList = t.GetMethods();

        Console.WriteLine(t.Name + " Properties:");
        foreach (PropertyInfo p in pList)
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine(t.Name + " Methods:");
        foreach (MethodInfo m in mList)
        {
            Console.WriteLine(m.Name);
        }
    }
}
