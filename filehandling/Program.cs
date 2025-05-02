namespace filehandling
{
    internal class Fileexample
    {
        static void Main(string[] args)
        {
            FileInfo fo = new FileInfo("D:\\programming\\c#\\myfile.txt");
            FileStream fs = fo.Open(FileMode.OpenOrCreate , FileAccess.Write, FileShare.Read);
           StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine("new check record");
            sw.Close();

           // StreamReader sr = new StreamReader(fs);
           //string data = sr.ReadToEnd();
            //Console.WriteLine(data);

           Console.WriteLine("File created succesfully ");
        }
    }
}
