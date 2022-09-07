using System;

namespace AttrToNode
{
    public class Program
    {
        static void Main(string[] args)
        {
            // select the path 
            string path = @"C:\Users\Mubsshir\source\repos\AttrToNode\AttrToNode\Data.xml";
            Console.WriteLine(ReadXML.Fn_ReadXML(path));
        }
    }
}