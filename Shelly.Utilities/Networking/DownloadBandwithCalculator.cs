namespace Shelly.Utilities.Networking;

public static class DownloadBandwithCalculator
{
    private const string UrlOne = "https://speed.cloudflare.com/__down?bytes=";

    private static readonly int[] Sizes = [100,1000,5000];

    private const int MaxRetiresPerUrl = 2;
    
    
}


