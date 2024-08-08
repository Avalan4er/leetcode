using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using Xunit.Abstractions;

namespace _0006_zigzag_conversion;

public class Benchmarks
{
    private readonly ITestOutputHelper output;

    public Benchmarks(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void Run_Benchmarks()
    {
        var logger = new AccumulationLogger();

        var config = ManualConfig.Create(DefaultConfig.Instance)
            .AddLogger(logger)
            .WithOptions(ConfigOptions.DisableOptimizationsValidator);

        BenchmarkRunner.Run<SolutionBenchmarks>(config);

        // write benchmark summary
        output.WriteLine(logger.GetLog());
    }
}
