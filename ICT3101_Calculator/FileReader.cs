using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator
{
    public sealed class FileReader : IFileReader
    {
        private FileReader() { }
        private static FileReader _instance;
        private static readonly object _lock = new object();

        public static FileReader GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FileReader();
                    }
                }
            }
            return _instance;
        }
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}
