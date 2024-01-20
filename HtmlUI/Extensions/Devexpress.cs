using HtmlUI.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;

namespace HtmlUI.Extensions
{
    public static class DevexpressUI
    {
        public static IHtmlContent Devexpress(this IHtmlHelper helper)
        {
            return new HtmlString(@$"
            <!--Script-->
            <script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
            <link rel=""stylesheet"" href=""https://cdn3.devexpress.com/jslib/23.2.3/css/dx.light.css"">
            <script type=""text/javascript"" src=""https://cdn3.devexpress.com/jslib/23.2.3/js/dx.all.js""></script>
            <!--Script-->
            {{ComponentDiv}}
            {{ComponentScript}}
            ");
        }
        public static IHtmlContent AddDatagrid(this IHtmlContent content, string DatagridId)
        {
            return new HtmlString(content.ToString()
                .Replace("{ComponentDiv}", @$"<div id='{DatagridId}'></div>")
                .Replace("{ComponentScript}", @$"<script>
                                                    $(() => {{
                                                        $('#{DatagridId}')
                                                        .dxDataGrid(/*ComponentModel*/{{ComponentConfig}}/*ComponentModel*/);
                                                    }}); 
                                                </script>"));
        }
        public static IHtmlContent AddDataSource(this IHtmlContent content, DevexpressDataSource devexpressDataSource)
        {
            var dtg = GetDatagrid(null);
            dtg.dataSource = devexpressDataSource;
            var json = JsonSerializer.Serialize(dtg);

            return new HtmlString(content.ToString()
                .Replace("{ComponentConfig}", json));
        }
        public static IHtmlContent AddPaging(this IHtmlContent content, DevexpressPaging devexpressPaging, DevexpressPager devexpressPager)
        {
            var dtg = GetDatagrid(content);
            dtg.pager = devexpressPager;
            dtg.paging = devexpressPaging;
            var json = JsonSerializer.Serialize(dtg);
            return ReadyTable(content, json);
        }
        public static IHtmlContent AddSelection(this IHtmlContent content, DevexpressSelection devexpressSelection)
        {
            var dtg = GetDatagrid(content);
            dtg.selection = devexpressSelection;
            var json = JsonSerializer.Serialize(dtg);
            return ReadyTable(content, json);
        }
        public static IHtmlContent AddSorting(this IHtmlContent content, DevexpressSorting devexpressSorting)
        {
            var dtg = GetDatagrid(content);
            dtg.sorting = devexpressSorting;
            var json = JsonSerializer.Serialize(dtg);
            return ReadyTable(content, json);
        }
        public static IHtmlContent AddFilterRow(this IHtmlContent content, DevexpressFilterRow devexpressFilterRow)
        {
            var dtg = GetDatagrid(content);
            dtg.filterRow = devexpressFilterRow;
            var json = JsonSerializer.Serialize(dtg);
            return ReadyTable(content, json);
        }
        public static IHtmlContent AddFilterPanel(this IHtmlContent content, DevexpressFilterPanel devexpressFilterPanel)
        {
            var dtg = GetDatagrid(content);
            dtg.filterPanel = devexpressFilterPanel;
            var json = JsonSerializer.Serialize(dtg);
            return ReadyTable(content, json);
        }
        public static IHtmlContent AddHeaderFilter(this IHtmlContent content, DevexpressHeaderFilter devexpressHeaderFilter)
        {
            var dtg = GetDatagrid(content);
            dtg.headerFilter = devexpressHeaderFilter;
            var json = JsonSerializer.Serialize(dtg);
            return ReadyTable(content, json);
        }
        private static HtmlString ReadyTable(IHtmlContent content, string newValue)
        {
            var list = content?.ToString()?.Split("/*ComponentModel*/");
            return new HtmlString(list?[0] + "/*ComponentModel*/" + newValue + "/*ComponentModel*/" + list[2]);
        }
        private static DevexpressDatagrid GetDatagrid(IHtmlContent content)
        {
            if (content == null)
            {
                return new DevexpressDatagrid();
            }
            var list = content?.ToString()?.Split("/*ComponentModel*/");
            var dtg = JsonSerializer.Deserialize<DevexpressDatagrid>(list[1]);
            return dtg;
        }

    }
}
