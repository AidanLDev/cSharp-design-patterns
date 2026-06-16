
using System.Diagnostics;

namespace SingleResponsiblity
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int idx)
        {
            entries.RemoveAt(idx);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

    }

    public class FileStorage
    {
        public void saveToFile<T>(string path, T file)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, file.ToString());
            }
        }
    }

    public class SingleResponsibility
    {
        public static void openFile(string fileName)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = fileName,
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }
        static void Main(string[] args)
        {
            Journal newJournal = new Journal();
            newJournal.AddEntry("I cry today");
            newJournal.AddEntry("I did a cool thing");
            FileStorage fileStorage = new FileStorage();
            string fileName = @"c:\tmp\journal.txt";
            fileStorage.saveToFile(fileName, newJournal);
            openFile(fileName);
            Console.WriteLine(newJournal);
        }
    }
}