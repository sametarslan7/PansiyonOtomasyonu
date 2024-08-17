 PANSİYON KAYIT UYGULAMASI
 
Bu proje, basit bir pansiyon-müşteri kayıt uygulaması olup, Back-End kısmı C# ile, Front-End kısmı ise Windows Form ile geliştirilmiştir. Uygulama, pansiyon yönetimini kolaylaştırmak için temel ihtiyaçları karşılayacak şekilde tasarlanmıştır.

ÖZELLİKLER

• Kullanıcı Girişi ve Kayıt: Kullanıcı adı ve şifre ile güvenli giriş ve yeni kullanıcı kayıt işlemleri.

• Yeni Müşteri Ekleme: Müşteriler, görsel bir arayüz üzerinden oda numaraları seçilerek eklenebilir. Dolu odalar kırmızı, boş odalar ise yeşil renkte gösterilir.

• Müşteri Yönetimi: Müşterilerin bilgileri güncellenebilir veya silinebilir. Ayrıca, müşteri isimlerine göre arama yapma imkanı sunar.

• Oda Yönetimi: Odaların dolu-boş durumları görüntülenebilir ve dolu odaların detaylarına erişim sağlanabilir.

• Admin Yönetimi: Uygulamayı kullanabilecek yöneticilerin listelendiği ayrı bir yönetim formu bulunmaktadır.


KURULUM

Gereksinimler

• .NET Framework

• MSSQL Server
  
Adımlar

1.Projeyi bilgisayarınıza klonlayın:

    git clone https://github.com/kullanici/pansiyon-kayit.git

cd pansiyon-kayit

2.Projeyi Visual Studio ile açın ve derleyin.

3.Uygulamayı çalıştırmadan önce, kendi veritabanı bağlantı bilgilerinizi app.config dosyasında yer alan bağlantı dizesine girin. Aksi takdirde, veritabanı işlemleri çalışmayacaktır.

Veritabanı Yapısı

• Uygulamada kullanılan veritabanında iki tablo bulunmaktadır: TBLADMIN ve TBLMUSTERI. Bu tabloları oluşturmak için aşağıdaki SQL komutlarını kullanabilirsiniz.


TBLMUSTERI


    CREATE TABLE [dbo].[TBLMUSTERI](

    [MUSTERIID] [int] IDENTITY(1,1) NOT NULL,
    
    [MUSTERIAD] varchar NULL,
    
    [MUSTERISOYAD] varchar NULL,
    
    [MUSTERITELEFON] varchar NULL,
    
    [MUSTERIMAIL] varchar NULL,
    
    [MUSTERITC] varchar NULL,
    
    [ODANO] varchar NULL,
    
    [GIRISTARIHI] [date] NULL,
    
    [CIKISTARIHI] [date] NULL,
    
    [UCRET] varchar NULL,
    
    PRIMARY KEY ([MUSTERIID])

    )


TBLADMIN

    CREATE TABLE [dbo].[TBLADMIN](

    [ADMINID] [int] IDENTITY(1,1) NOT NULL,
    
    [ADMINKULLANICIAD] varchar NULL,
    
    [ADMINSIFRE] varchar NULL,
    
    PRIMARY KEY ([ADMINID])

    )


UYARILAR

- Uygulamayı kendi bilgisayarınızda çalıştırmak için veritabanı bağlantı bilgilerini app.config dosyasına kendi bilgilerinizi girerek düzenlemelisiniz. Aksi takdirde, uygulama veri tabanına bağlanamayacak ve hata verecektir.

Yazarlar

Samet ARSLAN - Geliştirici - (https://github.com/sametarslan7)

Lisans

Bu proje MIT Lisansı ile lisanslanmıştır.
