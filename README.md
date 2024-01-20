
# DevExpress Html Extension
## Tanım:
Jquery kütüphanesiyle kullanılan DevExpress'in OData servis ile  doldurulan Data Grid nesnesini extension metot kullanarak oluşturdum.

Kullanımı buradan Views/Home/Index.cshtml inceleyebilirsiniz.

[DevExpress](https://js.devexpress.com/jQuery/)

[OData Data Grid Örneği](https://js.devexpress.com/jQuery/Demos/WidgetsGallery/Demo/DataGrid/OdataService/MaterialBlueLight/)
## Amaç:
- Controller View'lerinde javascript kodu yazmadan html extension metotlar ile DevExpress Data Grid nesnesini oluşturmak. 

- Dinamik olarak Controller'dan data grid'in parametrelerini gönderip viewler oluşturmak.
## Geliştirme Adımları:
- IHtmlHelper interface'inden türeyen @Html sınıfına extension metot ile arayüzde gözükebilecek nesneler üretmek

- Extension metotta ürettiğimiz nesnenin özelliklerini değiştirmek

## Html Extension Metot Kullanımı

#### Yeni nesne üretmek için Extension metot örneği

```cs
public static IHtmlContent AddParagraph(this IHtmlHelper helper,string content)
{
    return new HtmlString($"<p>{content}</p>");
}
```
```cs
@Html.AddParagraph("yeni paragraf nesnesi")
```
![yeni-paragraf-nesnesi](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/bae5cb18-ba7f-496e-817a-2ba99f23ad71)

#### DevExpress için kütüphaneleri ve div nesnesini Html'a eklemek
```cs
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
```
> [!NOTE]
> Burdaki script ve stil _Layout.cshtml'de yazılabilir. Her sayfada bu dosyaları kullanmak istemediğim için buraya yazdım.

> [!NOTE]
> {{ComponentDiv}} ve {{ComponentScript}} string.Replace yapacağımız için önemlidir.

#### DevExpress için eklediğimiz div ve js kod bloğuna ekleme yapmak

```cs
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
```

## Ekran Görüntüleri
![image](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/c7c11496-1b52-4dfb-8895-3d0906b28498)
![image](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/513d6798-09de-4963-8852-c51683be7de0)
![image](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/90aafd78-66b6-4361-960e-bf042d549cb7)



## İletişim

İletişim için orhanufukgulec@gmail.com adresine e-posta gönderin.
