using AnimeListTools.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AnimeListTools.App
{
    public class AnimeWikiConvertToTrello
    {
        public AnimeWikiConvertToTrello() { }

        public List<AnimeWikiContainer> WikiHtmlConvertToContainer(string Html)
        {
            List<AnimeWikiContainer> result = new List<AnimeWikiContainer>();
            string sourceData = Html;
            string tempHtml;
            int index;
            MatchCollection matchCollection;
            string year = Regex.Match(sourceData, Wiki.YearPattern).Groups[Wiki.RegexGroupName.Year.ToString()].Value;

            for (int Quarter = 1; Quarter < 5; Quarter++)
            {
                index = sourceData.IndexOf(Wiki.TablePattern);
                tempHtml = sourceData.Remove(index);

                matchCollection = Regex.Matches(tempHtml, Wiki.AnimeWikiPattern);
                
                foreach (Match match in matchCollection)
                {
                    result.Add(new AnimeWikiContainer(
                      Quarter,
                      year,
                      match.Groups[Wiki.RegexGroupName.Month.ToString()].Value,
                      match.Groups[Wiki.RegexGroupName.Name.ToString()].Value,
                      match.Groups[Wiki.RegexGroupName.Studio.ToString()].Value,
                      match.Groups[Wiki.RegexGroupName.Episodes.ToString()].Value));
                }

                sourceData = sourceData.Remove(0, index+ Wiki.TablePattern.Length);
            }

            return result;
        }

        
    }
}
