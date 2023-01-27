using System.IO;

using System;
namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string _FilePath { get; }
        public FileLogger(string filePath) { _FilePath = filePath; }

        public override void Log(LogLevel logLevel, string message)
        {
            if (!string.IsNullOrEmpty(_FilePath))
            {
                File.AppendAllText(_FilePath, $"{DateTime.Now}{ClassName}{logLevel + ":"} {message}\n");

            }
            else
            {
                throw new ArgumentException("the file path is empty!");
            }
        }
    }
}

