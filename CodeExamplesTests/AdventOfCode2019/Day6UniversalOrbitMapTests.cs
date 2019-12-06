using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using CodeExamples.AdventOfCode2019;
using NUnit.Framework;

namespace CodeExamplesTests.AdventOfCode2019
{
    internal class Day6UniversalOrbitMapTests
    {
        [Test]
        public void CreateMapTestTest()
        {
            var input = new List<OrbitDesc>()
            {
                new OrbitDesc("B") { Orbiter = "C" },
                new OrbitDesc("C") { Orbiter = "D" },

                new OrbitDesc("E") { Orbiter = "F" },
                new OrbitDesc("COM") { Orbiter = "B" },
                new OrbitDesc("B") { Orbiter = "G" },
                new OrbitDesc("G") { Orbiter = "H" },

                new OrbitDesc("D") { Orbiter = "I" },
                new OrbitDesc("E") { Orbiter = "J" },
                new OrbitDesc("J") { Orbiter = "K" },
                new OrbitDesc("K") { Orbiter = "L" },
                new OrbitDesc("D") { Orbiter = "E" },
            };

            Day6UniversalOrbitMap map = new Day6UniversalOrbitMap();
            var head = new Node("COM");
            map.AddListToGraph(head, input);
            Assert.That(map.FindNode(head, "K").Orbiters.First().Center, Is.EqualTo("L"));
        }

        [Test]
        public void SumDirectIndirectOrbitsTest()
        {
            List<OrbitDesc> input = new List<OrbitDesc>
            {
                new OrbitDesc("COM") { Orbiter = "B" },
                new OrbitDesc("B") { Orbiter = "C" },
                new OrbitDesc("C") { Orbiter = "D" },
                new OrbitDesc("D") { Orbiter = "E" },
                new OrbitDesc("E") { Orbiter = "F" },

                new OrbitDesc("B") { Orbiter = "G" },
                new OrbitDesc("G") { Orbiter = "H" },

                new OrbitDesc("D") { Orbiter = "I" },
                new OrbitDesc("E") { Orbiter = "J" },
                new OrbitDesc("J") { Orbiter = "K" },
                new OrbitDesc("K") { Orbiter = "L" }
            };

            var head = new Node("COM");
            Day6UniversalOrbitMap map = new Day6UniversalOrbitMap();
            head = map.AddListToGraph(head, input);
            Assert.That(map.CountTotalOrbits(head), Is.EqualTo(42));
        }

        [Test]
        public void ImportDataAndSumDirectIndirectOrbitsTest()
        {
            Day6UniversalOrbitMap map = new Day6UniversalOrbitMap();
            IEnumerable<OrbitDesc> input =
                ReadInputFromFile.ReadFile(new FileInfo(@"AdventOfCode2019\InputData\Day6Orbits.txt"));

            var head = new Node("COM");

            head = map.AddListToGraph(head, input.ToList());
            Assert.That(map.CountTotalOrbits(head), Is.EqualTo(234446));
        }

        [Test]
        public void DistBetweenYouAndSanTest()
        {
            List<OrbitDesc> input = new List<OrbitDesc>
            {
                new OrbitDesc("COM") { Orbiter = "B" },
                new OrbitDesc("B") { Orbiter = "C" },
                new OrbitDesc("C") { Orbiter = "D" },
                new OrbitDesc("D") { Orbiter = "E" },
                new OrbitDesc("E") { Orbiter = "F" },

                new OrbitDesc("B") { Orbiter = "G" },
                new OrbitDesc("G") { Orbiter = "H" },

                new OrbitDesc("D") { Orbiter = "I" },
                new OrbitDesc("E") { Orbiter = "J" },
                new OrbitDesc("J") { Orbiter = "K" },
                new OrbitDesc("K") { Orbiter = "L" },
                new OrbitDesc("K") { Orbiter = "YOU" },
                new OrbitDesc("I") { Orbiter = "SAN" }
            };

            var head = new Node("COM");
            Day6UniversalOrbitMap map = new Day6UniversalOrbitMap();
            head = map.AddListToGraph(head, input);
            var sanNode = map.FindNode(head, "SAN");

            var distBetweenYouAndSan = map.CountDistanceBetweenPoints(sanNode, "YOU");
            var distBetweenOrbitingBodies = distBetweenYouAndSan - 2;

            Assert.That(distBetweenOrbitingBodies, Is.EqualTo(4));
        }

        [Test]
        public void ImportDataAndFindDistBetweenYouAndSanTest()
        {
            string filePath = @"AdventOfCode2019\InputData\Day6Orbits.txt";
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                filePath = filePath.Replace("\\", "/");
            }

            IEnumerable<OrbitDesc> input =
                ReadInputFromFile.ReadFile(new FileInfo(filePath));

            var head = new Node("COM");
            Day6UniversalOrbitMap map = new Day6UniversalOrbitMap();
            head = map.AddListToGraph(head, input.ToList());
            var sanNode = map.FindNode(head, "SAN");

            var distBetweenYouAndSan = map.CountDistanceBetweenPoints(sanNode, "YOU");
            var distBetweenOrbitingBodies = distBetweenYouAndSan - 2;

            Assert.That(distBetweenOrbitingBodies, Is.EqualTo(385));
        }
    }
}