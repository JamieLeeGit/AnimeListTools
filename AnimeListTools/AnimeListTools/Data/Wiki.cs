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
        public static readonly string WikiUri= "https://zh.wikipedia.org/wiki/%E6%97%A5%E6%9C%AC%E5%8B%95%E7%95%AB%E5%88%97%E8%A1%A8_({}%E5%B9%B4)"
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
