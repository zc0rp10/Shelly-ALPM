namespace Shelly.Utilities.Networking;

public struct NetworkBandwithStats
{
    public long AverageBitsPerSecond { get; set; }
    public long MedianBitsPerSecond { get; set; }
    public long MinimumBitsPerSecond { get; set; }
    public long MaximumBitsPerSecond { get; set; }
    public long SampleCount { get; set; }
}