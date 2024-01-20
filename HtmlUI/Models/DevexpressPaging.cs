namespace HtmlUI.Models
{
    public class DevexpressPaging
    {
        public DevexpressPaging(int pageSize)
        {
            this.pageSize = pageSize;
        }

        public int pageSize { get; set; } = 10;
    }
}
