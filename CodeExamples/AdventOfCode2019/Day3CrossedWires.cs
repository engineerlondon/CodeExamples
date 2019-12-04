using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeExamples.AdventOfCode2019
{
    public class Day3CrossedWires
    {
        private HashSet<Point> _firstNodes = new HashSet<Point>(new PointComp());

        private int shortestDist = int.MaxValue;
        public int shortestSteps = int.MaxValue;

        public long AddWire1CrossedWires(List<string> input)
        {
            var currentLocation = new Point(0, 0, 0);
            bool first = !(_firstNodes.Count > 0);

            foreach (var vector in input)
            {
                int distance = int.Parse(vector.Substring(1, vector.Length - 1));
                var direction = vector.Substring(0, 1);

                for (int i = 0; i < distance; i++)
                {
                    if (direction.Equals("R"))
                        currentLocation.X++;
                    else if (direction.Equals("L"))
                        currentLocation.X--;
                    else if (direction.Equals("U"))
                        currentLocation.Y++;
                    else if (direction.Equals("D"))
                        currentLocation.Y--;

                    currentLocation.Steps++;

                    var path = new Point(currentLocation.X, currentLocation.Y, currentLocation.Steps);

                    if (!first && _firstNodes.Contains(path))
                    {
                        if (shortestDist > currentLocation.GetDist())
                            shortestDist = currentLocation.GetDist();
                        int firstPointSteps = _firstNodes
                            .FirstOrDefault(_ => _.X == currentLocation.X && _.Y == currentLocation.Y).Steps;
                        if (shortestSteps > currentLocation.Steps + firstPointSteps)
                            shortestSteps = currentLocation.Steps + firstPointSteps;
                    }
                    if (first)
                        _firstNodes.Add(path);
                }
            }

            return shortestDist;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Steps { get; set; }

        public Point(int x, int y, int steps)
        {
            X = x;
            Y = y;
            Steps = steps;
        }

        public int GetDist()
        {
            return Math.Abs(X) + Math.Abs(Y);
        }
    }

    public class PointComp : IEqualityComparer<Point>
    {
        public bool Equals(Point a, Point b)
        {
            if (a == null || b == null)
                return false;

            return a.X.Equals(b.X) && a.Y.Equals(b.Y);
        }

        public int GetHashCode(Point obj)
        {
            return new { obj.X, obj.Y }.GetHashCode();
        }
    }
}