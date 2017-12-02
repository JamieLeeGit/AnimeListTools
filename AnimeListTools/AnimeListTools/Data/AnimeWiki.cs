using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeListTools.Data
{
    class AnimeWiki
    {
        /// <summary>
        /// Play Time
        /// </summary>
        public string Quarter;
        /// <summary>
        /// Animation Name
        /// </summary>
        public string Name;
        /// <summary>
        /// Animation production company
        /// </summary>
        public string Studio;
        /// <summary>
        /// Animation Episodes
        /// </summary>
        public string Episodes;

        /// <summary>
        /// 初始化設定
        /// </summary>
        /// <param name="Quarter">Play Time</param>
        /// <param name="Name">Animation Name</param>
        /// <param name="Studio">Animation production company</param>
        /// <param name="Episodes">Animation Episodes</param>
        public AnimeWiki(string Quarter, string Name, string Studio, string Episodes)
        {
            this.Quarter = Quarter;
            this.Name = Name;
            this.Studio = Studio;
            this.Episodes = Episodes;
        }
    }
}
