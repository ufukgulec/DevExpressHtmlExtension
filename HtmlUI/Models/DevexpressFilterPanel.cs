namespace HtmlUI.Models
{
    public class DevexpressFilterPanel
    {
        public DevexpressFilterPanel(bool visible)
        {
            this.visible = visible;
        }

        public bool visible { get; set; } = true;
    }
}