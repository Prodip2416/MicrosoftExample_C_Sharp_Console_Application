using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace assembliesAndNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            string replay = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(replay);
            File.WriteAllText(@"E:\Programming With DOT NET\C# Console Application\Microsoft Tutorial\NameSpace\WriteText.txt", replay);
            Console.ReadLine();
        }
    }
}
