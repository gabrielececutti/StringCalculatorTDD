using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorLibrary
{
    public static class StringExtensions
    {
        public static int[] ToIntArray (this string str)
        {
            if (str.Contains('\n'))
            {
                var splitted = str.Split('\n');
                var res = new List<int>();
                foreach (var line in splitted)
                {
                    if (line.StartsWith(",") || line.EndsWith(","))
                    {
                        throw new Exception();
                    }
                    if (line.Contains(','))
                    {
                        var split = line.Split(',');
                        var numbers = split.Select(n => int.Parse(n));
                        res.AddRange(numbers);
                    }
                    else
                    {
                        res.Add(int.Parse(line));
                    }
                }
                return res.ToArray();
            }
            if (string.IsNullOrEmpty(str))
            {
                return new int[0];
            }
            return str.Split(",").Select( n => int.Parse(n)).ToArray();
            
        }
    }
}
