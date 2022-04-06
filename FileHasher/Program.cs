using System;
using System.IO;

namespace FileHasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de um arquivo na sua área de trabalho.");
            byte[] fileData;
            var filePath = Environment.GetEnvironmentVariable("UserProfile") + "\\Desktop\\";
            try
            {
                filePath += Console.ReadLine();
                fileData = File.ReadAllBytes(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            IDataHasher dataHasher = new SHA256DataHasher();

            Console.WriteLine(dataHasher.GetHash(fileData));
        }
    }
}
