using System;
using System.Collections.Generic;

namespace Joiner;

public class Program
{
    public static void Main(string[] args)
    {
        string[] data = File.ReadAllLines(args[0]);
        int i = 0;
        var paras = new List<string>();
        while (i < data.Length)
        {
            string startLine = data[i];
            if (!string.IsNullOrWhiteSpace(startLine))
            {
                int localI = i;
                var paraLines = new List<string>();
                string localLine = data[localI];
                while (!string.IsNullOrWhiteSpace(localLine) && localI < data.Length)
                {
                    localLine = data[localI];
                    paraLines.Add(localLine);
                    localI++;
                }
                i = localI;
                paras.Add(String.Join(" ", paraLines));
            }
            else
            {
                i++;
            }

        }
        paras.ForEach(p => Console.WriteLine(p));
        /* File.WriteAllLines("result.txt", paras); */
    }
    
}
