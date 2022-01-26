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
            uint temp;
            DateTime date = DateTime.Today;

            WriteLine("ID");
            while (true)
            {
                if (uint.TryParse(ReadLine(), out temp))
                {
                    Str += temp + $"#{DateTime.Today}#";
                    break;
                }
                else
                {
                    WriteLine("Не корректное значение");
                }
            }
            WriteLine("Ф.И.О.");
            Str += ReadLine() + "#";

            WriteLine("Возраст");
            while (true)
            {
                if (uint.TryParse(ReadLine(), out temp))
                {
                    Str += temp + "#";
                    break;
                }
                else
                {
                    WriteLine("Не корректное значение");
                }
            }
            WriteLine("Рост");
            while (true)
            {
                if (uint.TryParse(ReadLine(), out temp))
                {
                    Str += temp + "#";
                    break;
                }
                else
                {
                    WriteLine("Не корректное значение");
                }
            }
            WriteLine("Дата рождения в формате дд.мм.гггг");
            while (true)
            {
                if (DateTime.TryParse(ReadLine(), out date))
                {
                    Str += date.ToString("dd.mm.yyyy") + "#";
                    break;
                }
                else
                {
                    WriteLine("Не корректное значение");
                }
            }
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
                Clear();
                if (Str == "1")
                {
                    ReadText(@"TestList");
                    ReadKey();
                }
                else if (Str == "2")
                {
                    AddText(@"TestList");
                }
                else if (Str == "3")
                {
                    break;
                }
                Clear();
            } while (true);
        }
    }
}
