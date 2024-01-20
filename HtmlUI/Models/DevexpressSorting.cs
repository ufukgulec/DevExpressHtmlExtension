namespace HtmlUI.Models
{
    public class DevexpressSorting
    {
        public DevexpressSorting(string mode = "single")
        {
            this.mode = mode;
        }

        public string mode { get; set; } = "single";
    }
}
