using System.IO;

namespace Csharp
{
    public class BinaryFile
    {
        void Run() {
            string path = @"C:\doc.txt";
            StreamReader sr = new StreamReader(path);   
            
            sr.ReadLine();
            sr.Close();

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("");
            sw.Close();

            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryReader bw = new BinaryReader(fs);
        }
    }
}