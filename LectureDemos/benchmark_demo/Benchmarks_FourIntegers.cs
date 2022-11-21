using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace benchmark_demo;

[RankColumn]
[Orderer(SummaryOrderPolicy.FastestToSlowest)]
[MemoryDiagnoser]
[AsciiDocExporter, RPlotExporter, JsonExporter]
public class Benchmarks_FourIntegers
{

    const int ArraySize = 4;
    const string IntegerStringCsv = "163,496,691,1729";

    static readonly int[] fillGetIntegerArray = new int[ArraySize];

    [Benchmark(Baseline = true)]
    public void RunSimplestVersion()
    {
        GetIntegerArray_Simplest(IntegerStringCsv, fillGetIntegerArray);
    }

    [Benchmark]
    public void RunOneLinerVersion()
    {
        GetIntegerArray_OneLiner(IntegerStringCsv, fillGetIntegerArray);
    }

    //[Benchmark]
    //public void RunOneLinerParallelizedVersion()
    //{
    //    GetIntegerArray_OneLinerParallelized(IntegerStringCsv, fillGetIntegerArray);
    //}

    [Benchmark]
    public void RunFasterVersion()
    {
        GetIntegerArrayUsingSpan_Faster(IntegerStringCsv, fillGetIntegerArray);
    }

    [Benchmark]
    public void RunFastestVersion()
    {
        GetIntegerArrayUsingPerCharacterParsing_Fastest(IntegerStringCsv, fillGetIntegerArray);
    }

    static void GetIntegerArray_Simplest(string commaSeparatedIntegers, int[] arrayToFill)
    {
        // Split() allocates an array of strings
        string[] arrayOfString = commaSeparatedIntegers.Split(',');

        //loop through strings, convert to integer, and add to integer array
        var length = arrayOfString.Length;
        for (int i = 0; i < length; i++)
        {
            arrayToFill[i] = int.Parse(arrayOfString[i]);
        }
    }

    //It's not unusual for one-line solutions to be written quickly.
    //As long as it's readable and fast enough, great. 
    //But if you need speed, you will quickly lose such compact code.
    static void GetIntegerArray_OneLiner(string commaSeparatedIntegers, int[] arrayToFill)
    {
        //split on commas, then loop over elements via LINQ Select parsing each string,
        //then convert IEnumerable to array.
        arrayToFill = commaSeparatedIntegers
            .Split(',')
            .Select(i => int.Parse(i))
            .ToArray();
    }

    //The general line of thinking is that multithreading your work is faster.
    //It's often not. This will demonstrate that.
    static void GetIntegerArray_OneLinerParallelized(string commaSeparatedIntegers, int[] arrayToFill)
    {

        //split on commas, then loop over elements via LINQ Select parsing each string,
        //then convert IEnumerable to array.
        arrayToFill = commaSeparatedIntegers
            .Split(',')
            .AsParallel()
            .Select(i => int.Parse(i))
            .ToArray();
    }

    //This uses the Span<T> structure introduced in .NET 6 to improve performance.
    //It is much faster and uses less memory, but it requires some understanding of how
    //C# uses memory and the code is less easy to read with higher cyclomatic complexity.
    static void GetIntegerArrayUsingSpan_Faster(string commaSeparatedIntegers, int[] arrayToFill)
    {
        // View the string as a span, so we can slice it in loop
        ReadOnlySpan<char> span = commaSeparatedIntegers.AsSpan();
        int nextCommaIndex = 0;
        int insertValAtIndex = 0;
        bool isLastLoop = false;
        while (!isLastLoop)
        {
            int indexStart = nextCommaIndex;
            nextCommaIndex = commaSeparatedIntegers.IndexOf(',', indexStart);

            isLastLoop = (nextCommaIndex == -1);
            if (isLastLoop)
            {
                nextCommaIndex = commaSeparatedIntegers.Length; // Parse last uint
            }

            // Get a slice of the string that contains the next uint...
            ReadOnlySpan<char> slice = span.Slice(indexStart, nextCommaIndex - indexStart);
            // ... and parse it
            var valParsed = int.Parse(slice);

            // Then insert valParsed in arrayToFill
            arrayToFill[insertValAtIndex] = valParsed;
            insertValAtIndex++;

            // Skip the comma for next iteration
            nextCommaIndex++;
        }
    }

    //This is the fastest method here. It also allocates zero memory.
    //But it's also the least readable.
    static void GetIntegerArrayUsingPerCharacterParsing_Fastest(string commaSeparatedIntegers, int[] arrayToFill)
    {
        var length = commaSeparatedIntegers.Length;
        int insertValAtIndex = 0;
        int valParsed = 0; // Don't use a uint to avoid casting in astute parsing formula
        for (int i = 0; i < length; i++)
        {
            char @char = commaSeparatedIntegers[i];
            if (@char != ',')
            {
                // Astute Parsing: Modify valParsed from the actual @char
                valParsed = valParsed * 10 + (@char - '0');
                continue;
            }
            // A comma is an opportunity to insert valParsed in arrayToFill
            arrayToFill[insertValAtIndex] = (int)valParsed;
            insertValAtIndex++;
            valParsed = 0;
        }
        // Insert last valParsed
        arrayToFill[insertValAtIndex] = (int)valParsed;
    }
}