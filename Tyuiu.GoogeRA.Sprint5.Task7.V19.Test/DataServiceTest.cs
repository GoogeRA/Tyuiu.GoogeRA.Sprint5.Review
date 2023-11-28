using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.GoogeRA.Sprint5.Task7.V9.Lib;


namespace Tyuiu.GoogeRA.Sprint5.Task7.V9.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}

if (line[i] != 'H' && line[i] != 'F' && (line[i] != 'I') && (line[i] != 'M') && (line[i] != 'P') && i != line.Length)
{
    strLine = strLine + line[i];