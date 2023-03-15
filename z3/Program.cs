using System;
using System.Collections.Generic;
using System.IO;

namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();

            using (StreamWriter sw = new StreamWriter(@"C:\z33\textic.txt"))
            {
                sw.WriteLine("Модификации");
                sw.WriteLine("Один два три два один три десять");
                sw.WriteLine("Исчезновение кого-то странного");
                sw.WriteLine("А это Люда");
                sw.WriteLine("Люда");
            }

            using (StreamReader sr = new StreamReader(@"C:\z33\textic.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            Console.WriteLine("Содержимое файла:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine(new string('-', 50));
            int numLines = lines.Count;
            Console.WriteLine("Количество строк: {0}", numLines);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Количество символов в каждой строке:");
            foreach (string line in lines)
            {
                Console.WriteLine("{0}: {1}", line, line.Length);
            }

            string lastLine = lines[numLines - 1];
            lines.RemoveAt(numLines - 1);
            using (StreamWriter sw = new StreamWriter(@"C:\z33\textic.txt"))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Удаленная строка: {0}", lastLine);
            Console.WriteLine(new string('-', 50));

            int s1 = 1; 
            int s2 = 3; 
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Строки с {0} по {1}:", s1, s2);
            for (int i = s1 - 1; i < s2; i++)
            {
                Console.WriteLine(lines[i]);
            }

            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Самая длинная строка имеет длину {0} символов.", maxLength);
            Console.WriteLine(new string('-', 50));
           
            char startingChar = 'М';
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Строки, начинающиеся с буквы '{0}':", startingChar);
           
            foreach (string line in lines)
            {
                if (line.StartsWith(startingChar.ToString()))
                {
                    Console.WriteLine(line);
                }
            }

            lines.Reverse(); 
            using (StreamWriter sw = new StreamWriter(@"C:\z33\reversed.txt"))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line);
                }
            }
            Console.WriteLine("\nСтроки переписаны в обратном порядке в файл 'reversed.txt'.");
        }
    }
}