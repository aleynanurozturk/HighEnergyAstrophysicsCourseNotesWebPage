Yüksek Enerji Astrofiziği Ders Notları Web Sayfası
Bu proje, ASP.NET Core MVC ve Entity Framework Core kullanarak geliştirilmiş, güvenli bir "Yüksek Enerji Astrofiziği" ders notları web sitesidir. Amacı, SQL Server veritabanı ile kullanıcı kimlik doğrulama (authentication) ve yetkilendirme (authorization) süreçlerini uygulamalı olarak öğrenmek ve bu bilgileri bir web sitesinde kullanmaktır.

Sitenin ana işlevi, yalnızca kayıtlı ve giriş yapmış kullanıcıların ders notlarına erişmesine olanak sağlamaktır. Bu proje aynı zamanda bir öğrenme süreci ürünüdür ve aşağıdaki temel ASP.NET Core MVC konularının pratik uygulamasını içermektedir:

Kullanılan Teknolojiler
ASP.NET Core MVC: Web uygulamasının temel çatısı.

Entity Framework Core: Veritabanı işlemleri için kullanılan ORM (Object-Relational Mapper).

ASP.NET Core Identity: Kullanıcı yönetimi (kayıt, giriş, şifre sıfırlama vb.) için güçlü bir kimlik doğrulama sistemi.

SQL Server: Kullanıcı verilerini ve diğer site verilerini saklamak için kullanılan veritabanı.

C#: Projenin temel programlama dili.

HTML, CSS, JavaScript: Web sitesinin ön yüzü için kullanılan standart web teknolojileri.

Projenin Temel Özellikleri
Kullanıcı Kayıt Sistemi: Yeni kullanıcıların güvenli bir şekilde kaydolabilmesi. E-posta doğrulama sistemi entegre edilmiştir.

Özel Giriş ve Kayıt Sayfaları: Standart Identity sayfaları yerine, özelleştirilmiş ve kullanıcı dostu arayüzler.

Güvenli Alanlar: Yalnızca giriş yapmış kullanıcıların erişebildiği yetkilendirilmiş (authorized) sayfalar.

Şifre Yönetimi: Kullanıcılara şifrelerini unutmaları durumunda sıfırlama imkanı sunan bir sistem.

Veritabanı Entegrasyonu: Entity Framework Core ile SQL Server'a veri ekleme, okuma ve güncelleme işlemleri.

Model-View-Controller (MVC) Yapısı: Proje, veri, görünüm ve kontrol mantığını ayıran standart bir MVC mimarisiyle tasarlanmıştır.

Kurulum ve Çalıştırma
Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

Projeyi klonlayın:

git clone [https://github.com/aleynanurozturk/HighEnergyAstrophysicsCourseNotesWebPage.git](https://github.com/aleynanurozturk/HighEnergyAstrophysicsCourseNotesWebPage.git)

Visual Studio'da projeyi açın.

appsettings.json dosyasında SQL Server bağlantı dizgisi (connection string) ayarlarınızı yapın.

Paket yöneticisi konsolunu (Tools > NuGet Package Manager > Package Manager Console) açarak veritabanı geçişlerini (migrations) uygulayın:

Update-Database

Uygulamayı çalıştırın (F5 tuşu).

Gelecek Planları
Ders notları için içerik yönetim sistemi (CMS) eklenmesi.

Kullanıcı profili sayfalarının geliştirilmesi.

İçeriklerin kategori bazlı filtrelenmesi ve aranabilir hale getirilmesi.

Duyarlı tasarımın (responsive design) daha da iyileştirilmesi.

Katkıda Bulunma
Bu proje bir öğrenme süreci ürünüdür ve geliştirilmeye açıktır. Her türlü öneri ve katkı memnuniyetle karşılanır.
