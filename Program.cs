using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinkedInLinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Titles = { "new graduate", "new grad", "yeni mezun","junior" };
            string[] JobTitles = { "Software Developer", "Web Developer", ".NET Developer",".NET Software Engineer", "Full Stack%20Developer" };
            string[] Cities = { "Izmır", "Istanbul", "Ankara"};
            string ChangedLink = $"https://www.linkedin.com/jobs/search/?&keywords=JobTitles%20Titles%20NOT%20Senior&location=Cities%2C%20Turkey&refresh=true";
            StringBuilder LinkSb = new StringBuilder();
           
            for (int i = 0; i < Titles.Count(); i++)
            {
             Titles[i] = Replacer(Titles[i]);
                
            }
            for ( int i = 0; i < JobTitles.Count(); i++)
            {
               JobTitles[i] = Replacer(JobTitles[i]);
               JobTitles[i] = Replacer(JobTitles[i]);
            }


            for (int i = 0; i < JobTitles.Count(); i++)
            {
                string link = ChangedLink;
              
                link = link.Replace("JobTitles", JobTitles[i]);
                for (int x = 0; x < Titles.Count(); x++)
                {
                    string JChangeLink = link;
                    JChangeLink = link.Replace("Titles", Titles[x]);
                   
                    for (int y = 0; y < Cities.Count(); y++)
                    {
                        string CChangeLink = JChangeLink;
                        CChangeLink = JChangeLink.Replace("Cities", Cities[y]);
                        LinkSb.AppendLine(CChangeLink);
                    }
                }
            }
            Console.WriteLine(LinkSb);
            Console.ReadLine();
        }
        public static string Replacer(string word)
        {
            if (word.Contains(" ")) word = word.Replace(" ", "%20");

           return word;
        }
    }
}
