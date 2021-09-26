using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly A_name = Assembly.LoadFile(@"C:\c# training\ASSIGNMENT_2\ChordFileGenerator\ChordFileGenerator\bin\Debug\ChordFileGenerator.dll");
            Type name = A_name.GetType("ChordFileGenerator.Class1");
            object obj = Activator.CreateInstance(name);
            Console.WriteLine("Enter the song name");
            object[] S = new object[2];
            S[0] = Console.ReadLine();
            Console.WriteLine("Enetr the name of artist");
            S[1] = Console.ReadLine();
            MethodInfo getdata = name.GetMethod("getdata");
            PropertyInfo p = obj.GetType().GetProperty("SongName");
            p.SetValue(obj, S[0]);
            p = obj.GetType().GetProperty("Artist");
            p.SetValue(obj, S[1]);
            getdata.Invoke(obj, args=null);
            Console.Read();
        }
    }
}
