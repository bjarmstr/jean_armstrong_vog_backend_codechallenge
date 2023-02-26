using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VogCodeChallenge.ConsoleApp
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffery",
            "John",
        };

        public static List<string>  NamesToAllCaps()
        {
            var namesAllCaps = new List<string>();
            NamesList.ForEach(name => namesAllCaps.Add(name.ToUpper()));
            return namesAllCaps;
        }


    }
}
