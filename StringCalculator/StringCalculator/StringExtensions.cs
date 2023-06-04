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
            if (str.StartsWith("//")) // new delimiter
            {
                var splitted = str.Split('\n');
                var separator = splitted[0].Split("//")[1];
                var x = splitted[1].Split(separator);
                if (x.Any( s => s.Length != 1))
                {
                    foreach (var n in x)
                    {
                        if (n.Length != 1)
                        {
                            int count = 0;
                            var wrongSep = n.Substring(1, 1);
                            foreach (var c in splitted[1])
                            {
                                if (c.ToString().Equals(wrongSep))
                                {
                                    break;
                                }else
                                {
                                    count++;
                                }
                            }
                            var message = $"'{separator}' expected but '{wrongSep}' found at position {count}";
                            throw new Exception(message);
                        }
                    }  
                }
                return splitted[1].Split(separator).Select(n => int.Parse(n)).ToArray();
            }
            if (str.EndsWith (",")) // invalid
            {
                throw new Exception();
            }
            if (str.Contains('\n')) // new line delimiter
            {
                var splitted = str.Split('\n');
                var res = new List<int>();
                foreach (var line in splitted)
                {
                    if (line.StartsWith(",") || line.EndsWith(",")) // invalid
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
            return str.Split(",").Select( n => int.Parse(n)).ToArray(); // only comma delimiter
            
        }
    }
}
