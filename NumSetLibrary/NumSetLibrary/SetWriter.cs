using System;
namespace NumSetLibrary
{
	public class SetWriter: IDisposable
    {
        private readonly StreamWriter _writer;

        public SetWriter(string fileName)
        {
            _writer = new StreamWriter(fileName);
        }

        public void Write(NumSet set)
        {
            _writer.WriteLine(set.ToString());
        }

        public void Dispose()
        {
            _writer.Dispose();
        }
    }
}

