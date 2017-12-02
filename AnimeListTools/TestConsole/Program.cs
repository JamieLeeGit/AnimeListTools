using AnimeListTools.App;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            AnimeWikiConvertToTrello animeWikiConvertToTrello = new AnimeWikiConvertToTrello();
            animeWikiConvertToTrello.WikiHtmlConvertToContainer(File.ReadAllText(@"F:\JamieGit\source.html"));
        }
    }
}
