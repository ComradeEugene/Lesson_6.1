using System;
using System.IO;
using static System.Console;

namespace Lesson_6
{
    class MainClass
    {
        static void ReadText(string path)
        {
            using ()
            {

            }
        }

        static void AddText(string path)
        {
            string Str = string.Empty;
            DateTime date = new DateTime();

            if (!File.Exists(path))
            {
                File.Create(path);
            }
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
                WriteLine("Нажмите 1 для выво данных на экран или 2 для " +
                            "добавления новой записи");
                string Str = ReadLine();
                if (Str == "1")
                {

                }
                else if (Str == "2")
                {

                }
            } while (true);
        }
    }
}
