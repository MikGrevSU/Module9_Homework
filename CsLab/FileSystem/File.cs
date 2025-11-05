using System;

namespace FileSystem
{
    public class File : FileSystemComponent
    {
        long size;

        public File(string name, long size) : base(name)
        {
            this.size = size;
        }

        public override long GetSize()
        {
            return size;
        }

        public override void Display(string indent = "")
        {
            Console.WriteLine($"{indent}- {Name} ({GetSize()} bytes)");
        }
    }
}
