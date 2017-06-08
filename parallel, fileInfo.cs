using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo("data");
            var fileList = directory.GetFiles();
            int counter = 0;

            Parallel.ForEach<FileInfo>(fileList, file =>
            {
                counter = (from c in File.ReadAllText("data/" + file.Name).ToCharArray() where c == 'e' select c).Count();
                
                    WriteLine(Thread.CurrentThread.GetHashCode() + " " + counter + "");
            });
            ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = new DirectoryInfo("data");
            var fileList = directory.GetFiles();
            int counter = 0;

            Parallel.ForEach<FileInfo>(fileList, file =>
            {
                counter = (from c in File.ReadAllText("data/" + file.Name).ToCharArray() where c == 'e' select c).Count();
                
                    WriteLine(Thread.CurrentThread.GetHashCode() + " " + counter + "");
            });
            ReadLine();
        }
    }
}
