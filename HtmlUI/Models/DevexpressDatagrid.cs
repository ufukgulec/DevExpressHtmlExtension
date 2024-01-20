namespace HtmlUI.Models
{
    public class DevexpressDatagrid
    {
        public DevexpressDatagrid()
        {

        }
        public bool showBorders { get; set; } = true;
        public DevexpressDataSource dataSource { get; set; }
        public List<object> columns { get; set; }
        public DevexpressPaging paging { get; set; }
        public DevexpressPager pager { get; set; }
        public DevexpressSelection selection { get; set; }
        public DevexpressSorting sorting { get; set; }
        public DevexpressFilterRow filterRow { get; set; }
        public DevexpressFilterPanel filterPanel { get; set; }
        public DevexpressHeaderFilter headerFilter { get; set; }
    }
}
