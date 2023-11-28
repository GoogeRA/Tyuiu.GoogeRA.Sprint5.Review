using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;



//Удалить все удвоенные буквы "сс" из файла.Полученный результат сохранить в файл OutPutDataFileTask7V19.txt.
namespace Tyuiu.GoogeRA.Sprint5.Task7.V9.Lib
{
    public class DataService 
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V9.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strLine = Regex.Replace( line , "[A-Z]", "");
                       
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }

            }
            return pathSaveFile;
            
        }
    }

    
                        
}
