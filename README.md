# DevExpressHtmlExtension

**DevExpressHtmlExtension**, DevExpress HTML Editor üzerinde özel işlevler ve kullanıcı etkileşimleri geliştirmek amacıyla hazırlanmış örnek bir extension çalışmasıdır.

Proje, DevExpress tabanlı HTML düzenleme bileşenlerinin mevcut özelliklerinin özel ihtiyaçlara göre nasıl genişletilebileceğini göstermek amacıyla oluşturulmuştur.

## 🎯 Amaç

DevExpress HTML Editor, zengin metin ve HTML içeriklerinin oluşturulması ve düzenlenmesi için kullanılan bir editör bileşenidir.

Bu proje ile amaçlanan; standart HTML Editor davranışının üzerine özel bir extension katmanı ekleyerek:

* Özel komutlar oluşturmak
* Editor davranışını genişletmek
* Client-side etkileşimleri yönetmek
* HTML içeriğine müdahale etmek
* Mevcut editor API'lerini uygulamaya özel ihtiyaçlara uyarlamak

gibi senaryoları incelemektir.

## ✨ Özellikler

* DevExpress HTML Editor entegrasyonu
* Custom extension yaklaşımı
* HTML içerik yönetimi
* Client-side editor etkileşimleri
* Özel komut / toolbar işlemleri
* JavaScript ile editor entegrasyonu
* .NET uygulaması içerisinde DevExpress bileşenlerinin genişletilmesi

## 🏗️ Genel Yaklaşım

Projenin temel yaklaşımı:

```text
┌─────────────────────────┐
│     .NET Application    │
└────────────┬────────────┘
             │
             ▼
┌─────────────────────────┐
│   DevExpress HTML       │
│        Editor           │
└────────────┬────────────┘
             │
             ▼
┌─────────────────────────┐
│   Custom Extension      │
│                         │
│  • Custom Commands      │
│  • Editor Events        │
│  • HTML Manipulation    │
│  • JavaScript           │
└─────────────────────────┘
```

Bu yapı sayesinde DevExpress tarafından sağlanan standart editor fonksiyonları, uygulamanın ihtiyaçlarına göre genişletilebilir.

## 🛠️ Teknolojiler

| Teknoloji      | Kullanım                      |
| -------------- | ----------------------------- |
| **C#**         | Backend / uygulama geliştirme |
| **.NET**       | Uygulama altyapısı            |
| **DevExpress** | UI / HTML Editor              |
| **HTML**       | İçerik                        |
| **JavaScript** | Client-side editor işlemleri  |
| **CSS**        | UI özelleştirmeleri           |

## 🔌 Extension Yaklaşımı

Extension mimarisinin temel amacı, mevcut bir UI component'inin davranışını değiştirmek yerine onu kontrollü şekilde genişletmektir.

Örneğin:

```text
Standard HTML Editor
        │
        ├── Toolbar
        ├── Formatting
        ├── HTML Content
        └── Events
               │
               ▼
       Custom Extension
               │
               ├── Custom Command
               ├── Custom UI
               └── Custom Behavior
```

Bu yaklaşım özellikle kurumsal uygulamalarda standart component'lerin müşteri veya proje gereksinimlerine göre özelleştirilmesi gereken durumlarda kullanılabilir.

## 📋 Kullanım Senaryoları

Benzer bir extension yaklaşımı aşağıdaki senaryolarda kullanılabilir:

* Kurumsal içerik editörleri
* E-posta şablon editörleri
* Doküman içerik yönetimi
* Bildirim şablonları
* Workflow açıklama alanları
* CMS içerik yönetimi
* Özel HTML template editörleri
* Dinamik form açıklamaları
* Rich-text tabanlı kullanıcı içerikleri

## ⚙️ Kurulum

Repository'yi klonlayın:

```bash
git clone https://github.com/ufukgulec/DevExpressHtmlExtension.git

cd DevExpressHtmlExtension
```

Projeyi IDE üzerinden açın:

```text
Visual Studio
JetBrains Rider
VS Code
```

Gerekli DevExpress paketlerinin ve lisans yapılandırmasının bulunduğu ortamda projeyi restore ederek çalıştırabilirsiniz.

```bash
dotnet restore
dotnet build
```
## Ekran Görüntüleri
![image](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/c7c11496-1b52-4dfb-8895-3d0906b28498)
![image](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/513d6798-09de-4963-8852-c51683be7de0)
![image](https://github.com/ufukgulec/DevExpressHtmlExtension/assets/51711890/90aafd78-66b6-4361-960e-bf042d549cb7)


## 🔐 HTML İçerik Güvenliği

HTML içeriği kullanıcı tarafından oluşturuluyor veya sunucuya gönderiliyorsa güvenlik konusu önemlidir.

Özellikle dış kullanıcıların HTML içeriği oluşturabildiği uygulamalarda:

* HTML sanitization
* XSS protection
* Allowed HTML tags
* Allowed attributes
* URL validation
* Script filtering

gibi kontroller uygulanmalıdır.

HTML Editor benzeri bileşenlerde kullanıcı tarafından sağlanan HTML'in doğrudan güvenilir kabul edilmemesi gerekir. DevExpress'in farklı HTML Editor örneklerinde de editor yetenekleri ve içerik işleme yaklaşımı öne çıkarılmaktadır.

## 🎯 Projenin Amacı

Bu repository, DevExpress bileşenlerinin yalnızca hazır özelliklerini kullanmak yerine, mevcut component'lerin **uygulama ihtiyaçlarına göre nasıl genişletilebileceğini** göstermek amacıyla hazırlanmıştır.

Özellikle şu konularda pratik örnek sunmaktadır:

* DevExpress component customization
* HTML Editor extension
* Client-side JavaScript integration
* Custom UI behavior
* HTML content manipulation
* .NET ve JavaScript birlikte kullanımı

## 🚀 Geliştirme Fikirleri

Extension yapısı daha kapsamlı hale getirilerek aşağıdaki özellikler eklenebilir:

* [ ] Custom toolbar button
* [ ] Custom editor command
* [ ] HTML template sistemi
* [ ] Reusable component / extension paketi
* [ ] Image upload
* [ ] Template variable desteği
* [ ] Dynamic content insertion
* [ ] HTML sanitization
* [ ] Custom keyboard shortcuts
* [ ] Localization
* [ ] Unit / integration tests
* [ ] NuGet package olarak dağıtım

## 📚 DevExpress

Bu proje DevExpress bileşenleri üzerine geliştirilmiş bağımsız bir örnek çalışmadır.

DevExpress'in resmi örneklerinde de HTML Editor'ın extension ve custom command yaklaşımıyla genişletilebildiği görülmektedir.

## 👤 Author

**Ufuk Güleç**

* GitHub: https://github.com/ufukgulec
* Portfolio: https://ufukgulec.github.io/

---

> Bu repository, DevExpress HTML Editor'ın uygulamaya özel ihtiyaçlar doğrultusunda genişletilmesini incelemek amacıyla hazırlanmıştır.


## İletişim

İletişim için orhanufukgulec@gmail.com adresine e-posta gönderin.
