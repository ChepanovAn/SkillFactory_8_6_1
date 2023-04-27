using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_8_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "/Users/Анатолий/Desktop/Example";

            if (Directory.Exists(filePath))
            {
                DateTime dt = File.GetLastAccessTime(filePath);

                Console.WriteLine("Последнее время обращения к папке: " + dt);

                DateTime DateLimit = dt.AddMinutes(30);

                if (DateTime.Now > DateLimit)
                {
                    try
                    {
                        DirectoryInfo dirInfo = new DirectoryInfo(@"/Users/anatoliy.chepanov/Desktop/Example/");

                        foreach (FileInfo file in dirInfo.GetFiles())

                        {
                            file.Delete();
                        }
                        foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                        {
                            dir.Delete(true);
                        }

                        Console.WriteLine("Папка с ее содержимым удалена");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            else Console.WriteLine("Папка по заданному адресу не существует, передан некорректный путь.");

            Console.ReadKey();
        }
    }
}
