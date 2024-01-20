namespace HtmlUI.Models
{
    public class DevexpressSelection
    {
        public DevexpressSelection(string mode = "single")
        {
            this.mode = mode;
        }

        public string mode { get; set; } = "single";
    }
}
