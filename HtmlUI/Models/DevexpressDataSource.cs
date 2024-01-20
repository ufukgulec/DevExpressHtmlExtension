using static System.Formats.Asn1.AsnWriter;

namespace HtmlUI.Models
{
    public class DevexpressDataSource
    {
        public DevexpressDataSource(DevexpressStore store, List<string> select, List<object> filter)
        {
            this.store = store;
            this.select = select;
            this.filter = filter;
        }

        public DevexpressStore store { get; set; }
        public List<string> select { get; set; }
        public List<object> filter { get; set; }
    }
}
