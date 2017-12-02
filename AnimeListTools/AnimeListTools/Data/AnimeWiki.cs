using System;
using System.Collections.Generic;
using System.Text;

namespace AnimeListTools.Data
{
    /// <summary>
    /// For Trolle Use
    /// </summary>
    public class AnimeWikiContainer
    {
        public string Year;
        /// <summary>
        /// Play Time
        /// </summary>
        public string Month;
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
        /// Initialize
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="Month">Play Time</param>
        /// <param name="Name">Animation Name</param>
        /// <param name="Studio">Animation production company</param>
        /// <param name="Episodes">Animation Episodes</param>
        public AnimeWikiContainer(string Year, string Month, string Name, string Studio, string Episodes)
        {
            this.Year = Year;
            this.Month = Month;
            this.Name = Name;
            this.Studio = Studio;
            this.Episodes = Episodes;
        }
    }
}
