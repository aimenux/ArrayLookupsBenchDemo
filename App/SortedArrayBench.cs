using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    [Config(typeof(BenchConfig))]
    [BenchmarkCategory(nameof(BenchCategory.Sorted))]
    public class SortedArrayBench
    {
        private int[] array;
        private int valueToLook;
        private HashSet<int> hashset;

        [Params(1000, 10000, 100000, 1000000)]
        public int Size { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            valueToLook = random.Next();
            array = Enumerable.Range(0, Size)
                .Select(x => random.Next())
                .ToArray();
            Array.Sort(array);
            hashset = new HashSet<int>(array);
        }

        [Benchmark]
        public bool UsingArrayExists()
        {
            Predicate<int> predicate = x => x == valueToLook;
            return Array.Exists(array, predicate);
        }

        [Benchmark]
        public bool UsingArrayContains()
        {
            return array.Contains(valueToLook);
        }

        [Benchmark]
        public bool UsingArrayBinarySearch()
        {
            return Array.BinarySearch(array, valueToLook) >= 0;
        }

        [Benchmark]
        public bool UsingHashsetContains()
        {
            return hashset.Contains(valueToLook);
        }
    }
}
