using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Algorithms.Arrays
{
    public class ReorderLogs
    {
        public static string[] ReorderLogFiles(string[] logs)
        {
            List<string> letterLogList = new List<string>();
            List<string> digitLogList = new List<string>();
            for (int i = 0; i < logs.Length; i++)
            {
                string log = logs[i];
                string logValue = log.Split(' ')[1];
                // Check if 2nd words is number
                //   if (!Char.IsDigit(log.Substring(log.IndexOf(" ")).Replace(" ", string.Empty)[0]))
                if (!double.TryParse(logValue, out double n))
                {
                    letterLogList.Add(log);
                }
                else
                {
                    digitLogList.Add(log);
                }
            }

            // Lexicographically order the letterLogList
            var result = letterLogList.OrderBy(l => l.Substring(l.IndexOf(" "))).
                ThenBy(l => l.Split(' ')[0]).ToList();

            result.AddRange(digitLogList);
            return result.ToArray();
        }
    }
}
