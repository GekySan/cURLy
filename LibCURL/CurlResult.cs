namespace Curly.LibCURL
{
    public class CurlResult
    {
        public string Response { get; set; } = string.Empty;
        public string ResponseUrl { get; set; } = string.Empty;
        public string IpAddress { get; set; } = string.Empty;
        public long ResponseCode { get; set; }
    }
}

