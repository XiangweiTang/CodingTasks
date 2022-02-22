using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodingTasks
{
    class SentenceCount
    {
        #region Output
        public int SentCount { get; private set; } = 0;
        public int WordCount { get; private set; } = 0;
        public int CharCount { get; private set; } = 0;
        #endregion

        #region Arguments
        public bool CountWord { get; set; } = false;
        public bool CountChar { get; set; } = false;
        public string Pattern { get; set; } = "*";
        #endregion

        public void Count(string path)
        {
            if (File.Exists(path))
                CountFile(path);
            else if (Directory.Exists(path))
                CountFolder(path);
            else
                throw new Exception($"Path {path} doesn't exist!");
        }

        private void CountFolder(string folderPath)
        {
            var files = Directory.EnumerateFiles(folderPath, Pattern);
            foreach (string filePath in files)
                CountFile(filePath);
        }

        private void CountFile(string filePath)
        {
            var fileContent = File.ReadLines(filePath);
            foreach(string s in fileContent)
            {
                SentCount++;
                if (CountWord)
                    WordCount += s.Split(' ').Length;
                if (CountChar)
                    CharCount += s.Length;
            }
        }
    }
}
