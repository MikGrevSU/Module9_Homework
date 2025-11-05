using System;

namespace FileSystem
{
    public abstract class FileSystemComponent
    {
        public string Name { get; protected set; }

        public FileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract long GetSize();
        public abstract void Display(string indent = "");
    }
}
