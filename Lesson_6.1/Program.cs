using System;
using System.IO;
using static System.Console;

namespace Lesson_6
{
    class MainClass
    {
        static void ReadText(string path)
        {
            if (File.Exists(path))
            {
                using (StreamReader Sr = new StreamReader(path))
                {
                    while (!Sr.EndOfStream)
                    {
                        string[] arr = (Sr.ReadLine()).Split('#');
                        foreach (var e in arr)
                        {
                            Write($"{e} ");
                        }
                        WriteLine();
                    }
                }
            }
            else
            {
                WriteLine("Нет записей");
            }
        }

        static void AddText(string path)
        {
            string Str = string.Empty;
            DateTime date = DateTime.Today;

            WriteLine("ID");
            Str += ReadLine() + $"#{date}#";

            WriteLine("Ф.И.О.");
            Str += ReadLine() + "#";

            WriteLine("Возраст");
            Str += ReadLine() + "#";

            WriteLine("Рост");
            Str += ReadLine() + "#";

            WriteLine("Дата рождения");
            Str += ReadLine() + "#";

            WriteLine("Место рождения");
            Str += ReadLine() + "\n";
            File.AppendAllText(path, Str);
        }

        public static void Main(string[] args)
        {
            do
            {
                WriteLine("1 для вывода данных на экран\n2 для " +
                            "добавления новой записи\n3 для выхода");
                string Str = ReadLine();
                if (Str == "1")
                {
                    ReadText(@"/Users/evgenijvolkov/Desktop/TestList");
                }
                else if (Str == "2")
                {
                    AddText(@"/Users/evgenijvolkov/Desktop/TestList");
                }
                else if (Str == "3")
                {
                    break;
                }
            } while (true);
        }
    }
}
