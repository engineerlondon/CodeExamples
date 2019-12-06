using System;
using System.Collections.Generic;
using System.IO;

namespace CodeExamples.AdventOfCode2019.Day6
{
    public class ReadInputFromFile
    {
        public static IEnumerable<OrbitDesc> ReadFile(FileInfo fi)
        {
            if (!fi.Exists)
                throw new ArgumentException(@"The file {fi.FullName} does not exist.");

            var result = new List<OrbitDesc>();
            using (TextReader tr = new StreamReader(fi.OpenRead()))
            {
                string line;
                while ((line = tr.ReadLine()) != null)
                {
                    string[] parts = line.Split(')');
                    result.Add(new OrbitDesc(parts[0]) { Orbiter = parts[1] });
                }
            }

            return result;
        }
    }
}