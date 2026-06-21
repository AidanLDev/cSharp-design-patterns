using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Principles.SOLID.SingleResponsibility
{
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
}
