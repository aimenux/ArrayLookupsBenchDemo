![.NET 5](https://github.com/aimenux/ArrayLookupsBenchDemo/workflows/.NET%205/badge.svg)

# ArrayLookupsBenchDemo
```
Benchmarking various ways for array lookups
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of array lookups :
>
> :one: Using array exists
>
> :two: Using array contains
>
> :three: Using array binary search (used only for sorted arrays)
>
> :four: Using hashset contains (copying operation is not benchmarked)
>

In order to run benchmarks, type these commands in your favorite terminal :
>
> :writing_hand: `.\App.exe --filter SortedArrayBench`
>
> :writing_hand: `.\App.exe --filter UnsortedArrayBench`
>

```
|                 Method |    Size |             Mean |          Error |         StdDev |              Min |              Max | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |-------- |-----------------:|---------------:|---------------:|-----------------:|-----------------:|-----:|-------:|------:|------:|----------:|
|   UsingHashsetContains |    1000 |         6.051 ns |      0.1488 ns |      0.1319 ns |         5.874 ns |         6.249 ns |    1 |      - |     - |     - |         - |
| UsingArrayBinarySearch |    1000 |        25.052 ns |      0.5276 ns |      0.4935 ns |        24.201 ns |        25.898 ns |    2 |      - |     - |     - |         - |
|     UsingArrayContains |    1000 |       274.035 ns |      1.3930 ns |      1.2349 ns |       271.018 ns |       276.504 ns |    3 |      - |     - |     - |         - |
|       UsingArrayExists |    1000 |     2,075.331 ns |     37.0969 ns |     53.2033 ns |     2,009.364 ns |     2,190.756 ns |    4 | 0.0191 |     - |     - |      64 B |
|                        |         |                  |                |                |                  |                  |      |        |       |       |           |
|   UsingHashsetContains |   10000 |         4.599 ns |      0.1199 ns |      0.1063 ns |         4.436 ns |         4.775 ns |    1 |      - |     - |     - |         - |
| UsingArrayBinarySearch |   10000 |        32.041 ns |      0.5991 ns |      0.5604 ns |        31.170 ns |        32.962 ns |    2 |      - |     - |     - |         - |
|     UsingArrayContains |   10000 |     2,654.858 ns |     52.7464 ns |     99.0706 ns |     2,510.247 ns |     2,907.659 ns |    3 |      - |     - |     - |         - |
|       UsingArrayExists |   10000 |    20,297.634 ns |    214.6080 ns |    200.7444 ns |    19,833.006 ns |    20,587.407 ns |    4 |      - |     - |     - |      64 B |
|                        |         |                  |                |                |                  |                  |      |        |       |       |           |
|   UsingHashsetContains |  100000 |         8.523 ns |      0.2030 ns |      0.3278 ns |         8.008 ns |         9.266 ns |    1 |      - |     - |     - |         - |
| UsingArrayBinarySearch |  100000 |        43.463 ns |      0.8862 ns |      1.1523 ns |        41.681 ns |        46.342 ns |    2 |      - |     - |     - |         - |
|     UsingArrayContains |  100000 |    24,873.798 ns |    418.8811 ns |    498.6481 ns |    24,211.707 ns |    26,209.180 ns |    3 |      - |     - |     - |         - |
|       UsingArrayExists |  100000 |   206,863.225 ns |  4,084.0980 ns |  4,011.1303 ns |   200,836.780 ns |   214,013.611 ns |    4 |      - |     - |     - |      64 B |
|                        |         |                  |                |                |                  |                  |      |        |       |       |           |
|   UsingHashsetContains | 1000000 |         4.479 ns |      0.0376 ns |      0.0334 ns |         4.410 ns |         4.548 ns |    1 |      - |     - |     - |         - |
| UsingArrayBinarySearch | 1000000 |        49.342 ns |      1.0137 ns |      1.6078 ns |        46.913 ns |        53.146 ns |    2 |      - |     - |     - |         - |
|     UsingArrayContains | 1000000 |   255,489.815 ns |  2,168.8992 ns |  1,693.3338 ns |   252,664.160 ns |   258,128.271 ns |    3 |      - |     - |     - |         - |
|       UsingArrayExists | 1000000 | 2,088,389.076 ns | 35,228.8179 ns | 32,953.0581 ns | 2,034,711.133 ns | 2,147,592.773 ns |    4 |      - |     - |     - |      64 B |
```

**`Tools`** : vs19, net 5.0
