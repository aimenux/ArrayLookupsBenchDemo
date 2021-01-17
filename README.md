# ArrayLookupsBenchDemo
```
Benchmarking various ways for array lookups
```

In this demo, i m using [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet) library in order to benchmark various ways of sorted/unsorted array lookups :
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

**`Tools`** : vs19, net 5.0
