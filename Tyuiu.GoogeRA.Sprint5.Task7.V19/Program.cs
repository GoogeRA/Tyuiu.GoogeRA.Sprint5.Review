using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.GoogeRA.Sprint5.Task7.V9.Lib;

namespace Tyuiu.GoogeRA.Sprint5.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5| Выполнил :  Гооге Р.A. | ПКТб-23-1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #5                                                  *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту   *");
            Console.WriteLine("* Задание #7                                                 *");
            Console.WriteLine("* Вариант #9                                                *");
            Console.WriteLine("* Выполнил :  Гооге Роберт Aлексндрович | ПКТб-23-1          *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Создать папку в ручную С:DataSprint5                       *");
            Console.WriteLine("* в котором есть набор символьных данных.                    *");
            Console.WriteLine("* Удалить все удвоенные буквы сс из файла. Полученный        *");
            Console.WriteLine("* результат сохранить в файл OutPutDataFileTask7V19.txt.     *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine("**************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V9.txt";

            string pathSaveFile = @"C:\DataSprint5\InPutDataFileTask7V9.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("Находятся в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);

            Console.ReadKey();
        }
    }
}  
