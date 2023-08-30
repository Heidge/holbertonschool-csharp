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
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;

        StringBuilder sb = new StringBuilder();
        
        sb.Append(t.Name + " Properties:");

        foreach (PropertyInfo p in pList)
        {
            sb.Append("\n" + p.Name);
        }
        sb.Append("\n" + t.Name + " Methods:");
        foreach (MethodInfo m in mList)
        {
            sb.Append("\n" + m.Name);
        }

        Console.WriteLine(sb.ToString());
    }
}
