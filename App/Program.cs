using BenchmarkDotNet.Running;

namespace App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var benchmarks = new[]
            {
                typeof(SortedArrayBench),
                typeof(UnsortedArrayBench)
            };

            var switcher = new BenchmarkSwitcher(benchmarks);
            switcher.Run(args);
        }
    }
}
