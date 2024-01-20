namespace HtmlUI.Models
{
    public class DevexpressHeaderFilter
    {
        public bool visible { get; set; } = true;

        public DevexpressHeaderFilter(bool visible)
        {
            this.visible = visible;
        }
    }
}