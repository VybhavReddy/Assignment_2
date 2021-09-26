using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ChordFileGenerator
{
    public enum FileType
    {
        Chords,
        Tab,
        Lyrics
    }
    public class Class1
    {
        public string SongName { get; set; }
        public string Artist { get; set; }
        public FileType FileType { get; set; }
        
        FileType filetype;


        public void getdata()
        {
            List<string> lines = new List<string>();
            //SongName = s.ToString();
            //Artist = s.ToString();
            for (; ; )
            {
                Console.WriteLine("Enter the input type\n'0' if you are entering chord\n'1' if you are entering a tab\n'2' if you are entering the lyrics\nEnter any other number to end");
                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 0)
                    FileType = FileType.Chords;
                else if (ch == 1)
                    FileType = FileType.Tab;
                else if (ch == 2)
                    FileType = FileType.Lyrics;
                else
                {
                    Console.WriteLine("Wrong selection");
                    break;
                }
                filetype = FileType;

                switch (filetype)
                {
                    case FileType.Chords:
                        {
                            Console.WriteLine("Enter the chord line");
                            string str = Console.ReadLine();
                            lines.Add("Chord: " + str);
                            break;
                        }
                    case FileType.Tab:
                        {
                            Console.WriteLine("You have selected tab");
                            string str = Console.ReadLine();
                            lines.Add("     Tab      ");
                            break;
                        }
                    case FileType.Lyrics:
                        {
                            Console.WriteLine("Enter the lyric line");
                            string str = Console.ReadLine();
                            lines.Add("Lyric: " + str);
                            break;
                        }
                }
            }
            FileStream fs = new FileStream(@"C:\c# training\ASSIGNMENT_2\test.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Songname: " + SongName);
            sw.WriteLine("Artist: " + Artist);
            foreach (string str in lines)
            {
                sw.WriteLine(str);
            }
            sw.Close();
            fs.Close();
        }
        
    }
}
