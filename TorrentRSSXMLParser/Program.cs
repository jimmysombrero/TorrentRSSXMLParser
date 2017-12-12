using System;
using System.Threading.Tasks;

namespace TorrentXMLParser
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        static async Task MainAsync(String[] args)
        {
            NetworkUtils utils = new NetworkUtils();

            utils.Url = "";
            string xml = await utils.Get();
            Console.WriteLine(xml);
            Console.ReadLine();
        }

    }
}

