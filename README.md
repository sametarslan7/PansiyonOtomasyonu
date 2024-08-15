+ Basit bir pansiyon - müşteri kayıt uygulaması amaçlandı.

+ Back-End  kısmı C# ile , Front-End kısmı da Windows Form ile geliştirildi.

+ Fazla detaya girmeden ama ana ihtiyaçları da sorunsuz bir şekilde karşılayan bir uygulama oldu .

✓  Kullanıcı adı ve şifre ile giriş - kayıt işlemleri yapılabilir düzeyde  

✓  Yeni Müşteri eklenebilir , bu ekleme sırasında oda numaraları görsellerden seçilebilir şekilde tasarlandı . 
  ✓  Yeni Müşteri Ekleme formunda dolu odalar kırmızı , boş odalar yeşil renkte olacack şekilde ayarlandı.

✓  Müşterilerin bilgilerini güncelleme veya silme işlemlerinin yapılabileceği Müşteriler formu oluşturuldu.
  ✓  Ayrıca yine bu formda müşterinin ismine göre arama yapıp bilgilerini görebileceğimiz kısım da yapıldı.

✓  Odaların dolu-boş durumlarını görebileceğimiz , ayrı olarak dolu odalaarın bilgilerine erişebileceğimiz Oda ve Oda Detay formları oluşturuldu.

✓  Ekstra olarak uygulamayı kullanabilecek olan yöneticilerin listelendiği Adminler formu da oluşturuldu.

--- UYARI ---

( Uygulamayı kendi bilgisayarında çalıştırıp denemek isteyen kişiler , veri tabanı bağlantısı kısmında sıkıntı yaşamamak adına , kendi veir tabanı bilgilerini ilgili kısımlara girmelidir. 
Aksi durumda veri tabanına kayıt işlemleri çalışmayacak ve uygulama hata verecektir. )

Uygulamada TBLADMIN ve TBLMUSTERI adında 2 tablo oluşturulmuştur . Bu tabloların create kodu aşağıdaki gibidir : 

--TBLMUSTERİ --

CREATE TABLE [dbo].[TBL_TABLOADI](
	[MUSTERIID] [int] IDENTITY(1,1) NOT NULL,
	[MUSTERIAD] [varchar](50) NULL,
	[MUSTERISOYAD] [varchar](50) NULL,
	[MUSTERITELEFON] [varchar](15) NULL,
	[MUSTERIMAIL] [varchar](50) NULL,
	[MUSTERITC] [varchar](12) NULL,
	[ODANO] [varchar](3) NULL,
	[GIRISTARIHI] [date] NULL,
	[CIKISTARIHI] [date] NULL,
	[UCRET] [varchar](20) NULL,)

