using System.IO;

namespace TestFramework
{
    public class FileUtils
    {
        public void ReadData()
        {
            FileStream fileStream = File.OpenRead("C:\\Users\\flaviu.cos\\Documents\\Visual Studio 2015\\Projects\\TestFramework\\files\\file.txt");
            TextReader textReader = new StreamReader(fileStream);

            char nextCharacter = (char)textReader.Read();

            char[] bufferToPutStuffIn = new char[2];
            textReader.Read(bufferToPutStuffIn, 0, 2);
            string whatWasReadIn = new string(bufferToPutStuffIn);

            string restOfLine = textReader.ReadLine();

            textReader.Close();

        }
    }
}