namespace HtmlUI.Models
{
    public class DevexpressStore
    {
        public DevexpressStore(string type, int version, string url, string key)
        {
            this.type = type;
            this.version = version;
            this.url = url;
            this.key = key;
        }

        public string type { get; set; }
        public int version { get; set; }
        public string url { get; set; }
        public string key { get; set; }
    }
}
