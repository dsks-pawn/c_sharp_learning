using System;
using System.Text;
using System.Text.RegularExpressions;

namespace lesson9Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            // #region
            // string str = "-howkteam.com 10092016-";
            // Regex reg = new Regex(@"\d");
            // Match result = reg.Match(str);

            // // cach 1
            // do
            // {
            //     Console.WriteLine(result.ToString());
            //     result = result.NextMatch();
            // } while (result != Match.Empty);

            // //cach 2
            // foreach (Match item in reg.Matches(str))
            // {
            //     Console.WriteLine(item.ToString());
            // }
            // #endregion

            // #region
            // string str2 = "30/04/2017 10:15:12 192.168.1.2";
            // // Regex reg2 = new Regex(@"\d+:\d+:\d+");
            // Regex reg2 = new Regex(@"(?<hours>\d+):(?<minutes>\d+):(?<seconds>\d+)");
            // foreach (Match item in reg2.Matches(str2))
            // {
            //     Console.WriteLine("Match: " + item.ToString());
            //     Console.WriteLine("Hours: " + item.Groups["hours"]);
            //     Console.WriteLine("Minutes: " + item.Groups["minutes"]);
            //     Console.WriteLine("Seconds: " + item.Groups["seconds"]);
            // }
            // #endregion

            #region
            string str3 = "10:15:12 IBM 192.168.1.2 INTEL";
            Regex reg3 = new Regex(@"(?<times>(\d|:)+)\s" + @"(?<company>(\S+))\s" + @"(?<ip>(\d|.)+)\s" + @"(?<company>\S+)");
            foreach (Match item in reg3.Matches(str3))
            {
                Console.WriteLine("Match: " + item.ToString());
                Console.WriteLine("times: " + item.Groups["times"]);
                Console.WriteLine("company: " + item.Groups["company"]);
                Console.WriteLine("ip: " + item.Groups["ip"]);

                foreach (Capture itemCompany in item.Groups["company"].Captures)
                {
                    Console.WriteLine("company...: " + itemCompany.ToString());
                }
            }
            #endregion

        }
    }
}
