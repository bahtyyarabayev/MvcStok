# MvcStok - Stok Takip Sistemi

Bu proje, **ASP.NET MVC 5** ve **Entity Framework 6** kullanılarak geliştirilmiş web tabanlı bir stok takip otomasyonudur. Ürünlerin, kategorilerin, müşterilerin ve satış işlemlerinin yönetimini sağlar.

## 🚀 Özellikler

Proje içerisinde aşağıdaki temel modüller bulunmaktadır:

* **Ürün Yönetimi:** Ürün ekleme, listeleme, güncelleme ve silme işlemleri.
* **Kategori Yönetimi:** Ürünlerin kategorize edilmesi ve kategori yönetimi.
* **Müşteri Yönetimi:** Müşteri kayıtlarının tutulması ve düzenlenmesi.
* **Satış İşlemleri:** Müşterilere ürün satışının gerçekleştirilmesi ve takibi.
* **Veritabanı İşlemleri:** Entity Framework (Database First) yaklaşımı ile veri yönetimi.

## 🛠 Kullanılan Teknolojiler

* **Platform:** .NET Framework 4.7.2
* **Framework:** ASP.NET MVC 5
* **ORM:** Entity Framework 6.0 (Database First)
* **Veritabanı:** Microsoft SQL Server (MSSQL)
* **Front-End:** Bootstrap, HTML5, CSS3, jQuery

## ⚙️ Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1.  **Projeyi Klonlayın:**
    ```bash
    git clone [https://github.com/kullaniciadi/MvcStok.git](https://github.com/kullaniciadi/MvcStok.git)
    ```

2.  **Veritabanı Yapılandırması (Önemli):**
    Proje `Web.config` dosyasında belirli bir SQL Server örneğine (`DESKTOP-TKHFJ4C\MSSQLSERVER01`) bağlanacak şekilde yapılandırılmıştır. Projeyi çalıştırmadan önce **Web.config** dosyasını açın ve `connectionStrings` bölümünü kendi veritabanı sunucunuza göre güncelleyin.
    *Not: `MvcDB` adında bir veritabanı oluşturmanız ve Model1.edmx dosyasındaki yapıya uygun tabloları (TblUrun, TblMusteri, TblCategory, TblSatis) oluşturmanız gerekebilir.*

3.  **Visual Studio ile Açın:**
    `MvcStok.sln` dosyasını Visual Studio kullanarak açın.

4.  **Paketleri Yükleyin:**
    `Tools > NuGet Package Manager > Package Manager Console` üzerinden veya Solution'a sağ tıklayarak "Restore NuGet Packages" diyerek gerekli bağımlılıkları yükleyin.

5.  **Çalıştırın:**
    `F5` tuşuna basarak veya "Start" butonuna tıklayarak projeyi tarayıcıda başlatın.

## 📂 Proje Yapısı

* **Controllers:** Sayfa yönlendirmeleri ve iş mantığı (UrunController, MusteriController vb.).
* **Models:** Veritabanı tablolarına karşılık gelen Entity sınıfları (TblUrun, TblMusteri vb.).
* **Views:** Kullanıcı arayüzü sayfaları (.cshtml dosyaları).

## 📝 Lisans

Bu proje açık kaynaklıdır ve geliştirmeye açıktır.

