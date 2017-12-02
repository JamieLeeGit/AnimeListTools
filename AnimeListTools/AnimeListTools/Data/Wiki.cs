using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeListTools.Data
{
    class Wiki
    {
        public enum RegexGroupName
        {
            Year,
            Month,
            Name,
            Studio,
            Episodes
        }

        public static readonly string YearPattern = @"日本動畫列表 \((?<Year>[0-9]{4})";
        /// <summary>
        /// Get Html Tag Position
        /// </summary>
        public static readonly string TablePattern = @"</table>";        
        /// <summary>
        /// Wiki Anime List Rubular
        /// </summary>
        public static readonly string AnimeWikiPattern = @"<td>(?<Month>[0-9]{1,2})月.*\s.*title[^>]+>(?<Name>[^<]+).*\s.*\s<td>(?<Studio>[^<]+)?.*\s<td>(?<Episodes>[^<話]+)?";

    }
}
