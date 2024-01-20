namespace HtmlUI.Models
{
    public class DevexpressPager
    {
        public DevexpressPager(bool visible, List<object> allowedPageSizes, bool showPageSizeSelector, bool showInfo, bool showNavigationButtons)
        {
            this.visible = visible;
            this.allowedPageSizes = allowedPageSizes;
            this.showPageSizeSelector = showPageSizeSelector;
            this.showInfo = showInfo;
            this.showNavigationButtons = showNavigationButtons;
        }

        public bool visible { get; set; }
        public List<object> allowedPageSizes { get; set; }
        public bool showPageSizeSelector { get; set; }
        public bool showInfo { get; set; }
        public bool showNavigationButtons { get; set; }
    }
}
