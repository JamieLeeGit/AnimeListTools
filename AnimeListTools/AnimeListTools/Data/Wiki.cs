using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeListTools.Data
{
    class Wiki
    {
        /// <summary>
        /// Wiki Anime List Rubular
        /// </summary>
        public readonly string AnimeWikiPattern = @"title[^>]+>(?<Name>[^<]+).*\s.*\s<td>(?<Studio>[^<]+)?.*\s<td>(?<Episodes>[^<]+)?";
    }
}
