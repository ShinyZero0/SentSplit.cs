using System;
using System.IO; // Mono compatibility
using System.Text.RegularExpressions;

namespace SentSplit
// Mono compatibility
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: sentsplit --join <file> or sentsplit --split <file>");
                return;
            }
            switch (args[0])
            {
                case "--join":
                    Join(args[1]);
                    break;
                case "--split":
                    Split(args[1]);
                    break;

                default:
                    Console.WriteLine("Usage: sentsplit --join <file> or sentsplit --split <file>");
                    break;
            }
        }

        public static void Join(string source)
        {
            string[] data = File.ReadAllLines(source);
            int i = 0;
            List<string> paras = new();
            while (i < data.Length)
            {
                string firstLine = data[i];
                if (string.IsNullOrWhiteSpace(firstLine))
                {
                    i++;
                    continue;
                }
                int iLocal = i;
                var paraLines = new List<string>();
                string localLine = data[iLocal];
                while (!string.IsNullOrWhiteSpace(localLine) && iLocal < data.Length)
                {
                    localLine = data[iLocal];
                    paraLines.Add(localLine);
                    iLocal++;
                }
                i = iLocal;
                paras.Add(Regex.Replace((String.Join(" ", paraLines)), " +$", ""));
            }
            paras.ForEach(p => Console.WriteLine(p));
        }

        public static void Split(string source)
        {
            string[] data = File.ReadAllLines(source);
            var output = new List<string>();
            foreach (string line in data)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                string sentence = Regex.Replace(
                    line,
                    @"([\.\?!])\s+((--\s+)|(—\s+)?[A-ZА-Я])",
                    match =>
                    {
                        var m = match.Groups;
                        return string.Format("{0}\n{1}", m[1].ToString(), m[2].ToString());
                    }
                );
                string result = string.Format("{0}\n", sentence);
                output.Add(result);
            }
            output.ForEach(p => Console.WriteLine(p));
        }
    }
}
