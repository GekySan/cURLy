namespace Curly
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Test.GetLibCurlVersionAsync();

            string[] urls = new string[]
            {
                "https://httpbin.org/headers",
                "https://tls.peet.ws/api/tls",
                "https://am.i.mullvad.net/country"
            };

            string filePath = "multi-thread.txt";

            await Test.RunAsync(urls, filePath, 20);

            Console.WriteLine("All threads have completed.");
        }
    }
}
