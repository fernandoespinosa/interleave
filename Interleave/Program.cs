using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Interleave
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var interleave = File.ReadAllLines("Input/Input-1.txt").Interleave(File.ReadAllLines("Input/Input-2.txt"));
            foreach (var line in interleave)
            {
                Console.WriteLine(line);
            }
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Interleave<T>(this IEnumerable<T> e1, IEnumerable<T> e2)
        {
            return e1.Zip(e2, (arg1, arg2) => new[] { arg1, arg2 }).SelectMany(t => t);
        }
    }
}
