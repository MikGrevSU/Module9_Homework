using System;
using System.Collections.Generic;
using System.Linq;

namespace FileSystem
{
    public class Directory : FileSystemComponent
    {
        List<FileSystemComponent> children = new List<FileSystemComponent>();

        public Directory(string name) : base(name)
        {
        }

        public bool Add(FileSystemComponent component)
        {
            if (component == null) return false;
            if (children.Any(c => c.Name == component.Name)) return false;
            children.Add(component);
            return true;
        }

        public bool Remove(string name)
        {
            var item = children.FirstOrDefault(c => c.Name == name);
            if (item == null) return false;
            children.Remove(item);
            return true;
        }

        public override long GetSize()
        {
            long total = 0;
            foreach (var c in children)
                total += c.GetSize();
            return total;
        }

        public override void Display(string indent = "")
        {
            Console.WriteLine($"{indent}+ {Name} ({GetSize()} bytes)");
            string next = indent + "  ";
            foreach (var c in children)
                c.Display(next);
        }
    }
}
