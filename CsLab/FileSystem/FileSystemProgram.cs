using System;

namespace FileSystem
{
    public class FileSystemProgram
    {
        public static void Run()
        {
            Directory root = new Directory("root");

            File file1 = new File("readme.txt", 1200);
            File file2 = new File("photo.jpg", 204800);
            Directory docs = new Directory("docs");
            File file3 = new File("doc1.pdf", 56000);
            File file4 = new File("doc2.pdf", 44000);

            root.Add(file1);
            root.Add(file2);
            root.Add(docs);

            docs.Add(file3);
            docs.Add(file4);

            Directory music = new Directory("music");
            music.Add(new File("song.mp3", 5000000));
            music.Add(new File("track.flac", 12000000));

            root.Add(music);

            root.Display();

            Console.WriteLine();
            Console.WriteLine("Общий размер root: " + root.GetSize() + " bytes");
        }
    }
}
